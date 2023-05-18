namespace CadastraEquipamento
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.dtgCadastros = new System.Windows.Forms.DataGridView();
            this.txtSerialDetran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtNSerie = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtTipificacao = new System.Windows.Forms.TextBox();
            this.txtSinalizacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpxdados = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.cbxFaixa = new System.Windows.Forms.ComboBox();
            this.cbxSentido = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.bntProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCadastros)).BeginInit();
            this.gpxdados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCadastros
            // 
            this.dtgCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCadastros.Location = new System.Drawing.Point(10, 317);
            this.dtgCadastros.Name = "dtgCadastros";
            this.dtgCadastros.Size = new System.Drawing.Size(907, 182);
            this.dtgCadastros.TabIndex = 0;
            // 
            // txtSerialDetran
            // 
            this.txtSerialDetran.Location = new System.Drawing.Point(6, 37);
            this.txtSerialDetran.Name = "txtSerialDetran";
            this.txtSerialDetran.Size = new System.Drawing.Size(125, 20);
            this.txtSerialDetran.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Detran";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(137, 37);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(115, 20);
            this.txtMunicipio.TabIndex = 2;
            // 
            // txtNSerie
            // 
            this.txtNSerie.Location = new System.Drawing.Point(377, 37);
            this.txtNSerie.Name = "txtNSerie";
            this.txtNSerie.Size = new System.Drawing.Size(134, 20);
            this.txtNSerie.TabIndex = 4;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(6, 79);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(638, 20);
            this.txtEndereco.TabIndex = 6;
            // 
            // txtTipificacao
            // 
            this.txtTipificacao.Location = new System.Drawing.Point(379, 128);
            this.txtTipificacao.Name = "txtTipificacao";
            this.txtTipificacao.Size = new System.Drawing.Size(132, 20);
            this.txtTipificacao.TabIndex = 10;
            this.txtTipificacao.TextChanged += new System.EventHandler(this.txtTipificacao_TextChanged);
            // 
            // txtSinalizacao
            // 
            this.txtSinalizacao.Location = new System.Drawing.Point(517, 128);
            this.txtSinalizacao.Name = "txtSinalizacao";
            this.txtSinalizacao.Size = new System.Drawing.Size(127, 20);
            this.txtSinalizacao.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Município";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nº de Série";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endereço de Cadastro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sentido ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Faixa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tipificação";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(493, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sinalização";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(295, 287);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(144, 24);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(502, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 24);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpxdados
            // 
            this.gpxdados.Controls.Add(this.pictureBox1);
            this.gpxdados.Controls.Add(this.label11);
            this.gpxdados.Controls.Add(this.label10);
            this.gpxdados.Controls.Add(this.txtLongitude);
            this.gpxdados.Controls.Add(this.txtLatitude);
            this.gpxdados.Controls.Add(this.cbxFaixa);
            this.gpxdados.Controls.Add(this.cbxSentido);
            this.gpxdados.Controls.Add(this.cbxTipo);
            this.gpxdados.Controls.Add(this.txtSerialDetran);
            this.gpxdados.Controls.Add(this.label1);
            this.gpxdados.Controls.Add(this.txtMunicipio);
            this.gpxdados.Controls.Add(this.label2);
            this.gpxdados.Controls.Add(this.label9);
            this.gpxdados.Controls.Add(this.txtSinalizacao);
            this.gpxdados.Controls.Add(this.label8);
            this.gpxdados.Controls.Add(this.label3);
            this.gpxdados.Controls.Add(this.label7);
            this.gpxdados.Controls.Add(this.txtTipificacao);
            this.gpxdados.Controls.Add(this.txtNSerie);
            this.gpxdados.Controls.Add(this.label6);
            this.gpxdados.Controls.Add(this.label4);
            this.gpxdados.Controls.Add(this.label5);
            this.gpxdados.Controls.Add(this.txtEndereco);
            this.gpxdados.Location = new System.Drawing.Point(16, 97);
            this.gpxdados.Name = "gpxdados";
            this.gpxdados.Size = new System.Drawing.Size(895, 184);
            this.gpxdados.TabIndex = 22;
            this.gpxdados.TabStop = false;
            this.gpxdados.Text = "Dados Equipamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(136, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Longitude";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Latitude";
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(139, 129);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(113, 20);
            this.txtLongitude.TabIndex = 8;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(6, 129);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(126, 20);
            this.txtLatitude.TabIndex = 7;
            // 
            // cbxFaixa
            // 
            this.cbxFaixa.FormattingEnabled = true;
            this.cbxFaixa.IntegralHeight = false;
            this.cbxFaixa.ItemHeight = 13;
            this.cbxFaixa.Items.AddRange(new object[] {
            "Fx01",
            "Fx01 C-B",
            "Fx01 =Esq.",
            "Fx01 =Dir.",
            "Fx02",
            "Fx02 C-B",
            "Fx02 =Esq.",
            "Fx02 =Dir.",
            "Fx03",
            "Fx03 C-B",
            "Fx03 =Esq.",
            "Fx03 =Dir.",
            "Fx04",
            "Fx04 C-B",
            "Fx04 =Esq.",
            "Fx04 =Dir."});
            this.cbxFaixa.Location = new System.Drawing.Point(517, 37);
            this.cbxFaixa.Name = "cbxFaixa";
            this.cbxFaixa.Size = new System.Drawing.Size(127, 21);
            this.cbxFaixa.TabIndex = 5;
            this.cbxFaixa.SelectedIndexChanged += new System.EventHandler(this.cbxFaixa_SelectedIndexChanged);
            // 
            // cbxSentido
            // 
            this.cbxSentido.FormattingEnabled = true;
            this.cbxSentido.ItemHeight = 13;
            this.cbxSentido.Items.AddRange(new object[] {
            "Descrescente\t",
            "Crescente ",
            "Sul-Norte",
            "Norte-Sul",
            "Leste-Oeste\t",
            "Centro-Bairro",
            "Bairro-Centro",
            "Unico ",
            "Ambos Sentidos"});
            this.cbxSentido.Location = new System.Drawing.Point(258, 128);
            this.cbxSentido.Name = "cbxSentido";
            this.cbxSentido.Size = new System.Drawing.Size(115, 21);
            this.cbxSentido.TabIndex = 9;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Controlador ",
            "Restriçao Veiculo\t",
            "Redutor"});
            this.cbxTipo.Location = new System.Drawing.Point(258, 36);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(113, 21);
            this.cbxTipo.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnUltimo);
            this.groupBox2.Controls.Add(this.btnPrimeiro);
            this.groupBox2.Controls.Add(this.bntProximo);
            this.groupBox2.Controls.Add(this.btnAnterior);
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 61);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
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
            this.btnDel.Location = new System.Drawing.Point(474, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(115, 39);
            this.btnDel.TabIndex = 33;
            this.btnDel.Text = "&Excluir";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnNovo.Location = new System.Drawing.Point(319, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(110, 39);
            this.btnNovo.TabIndex = 32;
            this.btnNovo.Text = "&Novo  ";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.Transparent;
            this.btnUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUltimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Calibri", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUltimo.Location = new System.Drawing.Point(791, 16);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(110, 39);
            this.btnUltimo.TabIndex = 31;
            this.btnUltimo.Text = "&Ultimo";
            this.btnUltimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.AutoEllipsis = true;
            this.btnPrimeiro.BackColor = System.Drawing.Color.Transparent;
            this.btnPrimeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrimeiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.ForeColor = System.Drawing.Color.Black;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrimeiro.Location = new System.Drawing.Point(6, 16);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(117, 39);
            this.btnPrimeiro.TabIndex = 30;
            this.btnPrimeiro.Text = " &Primeiro";
            this.btnPrimeiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimeiro.UseVisualStyleBackColor = false;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
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
            this.bntProximo.Location = new System.Drawing.Point(632, 16);
            this.bntProximo.Name = "bntProximo";
            this.bntProximo.Size = new System.Drawing.Size(119, 39);
            this.bntProximo.TabIndex = 28;
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
            this.btnAnterior.Location = new System.Drawing.Point(162, 16);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(119, 39);
            this.btnAnterior.TabIndex = 27;
            this.btnAnterior.Text = "&Anterior";
            this.btnAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 506);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpxdados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.dtgCadastros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Equipamento";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCadastros)).EndInit();
            this.gpxdados.ResumeLayout(false);
            this.gpxdados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCadastros;
        private System.Windows.Forms.TextBox txtSerialDetran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtNSerie;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtTipificacao;
        private System.Windows.Forms.TextBox txtSinalizacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpxdados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxSentido;
        private System.Windows.Forms.ComboBox cbxFaixa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

