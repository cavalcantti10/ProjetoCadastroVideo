using ClassDados;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;


namespace CadastraEquipamento
{
    internal class ClsCadastro
    {
        public ClassDados.ClasseDml cmdBd = new ClasseDml();

        public ClsCadastro()
        {

        }

        public void conectaBd()
        {
            cmdBd.fechaConn();
            //Passa a Connection string para classe de dados
            string sServidorSql = ConfigurationManager.AppSettings["Servidor-Sql"].ToString();
            string sBancoSql = ConfigurationManager.AppSettings["Banco-SQL"].ToString();
            cmdBd.sqlConnectionString = "Data Source=" + sServidorSql + ";Initial Catalog=" + sBancoSql + ";Persist Security Info=True;User ID=vox41;PWD=vox41";
            //conection para banco
            cmdBd.abreConn();

        }

        public bool CadastroEquipamento(string param, string param2)
        {
            conectaBd();
            cmdBd.ExecmdProc("PPinsEquipamento", param);
            cmdBd.ExecmdProc("PPinsEndereco", param2);
            if (cmdBd.SError != null)
            {

                MessageBox.Show(cmdBd.SError, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                MessageBox.Show("Cadastro Efetuado com Sucesso");
                return true;
            }

        }

        public void DeletarEquipamento( BindingSource bdsDados, DataGridView dtgDados, string param)
        {
            conectaBd();
            cmdBd.ExecmdProc("PPDelDetran", param);
          

        }
    }

}
