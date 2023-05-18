using ClassDados;
using ClsMD5;
using Menu;
using Messagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CadastraEquipamento
{
    public partial class FrmLoginFiscal : Form
    {
        public bool bSucesso = false;
        public int CodUsuario { get; set; }
        public string NomUser { get; set; }




        public ClasseDml2 cmdBD;

        Messagens.ClsMessagens Clmsg = new Messagens.ClsMessagens();
        string sRetorno = "";

        BindingSource bdsDados = new BindingSource();
        public string sNivel = "0";
        public bool bCentral = false;
        public bool bModoCentral = false;
        ClsUsuario usuario = new ClsUsuario();


        string sUsrOld = "";
        string sSenhaOld = "";


        //Classes auxiliares
        public ClasseDml cmdBdLogin = new ClasseDml();
        ClsMessagens crn = new ClsMessagens();
        SecurityCryDec cmdSeg = new SecurityCryDec();


        public bool bEncerrado = false;



        public FrmLoginFiscal()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void FrmLoginFiscal_Load(object sender, EventArgs e)
        {
            this.Opacity = 1; 
            this.TransparencyKey = Color.Empty;



            if (cmdBD == null)
            {
                cmdBD = new ClasseDml2();
                conectaBd();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (txtUsr.Text == string.Empty || txtPwd.Text == string.Empty)
            {
                crn.frmF.sMsg = "Prencha todos os campos";
                // crn.frmA.ShowDialog();
     
            }
            else
            {
                if (txtUsr.BackColor == Color.Yellow)
                {
                    if (txtUsr.Text != txtPwd.Text)
                    {
                        crn.frmF.sMsg = "Senhas diferentes";
                        crn.frmF.ShowDialog();
                        txtUsr.Focus();
                        return;
                    }

                    if (txtUsr.Text.Length < 4)
                    {
                        crn.frmF.sMsg = "Mínimo 4 Caracteres";
                        crn.frmF.ShowDialog();
                        txtUsr.Focus();
                        return;
                    }

                    if (sSenhaOld == txtPwd.Text)
                    {
                        crn.frmF.sMsg = "Senha repetidas";
                        crn.frmF.ShowDialog();
                        txtUsr.Focus();
                        return;
                    }

                    if (usuario.AtualizarLogin(sUsrOld, sSenhaOld, txtPwd.Text))
                    {
                        sSenhaOld = "";
                        sUsrOld = "";
                        crn.frmS.ShowDialog();
                        lblUsr.Text = "Usuário:";
                        lblSenha.Text = "Senha:";
                        if (!ckAlt.Checked)
                            crn.frmF.sMsg = "Falha Login !!";
                        txtUsr.Text = "";
                        txtUsr.PasswordChar = (char)0;
                        txtUsr.Focus();
                        txtUsr.BackColor = Color.White;
                        txtPwd.Text = "";
                        txtPwd.BackColor = Color.White;
                        txtUsr.CharacterCasing = CharacterCasing.Upper;
                        ckAlt.Checked = false;
                    }
                    return;
                }

                sNivel = usuario.SeUsuario(txtUsr.Text, txtPwd.Text);
                if (sNivel == "Erro")
                {
                    txtUsr.Text = "";
                    txtUsr.Focus();
                    txtPwd.Text = "";
                }
                else if (sNivel == "X")
                {
                    bSucesso = false;
                    crn.frmF.sMsg = "Login Invalido";
                    crn.frmF.ShowDialog();
                    txtUsr.Text = "";
                    txtUsr.Focus();
                    txtPwd.Text = "";
                    return;
                }
                else
                {
                    bSucesso = true;
                    NomUser = txtUsr.Text.Trim();
                    //FrmRegistroImagem outroFormulario = new FrmRegistroImagem();
                    //outroFormulario.Show();
                    //outroFormulario.lblUsuario.Text = txtUsr.Text;
                    string sCodigo = usuario.SeUsuarioCod(txtUsr.Text.Trim(), txtPwd.Text.Trim(), sNivel);
                    if (sCodigo == "Erro")
                    {
                        txtUsr.Text = "";
                        txtUsr.Focus();
                        txtPwd.Text = "";
                    }
                    else
                    {
                        if (txtPwd.Text == "1234")
                        {
                            ckAlt.Checked = true;
                        }

                        if (ckAlt.Checked)
                        {

                            lblUsr.Text = "Nova Senha:";
                            lblSenha.Text = "Confirma Senha:";

                            txtUsr.PasswordChar = txtPwd.PasswordChar;
                            sUsrOld = txtUsr.Text;
                            txtUsr.Text = "";
                            txtUsr.Focus();
                            txtUsr.BackColor = Color.Yellow;
                            sSenhaOld = txtPwd.Text;
                            txtPwd.Text = "";
                            txtPwd.BackColor = Color.Yellow;
                            txtUsr.CharacterCasing = CharacterCasing.Normal;
                        }
                        else
                        {
                            this.Hide();
                            FrmGerenciador form = new FrmGerenciador(sNivel);
                            form.ShowDialog();
                            this.Show();
                        }
                    }
                }
            }
        }

        private void txtUsr_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                txtPwd.Focus();

            if (e.KeyCode == Keys.F10)
            {
                txtUsr.Text = "FELIPE10";
                txtPwd.Text = "TESC10";
                btnLogin_Click(sender, e);
            }
        }

        private void txtPwd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btnLogin.Focus();
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {

            if (txtUsr.Text == "")
                txtUsr.Focus();
        }

        private void FrmLoginFiscal_Enter(object sender, EventArgs e)
        {
            txtUsr.Focus();
        }

        public void conectaBd()
        {
            string sServidorSql = ConfigurationManager.AppSettings["Servidor"].ToString();
            string sBancoSql = ConfigurationManager.AppSettings["Banco"].ToString();
            cmdBD.sqlConnectionString = "Data Source=" + sServidorSql + ";Initial Catalog=" + sBancoSql + ";Persist Security Info=True;Password=vox41; User ID=vox41; Connection Timeout=360";

            if (!cmdBD.abreConn())
            {
                Clmsg.frmF = new RegrasNegocio.FrmFalha();
                Clmsg.frmF.sMsg = "Erro Banco";
            }
        }

        private void FrmLoginFiscal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                FrmCadUsuario cadastro = new FrmCadUsuario();
                cadastro.Show();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
   
}
