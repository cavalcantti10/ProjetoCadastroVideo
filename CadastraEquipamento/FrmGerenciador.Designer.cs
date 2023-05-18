namespace Menu
{
    partial class FrmGerenciador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciador));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnImagem = new System.Windows.Forms.Button();
            this.btnEquipamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelPrincipal.Controls.Add(this.btnSair);
            this.panelPrincipal.Controls.Add(this.btnRelatorio);
            this.panelPrincipal.Controls.Add(this.btnUsuario);
            this.panelPrincipal.Controls.Add(this.btnImagem);
            this.panelPrincipal.Controls.Add(this.btnEquipamento);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 1);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(222, 520);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(3, 438);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(216, 72);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Fechar ";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnRelatorio.Image")));
            this.btnRelatorio.Location = new System.Drawing.Point(3, 361);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(216, 71);
            this.btnRelatorio.TabIndex = 4;
            this.btnRelatorio.Text = "Relatório Equipamento";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(3, 130);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(216, 71);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "Cadastro Usuario";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnImagem
            // 
            this.btnImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnImagem.Image")));
            this.btnImagem.Location = new System.Drawing.Point(3, 284);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(216, 71);
            this.btnImagem.TabIndex = 3;
            this.btnImagem.Text = "Registro de Imagem ";
            this.btnImagem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImagem.UseVisualStyleBackColor = true;
            this.btnImagem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEquipamento.Image")));
            this.btnEquipamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipamento.Location = new System.Drawing.Point(3, 207);
            this.btnEquipamento.Name = "btnEquipamento";
            this.btnEquipamento.Size = new System.Drawing.Size(216, 71);
            this.btnEquipamento.TabIndex = 2;
            this.btnEquipamento.Text = "Cadastro Equipamento";
            this.btnEquipamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEquipamento.UseVisualStyleBackColor = true;
            this.btnEquipamento.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelForms
            // 
            this.panelForms.Location = new System.Drawing.Point(225, 1);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(937, 520);
            this.panelForms.TabIndex = 1;
            // 
            // FrmGerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 523);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Tarefas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEquipamento;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnRelatorio;
    }
}

