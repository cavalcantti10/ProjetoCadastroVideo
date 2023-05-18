using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDados;
using ClassGenerica;


namespace CadastraEquipamento
{
    public partial class FrmCadastro : Form
    {
        
        //classes
        public ClassDados.ClasseDml cmdBd = new ClasseDml();
        RotinasFormWindows cmfw = new RotinasFormWindows();
        ClsCadastro Equipamento = new ClsCadastro();

        // Bindsource de dados
        BindingSource bdsDados = new BindingSource();

        // objeto conection de banco 
        public SqlConnection Connection;
         

        public FrmCadastro()
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

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            try
            {
                Connection = new SqlConnection(cmdBd.sqlConnectionString);
                updatBds(ref bdsDados, "PPSelCadastro", "");
                cmfw.CriaGrid(ref dtgCadastros, "Serial Detran", "SerialDetran", 100, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Municipio", "Municipio", 120, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Tipo", "Tipo", 80, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Numero de Serie", "NSerie", 100, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Endereço Cadastrado", "Endereco", 165, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Sentido", "Sentido", 80, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Faixa", "Faixa", 80, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Latitude", "Latitude", 70, DataGridViewContentAlignment.MiddleCenter) ;
                cmfw.CriaGrid(ref dtgCadastros, "Longitude", "Longitude", 70, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Tipificacao", "Tipificacao", 80, DataGridViewContentAlignment.MiddleCenter);
                cmfw.CriaGrid(ref dtgCadastros, "Sinalização", "Sinalizacao", 80, DataGridViewContentAlignment.MiddleCenter);


                cmfw.setLista(ref txtSerialDetran, "Text", ref bdsDados, "SerialDetran");
                cmfw.setLista(ref txtMunicipio, "Text", ref bdsDados, "Municipio");
                cmfw.setLista(ref cbxTipo, "Text", ref bdsDados, "Tipo");
                cmfw.setLista(ref txtNSerie, "Text", ref bdsDados, "NSerie");
                cmfw.setLista(ref txtEndereco, "Text", ref bdsDados, "Endereco");
                cmfw.setLista(ref cbxSentido, "Text", ref bdsDados, "Sentido");
                cmfw.setLista(ref cbxFaixa, "Text", ref bdsDados, "Faixa");
                cmfw.setLista(ref txtLatitude, "Text", ref bdsDados, "Latitude");
                cmfw.setLista(ref txtLongitude, "Text", ref bdsDados, "Longitude");
                cmfw.setLista(ref txtTipificacao, "Text", ref bdsDados, "Tipificacao");
                cmfw.setLista(ref txtSinalizacao, "Text", ref bdsDados, "Sinalizacao");
                 
                //cmfw.setListaControls(groupBox1.Controls, ref bdsDados);

                dtgCadastros.AutoGenerateColumns = false;
                dtgCadastros.DataSource = bdsDados;
                btnDel.Enabled = (bdsDados.Count > 0);
                //gpDado.Enabled = btnDel.Enabled;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //    string sParam = "";
            //    string sParam2 = "";
            string sParam = string.Format("'{0}','{1}'", txtSerialDetran.Text,txtNSerie.Text);
            string sParam2 = string.Format("'{0}','{1}','{2}','{3}','{4}', '{5}','{6}','{7}','{8}'", txtMunicipio.Text, cbxTipo.SelectedItem.ToString(), txtEndereco.Text, cbxSentido.SelectedItem.ToString(), cbxFaixa.SelectedItem.ToString(),txtLatitude.Text, txtLongitude.Text,txtTipificacao.Text, txtSinalizacao.Text);
            // monta o parametro para enviar o cadastro para o banco de dados

            //sParam = "'" + txtSerialDetran.Text + "'";
            //sParam += ",'" + txtMunicipio.Text + "'";
            //sParam += ",'" + cbxTipo.SelectedItem.ToString() + "'";
            //sParam += ",'" + txtNSerie.Text + "'";
            //sParam2 += ",'" + txtEndereco.Text + "'";
            //sParam2 += ",'" + cbxSentido.SelectedItem.ToString() + "'";
            //sParam2 += ",'" + cbxFaixa.SelectedItem.ToString() + "'";
            //sParam2 += ",'" + txtTipificacao.Text + "'";
            //sParam2 += ",'" + txtSinalizacao.Text + "'";


            // Uso da classe ClsCadastro
            Equipamento.CadastroEquipamento(sParam,sParam2);

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bdsDados.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bdsDados.MovePrevious();
        }

        private void bntProximo_Click(object sender, EventArgs e)
        {
            bdsDados.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bdsDados.MoveLast();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            bdsDados.AddNew();
            txtSerialDetran.Focus();
            cmfw.Resetcor(gpxdados.Controls);
        }  

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            string sParam = "";

            // monta o parametro para enviar o cadastro para o banco de dados

            sParam = "'" + txtSerialDetran.Text + "'";
            sParam += ",'" + txtMunicipio.Text + "'";
            sParam += ",'" + cbxTipo.SelectedItem.ToString() + "'";
            sParam += ",'" + txtNSerie.Text + "'";
            sParam += ",'" + txtEndereco.Text + "'";
            sParam += ",'" + cbxSentido.SelectedItem.ToString() + "'";
            sParam += ",'" + cbxFaixa.SelectedItem.ToString() + "'";
            sParam += ",'" + txtTipificacao.Text + "'";
            sParam += ",'" + txtSinalizacao.Text + "'";
            sParam += "," + txtEndereco.Text + "'";
            

            // Uso da classe ClsCadastro
            Equipamento.DeletarEquipamento(bdsDados, dtgCadastros,sParam);
            cmfw.Resetcor(gpxdados.Controls);
            cmfw.Resetcor(dtgCadastros.Controls);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFaixa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTipificacao_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
