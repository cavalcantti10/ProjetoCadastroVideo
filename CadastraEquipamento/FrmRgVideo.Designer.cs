namespace CadastraEquipamento
{
    partial class FrmRgVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRgVideo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imgVd = new System.Windows.Forms.PictureBox();
            this.userContRTSP = new ControleRTSP.UserContRTSP();
            this.lblFrame = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgEquipamentos = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtgHistorico = new System.Windows.Forms.DataGridView();
            this.dtgCadastros = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.ckView = new System.Windows.Forms.CheckBox();
            this.timerF = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVd)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEquipamentos)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCadastros)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(18, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtSerial);
            this.groupBox2.Location = new System.Drawing.Point(458, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Detran";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.Location = new System.Drawing.Point(216, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(44, 42);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(18, 26);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(182, 20);
            this.txtSerial.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 118);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 250);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.imgVd);
            this.tabPage1.Controls.Add(this.userContRTSP);
            this.tabPage1.Controls.Add(this.lblFrame);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Imagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imgVd
            // 
            this.imgVd.Image = ((System.Drawing.Image)(resources.GetObject("imgVd.Image")));
            this.imgVd.Location = new System.Drawing.Point(14, 13);
            this.imgVd.Name = "imgVd";
            this.imgVd.Size = new System.Drawing.Size(394, 193);
            this.imgVd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVd.TabIndex = 1;
            this.imgVd.TabStop = false;
            // 
            // userContRTSP
            // 
            this.userContRTSP.BackColor = System.Drawing.Color.Silver;
            this.userContRTSP.Location = new System.Drawing.Point(6, 6);
            this.userContRTSP.Name = "userContRTSP";
            this.userContRTSP.Size = new System.Drawing.Size(414, 212);
            this.userContRTSP.TabIndex = 0;
            this.userContRTSP.Load += new System.EventHandler(this.userContRTSP1_Load);
            // 
            // lblFrame
            // 
            this.lblFrame.AutoSize = true;
            this.lblFrame.BackColor = System.Drawing.Color.Black;
            this.lblFrame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFrame.ForeColor = System.Drawing.Color.White;
            this.lblFrame.Location = new System.Drawing.Point(11, 203);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(39, 15);
            this.lblFrame.TabIndex = 18;
            this.lblFrame.Text = "0000";
            this.lblFrame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtLog);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(414, 212);
            this.txtLog.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(458, 112);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(474, 409);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgEquipamentos);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(466, 383);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cadastro";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dtgEquipamentos
            // 
            this.dtgEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEquipamentos.Location = new System.Drawing.Point(3, 0);
            this.dtgEquipamentos.Name = "dtgEquipamentos";
            this.dtgEquipamentos.Size = new System.Drawing.Size(462, 377);
            this.dtgEquipamentos.TabIndex = 0;
            this.dtgEquipamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEquipamentos_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtgHistorico);
            this.tabPage4.Controls.Add(this.dtgCadastros);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(466, 383);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Historico";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dtgHistorico
            // 
            this.dtgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorico.Location = new System.Drawing.Point(3, 282);
            this.dtgHistorico.Name = "dtgHistorico";
            this.dtgHistorico.Size = new System.Drawing.Size(465, 95);
            this.dtgHistorico.TabIndex = 1;
            // 
            // dtgCadastros
            // 
            this.dtgCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCadastros.Location = new System.Drawing.Point(0, 0);
            this.dtgCadastros.Name = "dtgCadastros";
            this.dtgCadastros.Size = new System.Drawing.Size(468, 276);
            this.dtgCadastros.TabIndex = 0;
            this.dtgCadastros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCadastros_CellClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(123, 374);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(89, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(240, 374);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(95, 23);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRegistro);
            this.groupBox3.Location = new System.Drawing.Point(12, 403);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 63);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observações";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(10, 19);
            this.txtRegistro.Multiline = true;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(406, 38);
            this.txtRegistro.TabIndex = 7;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(24, 472);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(412, 45);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Registrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // ckView
            // 
            this.ckView.AutoSize = true;
            this.ckView.Checked = true;
            this.ckView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckView.Location = new System.Drawing.Point(356, 378);
            this.ckView.Name = "ckView";
            this.ckView.Size = new System.Drawing.Size(49, 17);
            this.ckView.TabIndex = 1;
            this.ckView.Text = "View";
            this.ckView.UseVisualStyleBackColor = true;
            this.ckView.CheckedChanged += new System.EventHandler(this.ckView_CheckedChanged);
            // 
            // timerF
            // 
            this.timerF.Interval = 1000;
            this.timerF.Tick += new System.EventHandler(this.timerF_Tick_1);
            // 
            // FrmRgVideo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(962, 533);
            this.Controls.Add(this.ckView);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRgVideo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.FrmRgVideo_Activated);
            this.Deactivate += new System.EventHandler(this.FrmRgVideo_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRgVideo_FormClosing);
            this.Load += new System.EventHandler(this.FrmRgVideo_Load);
            this.Shown += new System.EventHandler(this.FrmRgVideo_Shown);
            this.Enter += new System.EventHandler(this.FrmRgVideo_Enter);
            this.Resize += new System.EventHandler(this.FrmRgVideo_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVd)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEquipamentos)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCadastros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnEnviar;
        private ControleRTSP.UserContRTSP userContRTSP;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridView dtgEquipamentos;
        private System.Windows.Forms.DataGridView dtgCadastros;
        private System.Windows.Forms.DataGridView dtgHistorico;
        private System.Windows.Forms.CheckBox ckView;
        private System.Windows.Forms.PictureBox imgVd;
        private System.Windows.Forms.Timer timerF;
        private System.Windows.Forms.Label lblFrame;
    }
}