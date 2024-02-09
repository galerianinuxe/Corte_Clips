namespace NinuxeCortes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSelecionarVideo = new Button();
            txtLocalVideo = new TextBox();
            txtDestinoVideo = new TextBox();
            btnSelecionarDestino = new Button();
            label1 = new Label();
            lbDuracao = new Label();
            btnCortar = new Button();
            progressBar1 = new ProgressBar();
            lbProgresso = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lbConvertendo = new Label();
            label8 = new Label();
            comboFormatos = new ComboBox();
            btnSelectDestin = new Button();
            txtLocalDestino = new TextBox();
            label7 = new Label();
            btnConvert = new Button();
            listVideosSelecionados = new ListBox();
            btnSelectVid = new Button();
            txtLocalVideos = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelecionarVideo
            // 
            btnSelecionarVideo.FlatStyle = FlatStyle.Flat;
            btnSelecionarVideo.Location = new Point(223, 54);
            btnSelecionarVideo.Name = "btnSelecionarVideo";
            btnSelecionarVideo.Size = new Size(119, 23);
            btnSelecionarVideo.TabIndex = 0;
            btnSelecionarVideo.Text = "Selecionar Video";
            btnSelecionarVideo.UseVisualStyleBackColor = true;
            btnSelecionarVideo.Click += btnSelecionarVideo_Click;
            // 
            // txtLocalVideo
            // 
            txtLocalVideo.Location = new Point(9, 28);
            txtLocalVideo.Name = "txtLocalVideo";
            txtLocalVideo.ReadOnly = true;
            txtLocalVideo.Size = new Size(333, 23);
            txtLocalVideo.TabIndex = 1;
            // 
            // txtDestinoVideo
            // 
            txtDestinoVideo.Location = new Point(9, 95);
            txtDestinoVideo.Name = "txtDestinoVideo";
            txtDestinoVideo.ReadOnly = true;
            txtDestinoVideo.Size = new Size(333, 23);
            txtDestinoVideo.TabIndex = 3;
            // 
            // btnSelecionarDestino
            // 
            btnSelecionarDestino.FlatStyle = FlatStyle.Flat;
            btnSelecionarDestino.Location = new Point(223, 121);
            btnSelecionarDestino.Name = "btnSelecionarDestino";
            btnSelecionarDestino.Size = new Size(119, 23);
            btnSelecionarDestino.TabIndex = 2;
            btnSelecionarDestino.Text = "Selecionar Destino";
            btnSelecionarDestino.UseVisualStyleBackColor = true;
            btnSelecionarDestino.Click += btnSelecionarDestino_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Local";
            // 
            // lbDuracao
            // 
            lbDuracao.AutoSize = true;
            lbDuracao.Location = new Point(9, 54);
            lbDuracao.Name = "lbDuracao";
            lbDuracao.Size = new Size(103, 15);
            lbDuracao.TabIndex = 5;
            lbDuracao.Text = "Duração do vídeo:";
            // 
            // btnCortar
            // 
            btnCortar.FlatStyle = FlatStyle.Flat;
            btnCortar.ForeColor = Color.FromArgb(0, 80, 0);
            btnCortar.Location = new Point(178, 176);
            btnCortar.Name = "btnCortar";
            btnCortar.Size = new Size(164, 33);
            btnCortar.TabIndex = 7;
            btnCortar.Text = "Iniciar Cortes";
            btnCortar.UseVisualStyleBackColor = true;
            btnCortar.Click += btnCortar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(9, 151);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(333, 19);
            progressBar1.TabIndex = 8;
            // 
            // lbProgresso
            // 
            lbProgresso.AutoSize = true;
            lbProgresso.Location = new Point(9, 173);
            lbProgresso.Name = "lbProgresso";
            lbProgresso.Size = new Size(81, 15);
            lbProgresso.TabIndex = 9;
            lbProgresso.Text = "0% Concluído";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Destino";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.LOGOCORTES;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(216, 263);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 12;
            label3.Text = "Powered by Rick Costa";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DarkGreen;
            linkLabel1.Location = new Point(7, 263);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(165, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.youtube.com/airkdigital";
            linkLabel1.VisitedLinkColor = Color.FromArgb(0, 60, 60);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.WindowFrame;
            label4.Location = new Point(7, 248);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 15;
            label4.Text = "Inscreva-se";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(150, 0, 0);
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(140, 230);
            label5.Name = "label5";
            label5.Size = new Size(209, 26);
            label5.TabIndex = 16;
            label5.Text = "Apoie meu projeto com qualquer valor\r\nChave Pix E-mail: AIRK@MEU.PIX";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 80);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(359, 317);
            tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnSelecionarVideo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtLocalVideo);
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(btnSelecionarDestino);
            tabPage1.Controls.Add(txtDestinoVideo);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(lbDuracao);
            tabPage1.Controls.Add(lbProgresso);
            tabPage1.Controls.Add(btnCortar);
            tabPage1.Controls.Add(progressBar1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(351, 289);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cortador";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbConvertendo);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(comboFormatos);
            tabPage2.Controls.Add(btnSelectDestin);
            tabPage2.Controls.Add(txtLocalDestino);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(btnConvert);
            tabPage2.Controls.Add(listVideosSelecionados);
            tabPage2.Controls.Add(btnSelectVid);
            tabPage2.Controls.Add(txtLocalVideos);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(351, 289);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Conversor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbConvertendo
            // 
            lbConvertendo.AutoSize = true;
            lbConvertendo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbConvertendo.ForeColor = Color.DarkRed;
            lbConvertendo.Location = new Point(222, 265);
            lbConvertendo.Name = "lbConvertendo";
            lbConvertendo.Size = new Size(121, 21);
            lbConvertendo.TabIndex = 18;
            lbConvertendo.Text = "Convertendo...";
            lbConvertendo.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(10, 262);
            label8.Name = "label8";
            label8.Size = new Size(62, 26);
            label8.TabIndex = 16;
            label8.Text = "Tipo de\r\nConversão";
            // 
            // comboFormatos
            // 
            comboFormatos.FormattingEnabled = true;
            comboFormatos.Items.AddRange(new object[] { ".mp4", ".avi", ".mkv" });
            comboFormatos.Location = new Point(78, 265);
            comboFormatos.Name = "comboFormatos";
            comboFormatos.Size = new Size(70, 23);
            comboFormatos.TabIndex = 15;
            // 
            // btnSelectDestin
            // 
            btnSelectDestin.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnSelectDestin.FlatStyle = FlatStyle.Flat;
            btnSelectDestin.Location = new Point(10, 237);
            btnSelectDestin.Name = "btnSelectDestin";
            btnSelectDestin.Size = new Size(138, 23);
            btnSelectDestin.TabIndex = 10;
            btnSelectDestin.Text = "Selecionar Destino";
            btnSelectDestin.UseVisualStyleBackColor = true;
            // 
            // txtLocalDestino
            // 
            txtLocalDestino.Location = new Point(10, 212);
            txtLocalDestino.Name = "txtLocalDestino";
            txtLocalDestino.ReadOnly = true;
            txtLocalDestino.Size = new Size(333, 23);
            txtLocalDestino.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(10, 194);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 12;
            label7.Text = "Destino";
            // 
            // btnConvert
            // 
            btnConvert.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Location = new Point(240, 237);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(103, 23);
            btnConvert.TabIndex = 9;
            btnConvert.Text = "Iniciar";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // listVideosSelecionados
            // 
            listVideosSelecionados.FormattingEnabled = true;
            listVideosSelecionados.ItemHeight = 15;
            listVideosSelecionados.Location = new Point(10, 83);
            listVideosSelecionados.Name = "listVideosSelecionados";
            listVideosSelecionados.Size = new Size(333, 109);
            listVideosSelecionados.TabIndex = 8;
            // 
            // btnSelectVid
            // 
            btnSelectVid.FlatAppearance.CheckedBackColor = Color.Transparent;
            btnSelectVid.FlatStyle = FlatStyle.Flat;
            btnSelectVid.Location = new Point(10, 54);
            btnSelectVid.Name = "btnSelectVid";
            btnSelectVid.Size = new Size(138, 23);
            btnSelectVid.TabIndex = 5;
            btnSelectVid.Text = "Selecionar Video";
            btnSelectVid.UseVisualStyleBackColor = true;
            // 
            // txtLocalVideos
            // 
            txtLocalVideos.Location = new Point(10, 25);
            txtLocalVideos.Name = "txtLocalVideos";
            txtLocalVideos.ReadOnly = true;
            txtLocalVideos.Size = new Size(333, 23);
            txtLocalVideos.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(10, 7);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 7;
            label6.Text = "Local";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 397);
            Controls.Add(tabControl1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ninuxe Cortes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSelecionarVideo;
        private TextBox txtLocalVideo;
        private TextBox txtDestinoVideo;
        private Button btnSelecionarDestino;
        private Label label1;
        private Label lbDuracao;
        private Button btnCortar;
        private ProgressBar progressBar1;
        private Label lbProgresso;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private LinkLabel linkLabel1;
        private Label label4;
        private Label label5;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listVideosSelecionados;
        private Button btnSelectVid;
        private TextBox txtLocalVideos;
        private Label label6;
        private Button btnSelectDestin;
        private TextBox txtLocalDestino;
        private Label label7;
        private Button btnConvert;
        private Label label8;
        private ComboBox comboFormatos;
        private Label lbConvertendo;
    }
}