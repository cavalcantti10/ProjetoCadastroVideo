namespace CadastraEquipamento
{
    partial class FrmCadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.bntProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.gpDado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DomAtivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.NomUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCK = new System.Windows.Forms.GroupBox();
            this.ckAdministrador = new System.Windows.Forms.CheckBox();
            this.ckBasico = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgDados = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.DomGrupo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.gpDado.SuspendLayout();
            this.gbCK.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnUltimo);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Controls.Add(this.btnSalva);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.bntProximo);
            this.groupBox3.Controls.Add(this.btnAnterior);
            this.groupBox3.Controls.Add(this.btnPrimeiro);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(886, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Transparent;
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimo.Location = new System.Drawing.Point(396, 11);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(109, 44);
            this.btnUltimo.TabIndex = 28;
            this.btnUltimo.Text = "&Ultimo";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(521, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(107, 44);
            this.btnNovo.TabIndex = 29;
            this.btnNovo.Text = "&Novo  ";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Transparent;
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalva.Enabled = false;
            this.btnSalva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.ForeColor = System.Drawing.Color.Black;
            this.btnSalva.Image = ((System.Drawing.Image)(resources.GetObject("btnSalva.Image")));
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(643, 11);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(107, 44);
            this.btnSalva.TabIndex = 23;
            this.btnSalva.Text = "&Salvar  ";
            this.btnSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Transparent;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(767, 11);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(104, 44);
            this.btnDel.TabIndex = 24;
            this.btnDel.Text = "&Excluir";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // bntProximo
            // 
            this.bntProximo.BackColor = System.Drawing.Color.Transparent;
            this.bntProximo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntProximo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bntProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntProximo.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntProximo.ForeColor = System.Drawing.Color.Black;
            this.bntProximo.Image = ((System.Drawing.Image)(resources.GetObject("bntProximo.Image")));
            this.bntProximo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntProximo.Location = new System.Drawing.Point(270, 12);
            this.bntProximo.Name = "bntProximo";
            this.bntProximo.Size = new System.Drawing.Size(111, 44);
            this.bntProximo.TabIndex = 27;
            this.bntProximo.Text = "&Proximo";
            this.bntProximo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntProximo.UseVisualStyleBackColor = false;
            this.bntProximo.Click += new System.EventHandler(this.bntProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoEllipsis = true;
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.Black;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnterior.Location = new System.Drawing.Point(147, 11);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(108, 44);
            this.btnAnterior.TabIndex = 26;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.AutoEllipsis = true;
            this.btnPrimeiro.BackColor = System.Drawing.Color.Transparent;
            this.btnPrimeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrimeiro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrimeiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.ForeColor = System.Drawing.Color.Black;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimeiro.Location = new System.Drawing.Point(14, 12);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(118, 44);
            this.btnPrimeiro.TabIndex = 25;
            this.btnPrimeiro.Text = " &Primeiro";
            this.btnPrimeiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // gpDado
            // 
            this.gpDado.BackColor = System.Drawing.Color.Transparent;
            this.gpDado.Controls.Add(this.label5);
            this.gpDado.Controls.Add(this.DomAtivo);
            this.gpDado.Controls.Add(this.label4);
            this.gpDado.Controls.Add(this.label3);
            this.gpDado.Controls.Add(this.TxtLogin);
            this.gpDado.Controls.Add(this.NomUsuario);
            this.gpDado.Controls.Add(this.label1);
            this.gpDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDado.Location = new System.Drawing.Point(10, 102);
            this.gpDado.Name = "gpDado";
            this.gpDado.Size = new System.Drawing.Size(510, 58);
            this.gpDado.TabIndex = 5;
            this.gpDado.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(422, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 108;
            this.label5.Text = "Ativo S/N:";
            // 
            // DomAtivo
            // 
            this.DomAtivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DomAtivo.Location = new System.Drawing.Point(425, 28);
            this.DomAtivo.MaxLength = 1;
            this.DomAtivo.Multiline = true;
            this.DomAtivo.Name = "DomAtivo";
            this.DomAtivo.Size = new System.Drawing.Size(66, 24);
            this.DomAtivo.TabIndex = 2;
            this.DomAtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DomAtivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DomAtivo_KeyPress);
            this.DomAtivo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DomAtivo_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 106;
            this.label4.Text = "Confirma Senha:";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(227, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Login:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Location = new System.Drawing.Point(230, 28);
            this.TxtLogin.MaxLength = 20;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(179, 22);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogin_KeyPress);
            this.TxtLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtLogin_KeyUp);
            // 
            // NomUsuario
            // 
            this.NomUsuario.Location = new System.Drawing.Point(9, 28);
            this.NomUsuario.MaxLength = 50;
            this.NomUsuario.Name = "NomUsuario";
            this.NomUsuario.Size = new System.Drawing.Size(207, 22);
            this.NomUsuario.TabIndex = 0;
            this.NomUsuario.Enter += new System.EventHandler(this.NomUsuario_Enter);
            this.NomUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NomUsuario_KeyPress);
            this.NomUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NomUsuario_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // gbCK
            // 
            this.gbCK.BackColor = System.Drawing.Color.Transparent;
            this.gbCK.Controls.Add(this.ckAdministrador);
            this.gbCK.Controls.Add(this.ckBasico);
            this.gbCK.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.gbCK.ForeColor = System.Drawing.Color.White;
            this.gbCK.Location = new System.Drawing.Point(526, 96);
            this.gbCK.Name = "gbCK";
            this.gbCK.Size = new System.Drawing.Size(168, 88);
            this.gbCK.TabIndex = 8;
            this.gbCK.TabStop = false;
            // 
            // ckAdministrador
            // 
            this.ckAdministrador.AutoSize = true;
            this.ckAdministrador.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckAdministrador.ForeColor = System.Drawing.Color.Black;
            this.ckAdministrador.Location = new System.Drawing.Point(15, 53);
            this.ckAdministrador.Name = "ckAdministrador";
            this.ckAdministrador.Size = new System.Drawing.Size(115, 20);
            this.ckAdministrador.TabIndex = 1;
            this.ckAdministrador.Text = "Administrador";
            this.ckAdministrador.UseVisualStyleBackColor = true;
            this.ckAdministrador.CheckedChanged += new System.EventHandler(this.ckAdministrador_CheckedChanged);
            // 
            // ckBasico
            // 
            this.ckBasico.AutoSize = true;
            this.ckBasico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBasico.ForeColor = System.Drawing.Color.Black;
            this.ckBasico.Location = new System.Drawing.Point(15, 13);
            this.ckBasico.Name = "ckBasico";
            this.ckBasico.Size = new System.Drawing.Size(68, 20);
            this.ckBasico.TabIndex = 0;
            this.ckBasico.Text = "Básico";
            this.ckBasico.UseVisualStyleBackColor = true;
            this.ckBasico.CheckedChanged += new System.EventHandler(this.ckBasico_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtgDados);
            this.groupBox2.Controls.Add(this.lblId);
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.DomGrupo);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(884, 242);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // dtgDados
            // 
            this.dtgDados.AllowUserToAddRows = false;
            this.dtgDados.AllowUserToDeleteRows = false;
            this.dtgDados.AllowUserToResizeColumns = false;
            this.dtgDados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtgDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDados.BackgroundColor = System.Drawing.Color.Gray;
            this.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDados.Location = new System.Drawing.Point(7, 17);
            this.dtgDados.Name = "dtgDados";
            this.dtgDados.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgDados.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgDados.Size = new System.Drawing.Size(872, 219);
            this.dtgDados.TabIndex = 30;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(651, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 16);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "000";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(146, -23);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(552, 28);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DomGrupo
            // 
            this.DomGrupo.AutoSize = true;
            this.DomGrupo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomGrupo.ForeColor = System.Drawing.Color.White;
            this.DomGrupo.Location = new System.Drawing.Point(405, 90);
            this.DomGrupo.Name = "DomGrupo";
            this.DomGrupo.Size = new System.Drawing.Size(64, 15);
            this.DomGrupo.TabIndex = 109;
            this.DomGrupo.Text = "Ativo S/N:";
            this.DomGrupo.TextChanged += new System.EventHandler(this.DomGrupo_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Cadastros";
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(914, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCK);
            this.Controls.Add(this.gpDado);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCadUsuario_FormClosing);
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            this.groupBox3.ResumeLayout(false);
            this.gpDado.ResumeLayout(false);
            this.gpDado.PerformLayout();
            this.gbCK.ResumeLayout(false);
            this.gbCK.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button bntProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.GroupBox gpDado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DomAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtLogin;
        public System.Windows.Forms.TextBox NomUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCK;
        private System.Windows.Forms.CheckBox ckAdministrador;
        private System.Windows.Forms.CheckBox ckBasico;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgDados;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label DomGrupo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
    }
}