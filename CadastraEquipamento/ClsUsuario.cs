using ClassDados;
using ClsMD5;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastraEquipamento
{
    public class ClsUsuario
    {


        ClasseDml2 cmdBD = new ClasseDml2();
        SecurityCryDec cmdSeg = new SecurityCryDec();
        Messagens.ClsMessagens Clmsg = new Messagens.ClsMessagens();
        string sRetorno = "";
        public string CodUsuario = "";

        public ClsUsuario()
        {

        }

        public ClsUsuario(string user, string login, string domAtivo, bool check)
        {
            //User = user;
            //Login = login;
            //DomAtivo = domAtivo;
            //CheckBoxOpcaoUm = check;
        }

        public void conectaBd()
        {
            string sServidorSql = ConfigurationManager.AppSettings["Servidor-Sql"].ToString();
            string sBancoSql = ConfigurationManager.AppSettings["Banco-SQL"].ToString();
            cmdBD.sqlConnectionString = "Data Source=" + sServidorSql + ";Initial Catalog=" + sBancoSql + ";Persist Security Info=True;Password=vox41; User ID=vox41; Connection Timeout=360";

            if (!cmdBD.abreConn())
            {
                Clmsg.frmF = new RegrasNegocio.FrmFalha();
                Clmsg.frmF.sMsg = "Erro Banco";
            }
        }
        public bool AtualizarUsuario(string param)
        {
            conectaBd();
            //cmdBD.ExecmdProc("PPUpdUsuarios", param);
            cmdBD.ExecmdProc("PPUpdUsuariosTeste", param);

            if (cmdBD.SError != null)
            {
                Clmsg.frmF.ShowDialog();
                MessageBox.Show(cmdBD.SError, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }
        public bool CadastraUsuario(string param)
        {
            conectaBd();
            //cmdBD.ExecmdProc("PPInsUsuarios", param);
            cmdBD.ExecmdProc("PPInsUsuariosTeste", param);
            if (cmdBD.SError != null)
            {
                Clmsg.frmF.ShowDialog();
                MessageBox.Show(cmdBD.SError, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                return true;
            }
        }
        public string SeUsuario(string user, string pwd)
        {
            conectaBd();
            //sRetorno = cmdBD.Exevalue("PPSelLogin", "'" + user.Trim() +"','" + cmdSeg.Encrypt(pwd.Trim()) + "'");
            sRetorno = cmdBD.Exevalue("PPSelLoginTeste", "'" + user.Trim() + "','" + cmdSeg.Encrypt(pwd.Trim()) + "'");
            if ((cmdBD.SError != null))
            {
                sRetorno = "Erro";
                Clmsg.frmF.sMsg = "Falha Login !!";
                Clmsg.frmF.ShowDialog();
                if (cmdBD.SError != null)
                    MessageBox.Show(cmdBD.SError, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
          
            return sRetorno;
        }
        public string SeUsuarioCod(string user, string pwd, string nivel)
        {
            conectaBd();
            //sRetorno = cmdBD.Exevalue("PPSelCodLogin", "'" + user.Trim()+ "','" + cmdSeg.Encrypt(pwd.Trim()) + "'");
            sRetorno = cmdBD.Exevalue("PPSelCodLoginTeste", "'" + user.Trim() + "','" + cmdSeg.Encrypt(pwd.Trim()) + "'");
            if (cmdBD.SError != null)
            {
                sRetorno = "Erro";
                Clmsg.frmF.sMsg = "Falha Login !!";
                Clmsg.frmF.ShowDialog();
                if (cmdBD.SError != null)
                    MessageBox.Show(cmdBD.SError, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CodUsuario = sRetorno;
            return sRetorno;
        }
        public bool AtualizarLogin(string userOld, string pwdOld, string pwd)
        {

            //sRetorno = cmdBD.ExecmdProc("PPUpdLogin", "'" + userOld + "','" + cmdSeg.Encrypt(pwdOld) + "','" + cmdSeg.Encrypt(pwd) + "'");
            sRetorno = cmdBD.ExecmdProc("PPUpdLoginTeste", "'" + userOld + "','" + cmdSeg.Encrypt(pwdOld) + "','" + cmdSeg.Encrypt(pwd) + "'");
            if (cmdBD.SError != null)
            {
                sRetorno = "Erro";
                Clmsg.frmF.sMsg = "Erro ao atualizar a senha";
                Clmsg.frmF.ShowDialog();

                MessageBox.Show(cmdBD.SError, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            return true;
        }
        public void DeletarUsuario(string id, bool bNovo, bool bAlte, Button btnDel, Button btnSalva, Button btnNovo, BindingSource bdsDados, DataGridView dtgDados)
        {
            conectaBd();

            if (bAlte && !bNovo)
            {
                bdsDados.CancelEdit();
                btnDel.Text = "&Excluir";
                btnSalva.Enabled = false;
                btnNovo.Enabled = true;
                btnDel.Enabled = (bdsDados.Count > 0);
                return;

            }

            else if (bNovo)
            {
                bdsDados.RemoveCurrent();
                btnDel.Text = "&Excluir";
                btnSalva.Enabled = false;
                btnNovo.Enabled = true;
                btnDel.Enabled = (bdsDados.Count > 0);
                return;
            }

            Clmsg.frmP.sMsg = "Confirma Exclusão???";
            if (!Clmsg.frmP.bConf)
            {
                dtgDados.Enabled = true;
                return;

            }

            try
            {
                if (!bNovo)
                {
                    //cmdBD.ExecmdProc("PPDelUsuarios", id.Trim());
                    cmdBD.ExecmdProc("PPDelUsuariosTeste", id.Trim());
                }
                if (cmdBD.SError == null)
                {
                    Clmsg.frmF.sMsg = "Usuário excluído com sucesso!";
                    Clmsg.frmS.ShowDialog();
                    bNovo = false;
                    bAlte = false;
                    bdsDados.RemoveCurrent();
                }
                else
                {
                    Clmsg.frmF.sMsg = "Erro exclusão!!";
                    MessageBox.Show("Erro:\r\n" + cmdBD.SError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Clmsg.frmF.sMsg = "Erro na exclusão de usuário!";
                MessageBox.Show($"Erro:\r\n{ex.Message}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmdBD.fechaConn();
            }

        }
    }

}
