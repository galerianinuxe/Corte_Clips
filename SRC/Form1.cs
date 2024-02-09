using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Microsoft.Win32;
using System.Drawing.Text;

namespace NinuxeCortes
{
    public partial class Form1 : Form
    {
        private readonly string ffmpegPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "ffmpeg.exe");
        private string[] selectedFilePaths;  // Variável para armazenar o caminho do arquivo MKV selecionado


        public Form1()
        {
            InitializeComponent();
            btnSelectVid.Click += btnSelectVid_Click;
            btnSelectDestin.Click += btnSelectDestin_Click;
            btnConvert.Click += OnConvertClick;

        }

        private void btnSelecionarVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Vídeo|*.mp4;*.avi;*.mov|Todos os arquivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLocalVideo.Text = openFileDialog.FileName;

                    try
                    {
                        string duration = GetVideoDuration(txtLocalVideo.Text);
                        TimeSpan durationTimeSpan = TimeSpan.ParseExact(duration, "g", null);

                        lbDuracao.Text = $"Duração: {durationTimeSpan.ToString(@"hh\:mm\:ss")}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter a duração do vídeo: {ex.Message}");
                    }
                }
            }
        }

        private string GetVideoDuration(string videoPath)
        {
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = $"-i \"{videoPath}\"",
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                process.StartInfo = startInfo;

                process.Start();

                string errorOutput = process.StandardError.ReadToEnd();

                process.WaitForExit();

                Regex regex = new Regex(@"Duration: (\d+:\d+:\d+\.\d+)");
                Match match = regex.Match(errorOutput);

                if (match.Success)
                {
                    string duration = match.Groups[1].Value;
                    TimeSpan durationTimeSpan = TimeSpan.ParseExact(duration, @"hh\:mm\:ss\.ff", CultureInfo.InvariantCulture);
                    return durationTimeSpan.ToString(@"hh\:mm\:ss");
                }
                else
                {
                    throw new Exception("Não foi possível obter a duração do vídeo.");
                }
            }
        }

        private void btnSelecionarDestino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestinoVideo.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private async Task RunFFmpegAsync(string arguments, CancellationToken cancellationToken)
        {
            using (Process process = new Process())
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = ffmpegPath,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };

                process.StartInfo = startInfo;

                StringBuilder outputStringBuilder = new StringBuilder();
                StringBuilder errorStringBuilder = new StringBuilder();

                process.OutputDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        outputStringBuilder.AppendLine(e.Data);
                    }
                };

                process.ErrorDataReceived += (sender, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                    {
                        errorStringBuilder.AppendLine(e.Data);
                    }
                };

                process.Start();

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                await Task.Run(() =>
                {
                    process.WaitForExit();
                }, cancellationToken);

                string output = outputStringBuilder.ToString();
                string error = errorStringBuilder.ToString();

                if (process.ExitCode != 0)
                {
                    throw new Exception($"Erro ao executar o FFmpeg: {error}");
                }
            }
        }

        private async void btnCortar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocalVideo.Text) || string.IsNullOrWhiteSpace(txtDestinoVideo.Text))
            {
                MessageBox.Show("Por favor, selecione o vídeo e o destino antes de cortar.");
                return;
            }

            btnCortar.Enabled = false;

            int durationPerPartInSeconds = 600;

            try
            {
                var inputFile = txtLocalVideo.Text;
                var outputDirectory = txtDestinoVideo.Text;
                var extension = Path.GetExtension(inputFile);

                int i = 0;
                double totalDuration = TimeSpan.ParseExact(GetVideoDuration(inputFile), "g", null).TotalSeconds;

                progressBar1.Minimum = 0;
                progressBar1.Maximum = 101;

                var cancellationTokenSource = new CancellationTokenSource();

                while (i * durationPerPartInSeconds < totalDuration)
                {
                    var outputFile = Path.Combine(outputDirectory, $"part_{i:D3}{extension}");
                    string startTime = TimeSpan.FromSeconds(i * durationPerPartInSeconds).ToString(@"hh\:mm\:ss");

                    try
                    {
                        await RunFFmpegAsync($"-ss {startTime} -i \"{inputFile}\" -t {durationPerPartInSeconds} -c copy \"{outputFile}\"", cancellationTokenSource.Token);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro durante o processo de corte: {ex.Message}");
                        cancellationTokenSource.Cancel();
                        return;
                    }

                    i++;

                    double progress = (double)i * durationPerPartInSeconds / totalDuration * 100;

                    progressBar1.Value = Math.Min((int)progress, progressBar1.Maximum);
                    lbProgresso.Text = $"{Math.Min(progress, 100):F2}% Concluído";

                    try
                    {
                        await Task.Delay(100, cancellationTokenSource.Token);
                    }
                    catch (TaskCanceledException)
                    {
                        return;
                    }
                }

                MessageBox.Show("Processo de corte concluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro durante o processo de corte: {ex.Message}");
            }
            finally
            {
                btnCortar.Enabled = true;
                ResetForm();
            }
        }

        private void ResetForm()
        {
            txtLocalVideo.Text = string.Empty;
            txtDestinoVideo.Text = string.Empty;

            progressBar1.Value = progressBar1.Minimum;

            lbDuracao.Text = "Duração: ";
            lbProgresso.Text = "0% Concluído";

            btnCortar.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.youtube.com/@airkdigital";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o navegador: {ex.Message}");
            }
        }

        private void btnSelectVid_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de Vídeo|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    listVideosSelecionados.Items.Clear();

                    selectedFilePaths = openFileDialog.FileNames;  // Armazena os caminhos dos arquivos selecionados

                    foreach (string fileName in selectedFilePaths)
                    {
                        listVideosSelecionados.Items.Add(Path.GetFileName(fileName));
                    }

                    txtLocalVideos.Text = selectedFilePaths.Length == 1
                        ? selectedFilePaths[0]
                        : $"{selectedFilePaths.Length} vídeos selecionados";
                }
            }
        }


        private void btnSelectDestin_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtLocalDestino.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
        private void OnConvertClick(object sender, EventArgs e)
        {
            if (selectedFilePaths != null && selectedFilePaths.Length > 0)  // Verifica se algum arquivo foi selecionado
            {
                if (!string.IsNullOrEmpty(txtLocalDestino.Text))  // Verifica se uma pasta de destino foi selecionada
                {

                    for (int i = 0; i < selectedFilePaths.Length; i++)
                    {
                        string inputFilePath = selectedFilePaths[i];
                        string outputFilePath = Path.Combine(txtLocalDestino.Text, $"{Path.GetFileNameWithoutExtension(inputFilePath)}.mp4");

                        ConvertVideo(inputFilePath, outputFilePath, i + 1, selectedFilePaths.Length);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a pasta de destino primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um vídeo para converter.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void ConvertVideo(string inputFilePath, string outputFilePath, int currentFileIndex, int totalFiles)
        {
            try
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "ffmpeg",
                        Arguments = $"-i \"{inputFilePath}\" -c:a aac -c:v h264 \"{outputFilePath}\"",
                        RedirectStandardOutput = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                process.Start();

                lbConvertendo.Visible = true;
                

                process.WaitForExit();

                MessageBox.Show($"Conversão do arquivo {currentFileIndex}/{totalFiles} concluída!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetConverts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro na conversão: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ResetConverts()
        {
            // Limpar campos e redefinir valores padrão conforme necessário
            txtLocalVideos.Text = string.Empty;
            txtLocalDestino.Text = string.Empty;
            listVideosSelecionados.Items.Clear();
            comboFormatos.SelectedIndex = -1; // Defina o índice desejado ou um valor padrão

            // Ativar ou desativar botões conforme necessário
            btnSelectVid.Enabled = true;
            btnSelectDestin.Enabled = true;
            // Outras configurações ou ações de redefinição necessárias

            lbConvertendo.Visible = false;
            
        }

    }
}
