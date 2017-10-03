namespace R3Booster
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.lblSobre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxProcessos = new System.Windows.Forms.ListBox();
            this.cbFinalizarProcesso = new System.Windows.Forms.CheckBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnSelecPasta = new System.Windows.Forms.Button();
            this.cbDesocultar = new System.Windows.Forms.CheckBox();
            this.txt_file = new System.Windows.Forms.Label();
            this.progressBarTemp = new System.Windows.Forms.ProgressBar();
            this.btnArquivos = new System.Windows.Forms.Button();
            this.cbTemp = new System.Windows.Forms.CheckBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nUDMinutos = new System.Windows.Forms.NumericUpDown();
            this.cbLimparRAM = new System.Windows.Forms.CheckBox();
            this.cbCompact = new System.Windows.Forms.CheckBox();
            this.cbVerifDisk = new System.Windows.Forms.CheckBox();
            this.btnExec2 = new System.Windows.Forms.Button();
            this.cbVerifArq = new System.Windows.Forms.CheckBox();
            this.txt_usada = new System.Windows.Forms.Label();
            this.btnLimparRAM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbPing = new System.Windows.Forms.CheckBox();
            this.btnExec3 = new System.Windows.Forms.Button();
            this.cbIpMac = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerPegarRAM = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.timerLimparRAM = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(158, -5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 574);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage0
            // 
            this.tabPage0.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage0.Controls.Add(this.lblSobre);
            this.tabPage0.Controls.Add(this.label5);
            this.tabPage0.Controls.Add(this.pictureBox4);
            this.tabPage0.Controls.Add(this.label4);
            this.tabPage0.Location = new System.Drawing.Point(4, 5);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Size = new System.Drawing.Size(729, 565);
            this.tabPage0.TabIndex = 3;
            this.tabPage0.Text = "tabPage4";
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.ForeColor = System.Drawing.Color.White;
            this.lblSobre.Location = new System.Drawing.Point(416, 523);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(293, 20);
            this.lblSobre.TabIndex = 4;
            this.lblSobre.Text = "Informações sobre seu computador";
            this.lblSobre.Click += new System.EventHandler(this.lblSobre_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(665, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Escolha um grupo de ferramentas ao lado para começar";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(139, 203);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(429, 149);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(239, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "BEM-VINDO AO";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Controls.Add(this.listBoxProcessos);
            this.tabPage1.Controls.Add(this.cbFinalizarProcesso);
            this.tabPage1.Controls.Add(this.txtCaminho);
            this.tabPage1.Controls.Add(this.btnSelecPasta);
            this.tabPage1.Controls.Add(this.cbDesocultar);
            this.tabPage1.Controls.Add(this.txt_file);
            this.tabPage1.Controls.Add(this.progressBarTemp);
            this.tabPage1.Controls.Add(this.btnArquivos);
            this.tabPage1.Controls.Add(this.cbTemp);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(729, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // listBoxProcessos
            // 
            this.listBoxProcessos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProcessos.FormattingEnabled = true;
            this.listBoxProcessos.ItemHeight = 20;
            this.listBoxProcessos.Location = new System.Drawing.Point(129, 350);
            this.listBoxProcessos.Name = "listBoxProcessos";
            this.listBoxProcessos.Size = new System.Drawing.Size(177, 124);
            this.listBoxProcessos.TabIndex = 11;
            this.listBoxProcessos.Visible = false;
            // 
            // cbFinalizarProcesso
            // 
            this.cbFinalizarProcesso.AutoSize = true;
            this.cbFinalizarProcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFinalizarProcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinalizarProcesso.ForeColor = System.Drawing.Color.White;
            this.cbFinalizarProcesso.Location = new System.Drawing.Point(129, 315);
            this.cbFinalizarProcesso.Name = "cbFinalizarProcesso";
            this.cbFinalizarProcesso.Size = new System.Drawing.Size(207, 29);
            this.cbFinalizarProcesso.TabIndex = 10;
            this.cbFinalizarProcesso.Text = "Finalizar processo";
            this.cbFinalizarProcesso.UseVisualStyleBackColor = true;
            this.cbFinalizarProcesso.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(129, 266);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.ReadOnly = true;
            this.txtCaminho.Size = new System.Drawing.Size(468, 26);
            this.txtCaminho.TabIndex = 9;
            this.txtCaminho.Visible = false;
            // 
            // btnSelecPasta
            // 
            this.btnSelecPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecPasta.Location = new System.Drawing.Point(470, 208);
            this.btnSelecPasta.Name = "btnSelecPasta";
            this.btnSelecPasta.Size = new System.Drawing.Size(127, 37);
            this.btnSelecPasta.TabIndex = 8;
            this.btnSelecPasta.Text = "Selecionar Pasta";
            this.btnSelecPasta.UseVisualStyleBackColor = true;
            this.btnSelecPasta.Visible = false;
            this.btnSelecPasta.Click += new System.EventHandler(this.btnSelecPasta_Click);
            // 
            // cbDesocultar
            // 
            this.cbDesocultar.AutoSize = true;
            this.cbDesocultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDesocultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDesocultar.ForeColor = System.Drawing.Color.White;
            this.cbDesocultar.Location = new System.Drawing.Point(129, 208);
            this.cbDesocultar.Name = "cbDesocultar";
            this.cbDesocultar.Size = new System.Drawing.Size(240, 29);
            this.cbDesocultar.TabIndex = 7;
            this.cbDesocultar.Text = "Desocultar uma pasta";
            this.cbDesocultar.UseVisualStyleBackColor = true;
            this.cbDesocultar.CheckedChanged += new System.EventHandler(this.cbDesocultar_CheckedChanged);
            // 
            // txt_file
            // 
            this.txt_file.AutoSize = true;
            this.txt_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.ForeColor = System.Drawing.Color.White;
            this.txt_file.Location = new System.Drawing.Point(124, 156);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(0, 25);
            this.txt_file.TabIndex = 6;
            // 
            // progressBarTemp
            // 
            this.progressBarTemp.Location = new System.Drawing.Point(473, 119);
            this.progressBarTemp.Name = "progressBarTemp";
            this.progressBarTemp.Size = new System.Drawing.Size(202, 23);
            this.progressBarTemp.TabIndex = 5;
            this.progressBarTemp.Visible = false;
            // 
            // btnArquivos
            // 
            this.btnArquivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArquivos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnArquivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivos.Location = new System.Drawing.Point(320, 492);
            this.btnArquivos.Name = "btnArquivos";
            this.btnArquivos.Size = new System.Drawing.Size(141, 44);
            this.btnArquivos.TabIndex = 4;
            this.btnArquivos.Text = "Executar ações";
            this.btnArquivos.UseVisualStyleBackColor = true;
            this.btnArquivos.Click += new System.EventHandler(this.btnArquivos_Click);
            // 
            // cbTemp
            // 
            this.cbTemp.AutoSize = true;
            this.cbTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTemp.ForeColor = System.Drawing.Color.White;
            this.cbTemp.Location = new System.Drawing.Point(129, 115);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(349, 29);
            this.cbTemp.TabIndex = 3;
            this.cbTemp.Text = "Limpar a pasta temp do Windows";
            this.cbTemp.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(640, 479);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 70);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ferramentas de Arquivos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage2.Controls.Add(this.nUDMinutos);
            this.tabPage2.Controls.Add(this.cbLimparRAM);
            this.tabPage2.Controls.Add(this.cbCompact);
            this.tabPage2.Controls.Add(this.cbVerifDisk);
            this.tabPage2.Controls.Add(this.btnExec2);
            this.tabPage2.Controls.Add(this.cbVerifArq);
            this.tabPage2.Controls.Add(this.txt_usada);
            this.tabPage2.Controls.Add(this.btnLimparRAM);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(729, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // nUDMinutos
            // 
            this.nUDMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDMinutos.Location = new System.Drawing.Point(483, 231);
            this.nUDMinutos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUDMinutos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDMinutos.Name = "nUDMinutos";
            this.nUDMinutos.Size = new System.Drawing.Size(60, 26);
            this.nUDMinutos.TabIndex = 15;
            this.nUDMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDMinutos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUDMinutos.ValueChanged += new System.EventHandler(this.nUDMinutos_ValueChanged);
            // 
            // cbLimparRAM
            // 
            this.cbLimparRAM.AutoSize = true;
            this.cbLimparRAM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLimparRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLimparRAM.ForeColor = System.Drawing.Color.White;
            this.cbLimparRAM.Location = new System.Drawing.Point(264, 228);
            this.cbLimparRAM.Name = "cbLimparRAM";
            this.cbLimparRAM.Size = new System.Drawing.Size(373, 29);
            this.cbLimparRAM.TabIndex = 12;
            this.cbLimparRAM.Text = "Limpar RAM a cada             minutos";
            this.cbLimparRAM.UseVisualStyleBackColor = true;
            this.cbLimparRAM.CheckedChanged += new System.EventHandler(this.cbLimparRAM_CheckedChanged);
            // 
            // cbCompact
            // 
            this.cbCompact.AutoSize = true;
            this.cbCompact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCompact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompact.ForeColor = System.Drawing.Color.White;
            this.cbCompact.Location = new System.Drawing.Point(135, 381);
            this.cbCompact.Name = "cbCompact";
            this.cbCompact.Size = new System.Drawing.Size(194, 29);
            this.cbCompact.TabIndex = 11;
            this.cbCompact.Text = "Compactar pasta";
            this.cbCompact.UseVisualStyleBackColor = true;
            this.cbCompact.CheckedChanged += new System.EventHandler(this.cbCompact_CheckedChanged);
            // 
            // cbVerifDisk
            // 
            this.cbVerifDisk.AutoSize = true;
            this.cbVerifDisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVerifDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerifDisk.ForeColor = System.Drawing.Color.White;
            this.cbVerifDisk.Location = new System.Drawing.Point(135, 329);
            this.cbVerifDisk.Name = "cbVerifDisk";
            this.cbVerifDisk.Size = new System.Drawing.Size(330, 29);
            this.cbVerifDisk.TabIndex = 10;
            this.cbVerifDisk.Text = "Fazer uma verificação de disco";
            this.cbVerifDisk.UseVisualStyleBackColor = true;
            this.cbVerifDisk.CheckedChanged += new System.EventHandler(this.cbVerifDisk_CheckedChanged);
            // 
            // btnExec2
            // 
            this.btnExec2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExec2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec2.Location = new System.Drawing.Point(320, 492);
            this.btnExec2.Name = "btnExec2";
            this.btnExec2.Size = new System.Drawing.Size(141, 44);
            this.btnExec2.TabIndex = 9;
            this.btnExec2.Text = "Executar ações";
            this.btnExec2.UseVisualStyleBackColor = true;
            this.btnExec2.Click += new System.EventHandler(this.btnExec2_Click);
            // 
            // cbVerifArq
            // 
            this.cbVerifArq.AutoSize = true;
            this.cbVerifArq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbVerifArq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVerifArq.ForeColor = System.Drawing.Color.White;
            this.cbVerifArq.Location = new System.Drawing.Point(135, 276);
            this.cbVerifArq.Name = "cbVerifArq";
            this.cbVerifArq.Size = new System.Drawing.Size(448, 29);
            this.cbVerifArq.TabIndex = 8;
            this.cbVerifArq.Text = "Fazer uma verificação de arquivos do disco";
            this.cbVerifArq.UseVisualStyleBackColor = true;
            // 
            // txt_usada
            // 
            this.txt_usada.AutoSize = true;
            this.txt_usada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usada.ForeColor = System.Drawing.Color.White;
            this.txt_usada.Location = new System.Drawing.Point(597, 193);
            this.txt_usada.Name = "txt_usada";
            this.txt_usada.Size = new System.Drawing.Size(78, 15);
            this.txt_usada.TabIndex = 6;
            this.txt_usada.Text = "usada/total";
            // 
            // btnLimparRAM
            // 
            this.btnLimparRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparRAM.Location = new System.Drawing.Point(132, 222);
            this.btnLimparRAM.Name = "btnLimparRAM";
            this.btnLimparRAM.Size = new System.Drawing.Size(89, 35);
            this.btnLimparRAM.TabIndex = 5;
            this.btnLimparRAM.Text = "Limpar";
            this.btnLimparRAM.UseVisualStyleBackColor = true;
            this.btnLimparRAM.Click += new System.EventHandler(this.btnLimparRAM_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(132, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "RAM USAGE";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(132, 161);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(458, 46);
            this.progressBar1.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(640, 479);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 70);
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ferramentas de Disco Rígido e RAM";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Controls.Add(this.txtAddress);
            this.tabPage3.Controls.Add(this.cbPing);
            this.tabPage3.Controls.Add(this.btnExec3);
            this.tabPage3.Controls.Add(this.cbIpMac);
            this.tabPage3.Controls.Add(this.pictureBox7);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(729, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(117, 311);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(468, 26);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.Visible = false;
            // 
            // cbPing
            // 
            this.cbPing.AutoSize = true;
            this.cbPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPing.ForeColor = System.Drawing.Color.White;
            this.cbPing.Location = new System.Drawing.Point(117, 256);
            this.cbPing.Name = "cbPing";
            this.cbPing.Size = new System.Drawing.Size(393, 29);
            this.cbPing.TabIndex = 14;
            this.cbPing.Text = "Verificar a conexão com um endereço";
            this.cbPing.UseVisualStyleBackColor = true;
            this.cbPing.CheckedChanged += new System.EventHandler(this.cbPing_CheckedChanged);
            // 
            // btnExec3
            // 
            this.btnExec3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExec3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExec3.Location = new System.Drawing.Point(320, 492);
            this.btnExec3.Name = "btnExec3";
            this.btnExec3.Size = new System.Drawing.Size(141, 44);
            this.btnExec3.TabIndex = 13;
            this.btnExec3.Text = "Executar ações";
            this.btnExec3.UseVisualStyleBackColor = true;
            this.btnExec3.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cbIpMac
            // 
            this.cbIpMac.AutoSize = true;
            this.cbIpMac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbIpMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIpMac.ForeColor = System.Drawing.Color.White;
            this.cbIpMac.Location = new System.Drawing.Point(117, 154);
            this.cbIpMac.Name = "cbIpMac";
            this.cbIpMac.Size = new System.Drawing.Size(206, 29);
            this.cbIpMac.TabIndex = 12;
            this.cbIpMac.Text = "Verificar IP e MAC";
            this.cbIpMac.UseVisualStyleBackColor = true;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(640, 479);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(194, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(401, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ferramentas de Conexão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 188);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 188);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 188);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 381);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(173, 188);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timerPegarRAM
            // 
            this.timerPegarRAM.Tick += new System.EventHandler(this.timerPegarRAM_Tick);
            // 
            // timerLimparRAM
            // 
            this.timerLimparRAM.Interval = 5000;
            this.timerLimparRAM.Tick += new System.EventHandler(this.timerLimparRAM_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "O programa está sendo executado em segundo plano";
            this.notifyIcon1.BalloonTipTitle = "R3Booster";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "R3Booster";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R3Booster v1.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label6;

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnArquivos;
        private System.Windows.Forms.CheckBox cbTemp;
        private System.Windows.Forms.ProgressBar progressBarTemp;
        private System.Windows.Forms.Label txt_file;
        private System.Windows.Forms.Button btnSelecPasta;
        private System.Windows.Forms.CheckBox cbDesocultar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.ListBox listBoxProcessos;
        private System.Windows.Forms.CheckBox cbFinalizarProcesso;
        private System.Windows.Forms.Button btnLimparRAM;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerPegarRAM;
        private System.Windows.Forms.Label txt_usada;
        private System.Windows.Forms.Button btnExec2;
        private System.Windows.Forms.CheckBox cbVerifArq;
        private System.Windows.Forms.CheckBox cbVerifDisk;
        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.CheckBox cbCompact;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckBox cbPing;
        private System.Windows.Forms.Button btnExec3;
        private System.Windows.Forms.CheckBox cbIpMac;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox cbLimparRAM;
        private System.Windows.Forms.Timer timerLimparRAM;
        private System.Windows.Forms.NumericUpDown nUDMinutos;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

