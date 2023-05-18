using CadastraEquipamento;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Menu
{
    public partial class FrmGerenciador : Form
    {
        string sNivel = "";

        private Form frmAtivo;


        public FrmGerenciador(string nivel)
        {
            InitializeComponent();
            sNivel = nivel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sNivel == "2")
            {
                btnUsuario.Enabled = false;
            }
        }
        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForms.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();

        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control crtl in panelPrincipal.Controls)
                crtl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.DarkBlue;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ActiveButton(btnEquipamento);
            FormShow(new FrmCadastro());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(btnImagem);  
            FormShow(new FrmRgVideo());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ActiveButton(btnUsuario);
            FormShow(new FrmCadUsuario());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            CloseApplication();
            this.Close();
        }
       
        private void CloseApplication()
        {
            // Fecha todos os formulários abertos
            ActiveFormClose();

            // Encerra a aplicação
            Application.Exit();
        }
    }
}
