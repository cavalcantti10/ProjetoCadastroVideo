using ClassDados;
using ClassGenerica;
using ClsMD5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastraEquipamento
{
    public partial class FrmCadUsuario : Form
    {
        string sNivel = "";
        public bool bAdmin = false;
        public string sTitulo = "";
        bool check = false; // tentar verificar se o checkbox esta selecionado

        string sPes = "NomCliente";
        SecurityCryDec seg = new SecurityCryDec();

        Messagens.ClsMessagens Clmsg = new Messagens.ClsMessagens();
        public bool bStart = false;
        public string sCodUsr = "1";
        Color clr1 = Color.FromArgb(88, 128, 180);
        ClsUsuario usuario = new ClsUsuario();

        //classes
        public ClassDados.ClasseDml cmdBd = new ClasseDml();
        RotinasFormWindows cmfw = new RotinasFormWindows();
        ClassGenerica.RotinaGenerica rGen = new RotinaGenerica();

        // objeto conection de banco 
        public SqlConnection Connection;

        //variaveis locais
        bool bNovo = false;
        bool bAlte = false;
        bool basico = false;
        bool administrador = false;

        // Bindsource de dados
        BindingSource bdsDados = new BindingSource();

        public bool bEncerrado = false;
        public FrmCadUsuario()
        {
            InitializeComponent();

            cmdBd.fechaConn();
            //Passa a Connection string para classe de dados
            string sServidorSql = ConfigurationManager.AppSettings["Servidor-Sql"].ToString();
            string sBancoSql = ConfigurationManager.AppSettings["Banco-SQL"].ToString();
            cmdBd.sqlConnectionString = "Data Source=" + sServidorSql + ";Initial Catalog=" + sBancoSql + ";Persist Security Info=True;User ID=vox41;PWD=vox41";
            //conection para banco
            Connection = new SqlConnection(cmdBd.sqlConnectionString);
            cmdBd.abreConn();
            //string sNivel;
        }

        public bool updatBds(ref BindingSource binds, string sProc, string sParam)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = cmdBd.Excsel(sProc, sParam);
                if (cmdBd.SError == null)
                {
                    binds.DataSource = ds;
                    binds.DataMember = ds.Tables[0].TableName;
                    return true;
                }
                else
                {
                    MessageBox.Show(cmdBd.SError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                string sErrp = e.Message;
                return false;
            }
        }

        private void FrmCadUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                lblStatus.Text = sTitulo;
                Connection = new SqlConnection(cmdBd.sqlConnectionString);
                updatBds(ref bdsDados, "PPSelUsuariosTeste", "");
                cmfw.CriaGrid(ref dtgDados, "Codigo", "CodUsuario", 70, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgDados, "Usuario", "NomUsuario", 350);
                cmfw.CriaGrid(ref dtgDados, "Login", "TxtLogin", 300);
                cmfw.CriaGrid(ref dtgDados, "GP", "DomGrupo", 80, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgDados, "Ativo", "DomAtivo", 75, DataGridViewContentAlignment.MiddleCenter);

                cmfw.setLista(ref lblId, "Text", ref bdsDados, "CodUsuario");
                cmfw.setLista(ref DomGrupo, "Text", ref bdsDados, "DomGrupo");
                cmfw.setListaControls(gpDado.Controls, ref bdsDados);


                dtgDados.AutoGenerateColumns = false;
                dtgDados.DataSource = bdsDados;
                btnDel.Enabled = (bdsDados.Count > 0);
                gpDado.Enabled = btnDel.Enabled;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        static int BinaryToDec(string input)
        {
            char[] array = input.ToCharArray();
            // Reverse since 16-8-4-2-1 not 1-2-4-8-16. 
            Array.Reverse(array);
            /*
             * [0] = 1
             * [1] = 2
             * [2] = 4
             * etc
             */
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Method uses raising 2 to the power of the index. 
                    if (i == 0)
                    {
                        sum += 1;
                    }
                    else
                    {
                        sum += (int)System.Math.Pow(2, i);
                    }
                }

            }

            return sum;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (ckBasico.Checked || ckAdministrador.Checked)
            {
                check = true;
            }

            usuario = new ClsUsuario(NomUsuario.Text.Trim(), TxtLogin.Text.Trim(), DomAtivo.Text.Trim(), check);

            List<ValidationResult> listErros = new List<ValidationResult>();//lista para capturar erros e armazenar
            ValidationContext contect = new ValidationContext(usuario); //passa o obj que sera validado
            bool validator = Validator.TryValidateObject(usuario, contect, listErros, true); //valida todos os erros

            if (!validator)
            {
                StringBuilder sb = new StringBuilder(); // vai armazenar as mensagens de erro

                foreach (ValidationResult erro in listErros) // percorre a lista de erro e captura os erros
                {
                    sb.Append(erro.ErrorMessage + "\n");

                }
                MessageBox.Show(sb.ToString()); // passas as mensagens de erro para label// recebe as mensagens de erro
            }
            else
            {
                try
                {
                    string sParam = "";
                    if ((NomUsuario.Text != "") && (TxtLogin.Text != ""))
                    {
                        if (!bNovo)
                        {

                            Clmsg.frmP.sMsg = "Confirma Alteraçao???";
                            if (!Clmsg.frmP.bConf)
                            {
                                dtgDados.Enabled = true;
                                return;
                            }

                        }

                        sParam = "'" + NomUsuario.Text + "'";
                        sParam += ",'" + TxtLogin.Text.Replace(",", ".") + "'";
                        sParam += ",'" + seg.Encrypt("1234") + "'";
                        sParam += ",'" + DomAtivo.Text + "'";

                        string sFunc = "";

                        ///BinaryToDec(

                        if (ckBasico.Checked)
                            sFunc += "1";
                        else
                            sFunc += "0";

                        if (ckAdministrador.Checked)
                            sFunc += "1";
                        else
                            sFunc += "0";

                        //if (ckAlerta.Checked)
                        //    sFunc += "1";
                        //else
                        //    sFunc += "0";

                        // sFunc += "0";

                        sParam += ",'" + BinaryToDec("0000" + sFunc).ToString() + "'";

                        bool bRet = false;
                        if (bNovo)
                        {
                            bRet = usuario.CadastraUsuario(sParam);

                        }
                        else
                        {
                            string sParamUpd = @lblId.Text + "," + sParam;
                            bRet = usuario.AtualizarUsuario(sParamUpd);

                        }

                        if (bRet == true)
                        {
                            Clmsg.frmS.ShowDialog();
                            bNovo = false;
                            bAlte = false;
                            ckBasico.Enabled = true;
                            ckAdministrador.Enabled = true;
                            updatBds(ref bdsDados, "PPSelUsuariosTeste", "");
                        }
                    }
                    else
                    {
                        return;
                    }


                    btnSalva.Enabled = false;
                    dtgDados.Refresh();
                    dtgDados.Enabled = true;
                    btnDel.Text = "&Excluir";
                    btnDel.Enabled = true;
                    btnNovo.Enabled = true;
                    cmfw.Resetcor(gpDado.Controls);
                    bNovo = false;
                }
                catch
                {
                    MessageBox.Show("Erro: \r\n" + cmdBd.SError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bdsDados.MoveLast();
        }

        private void bntProximo_Click(object sender, EventArgs e)
        {
            bdsDados.MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bdsDados.MovePrevious();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bdsDados.MoveFirst();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bdsDados.AddNew();
            bNovo = true;
            gpDado.Enabled = true;
            NomUsuario.Focus();
            lblStatus.Text = "Novo Cadastro";
            cmfw.Resetcor(gpDado.Controls);
            cmfw.Resetcor(gbCK.Controls);
            administrador = false;
            basico = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            btnSalva.Enabled = true;
            cmfw.Resetcor(gpDado.Controls);
            cmfw.Resetcor(gbCK.Controls);

            usuario.DeletarUsuario(lblId.Text, bNovo, bAlte, btnDel, btnSalva, btnNovo, bdsDados, dtgDados);

            if (administrador)
            {
                ckAdministrador.Checked = true;
                ckAdministrador.Enabled = true;
            }
            else if (basico)
            {
                ckBasico.Checked = true;
                ckBasico.Enabled = true;
            }

            bAlte = false;
            bNovo = false;
            btnSalva.Enabled = false;
            dtgDados.Refresh();
            dtgDados.Enabled = true;
            btnDel.Text = "&Excluir";
            btnDel.Enabled = true;
            btnNovo.Enabled = true;
            bNovo = false;
        }

        private void FrmCadUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            bEncerrado = true;
        }

        void mudaCor(object sender)
        {
            if (!bNovo)
            {
                string sTipo = sender.GetType().ToString();
                if (sTipo.Contains("MaskedTextBox"))
                {
                    ((MaskedTextBox)sender).BackColor = Color.LightGreen;
                    bAlte = true;
                }
                else if (sTipo.Contains("TextBox"))
                {

                    ((TextBox)sender).BackColor = Color.LightGreen;
                    bAlte = true;
                }
                else if (sTipo.Contains("ComboBox"))
                {
                    ((ComboBox)sender).BackColor = Color.LightGreen;
                    bAlte = true;
                }
            }
        }

        private void NomUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            mudaCor(NomUsuario);
            btnSalva.Enabled = true;
            if (!bNovo)
            {
                lblStatus.Text = "Alteração " + sTitulo;
                bAlte = true;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
            }
        }

        private void NomUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            mudaCor(NomUsuario);
            btnSalva.Enabled = true;
            if (!bNovo)
            {
                lblStatus.Text = "Alteração " + sTitulo;
                bAlte = true;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
            }
        }

        private void NomUsuario_Enter(object sender, EventArgs e)
        {
            string sTipo = sender.GetType().ToString();
            if (sTipo.Contains("MaskedTextBox"))
                sPes = ((MaskedTextBox)sender).Name;
            else
            {
                if (sTipo.Contains("TextBox"))
                    sPes = ((TextBox)sender).Name;
            }
        }

        public static string DecimalToBinary(string data)
        {
            string result = string.Empty;
            int rem = 0;
            try
            {
                {
                    int num = int.Parse(data);
                    while (num > 0)
                    {
                        rem = num % 2;
                        num = num / 2;
                        result = rem.ToString() + result;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            result = "00000000" + result;
            result = result.Substring(result.Length - 8);

            return result;
        }

        private void DomGrupo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sFunc = DecimalToBinary(DomGrupo.Text);
                bool bGP = sFunc.Substring(sFunc.Length - 1, 1) == "1";
                //    ckAlerta.Checked = sFunc.Substring(sFunc.Length - 2, 1) == "1";
                ckAdministrador.Checked = sFunc.Substring(sFunc.Length - 1, 1) == "1";
                if (ckAdministrador.Checked)
                {
                    basico = false;
                    administrador = true;

                }
                ckBasico.Checked = sFunc.Substring(sFunc.Length - 2, 1) == "1";
                if (ckBasico.Checked)
                {
                    administrador = false;
                    basico = true;

                }
            }
            catch (Exception ex)
            {
                string erro = ex.Message;

            }
        }

        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            mudaCor(TxtLogin);
            btnSalva.Enabled = true;
            if (!bNovo)
            {
                lblStatus.Text = "Alteração " + sTitulo;
                bAlte = true;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
            }
        }

        private void TxtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            mudaCor(TxtLogin);
            btnSalva.Enabled = true;
            if (!bNovo)
            {
                lblStatus.Text = "Alteração " + sTitulo;
                bAlte = true;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
            }
        }

        private void DomAtivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            mudaCor(DomAtivo);
            btnSalva.Enabled = true;
            if (!bNovo)
            {
                lblStatus.Text = "Alteração " + sTitulo;
                bAlte = true;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
            }
        }

        private void DomAtivo_KeyUp(object sender, KeyEventArgs e)
        {
            mudaCor(DomAtivo);
            btnSalva.Enabled = true;
            if (!bNovo)
            {
                lblStatus.Text = "Alteração " + sTitulo;
                bAlte = true;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
            }
        }

        private void ckBasico_CheckedChanged(object sender, EventArgs e)
        {

            if (administrador)
            {

                btnSalva.Enabled = true;
                lblStatus.Text = "Alteração " + sTitulo;
                ckAdministrador.Checked = false;
                ckAdministrador.Enabled = false;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
                bAlte = true;

            }
            else if (bNovo)
            {
                ckAdministrador.Checked = false;
                ckAdministrador.Enabled = false;
                if (!ckBasico.Checked)
                {
                    ckAdministrador.Enabled = true;
                }
            }
        }

        private void ckAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (basico)
            {
                btnSalva.Enabled = true;
                lblStatus.Text = "Alteração " + sTitulo;
                ckBasico.Checked = false;
                ckBasico.Enabled = false;
                btnSalva.Enabled = true;
                dtgDados.Enabled = false;
                btnNovo.Enabled = false;
                btnDel.Text = "&Cancelar";
                bAlte = true;

            }
            else if (bNovo)
            {
                ckBasico.Checked = false;
                ckBasico.Enabled = false;
                if (!ckAdministrador.Checked)
                {
                    ckBasico.Enabled = true;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
