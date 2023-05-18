using ClassDados;
using ClassGenerica;
using clsBateFotosCam;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastraEquipamento
{
    public partial class FrmRgVideo : Form
    {
        public string NomeUsuarioPropriedade { get; set; }
        public ClassDados.ClasseDml cmdBd = new ClasseDml();
        BindingSource bdsDados = new BindingSource();
        BindingSource bdsDados2 = new BindingSource();
        public SqlConnection Connection;
        RotinasFormWindows cmfw = new RotinasFormWindows();
        RotinasFormWindows cmfw2 = new RotinasFormWindows();
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private string nomeImagem;
        private string serialDetran;
        private string NSerie;
        private string sFaixa;
        ClsGravaVideo Foto = new ClsGravaVideo();

        bool bPrimeiraVez = true;
        public int iOffSet = 250;
        public int FramerateCam = 20;
        public bool bStart = false;
        public string sCanal = "1";
        public string sPan = "5";
        public byte[] bImgFrame = new byte[1];
        //evento erro
        public delegate void PassagemErroHandler(string Erro, string sCanal);
        public event PassagemErroHandler OnCapturaErro;
        public bool bsair;

        private delegate void SetDeleg(string sDisplay);
        public delegate void PassagemConectado(bool bStart);

        public static int frameRate;
        public string Url = "";

        public ArrayList myFrames;
        string sCanalMem = "";
        public bool bShareMem = true;
        string sVideo = "";
        //private ClasseDml2 cmdBD = new ClasseDml2();


        public FrmRgVideo()
        {
            InitializeComponent();
            btnPesquisar.Click += btnPesquisar_Click;

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

        private void FrmRgVideo_Load(object sender, EventArgs e)
        {
            Url = ConfigurationManager.AppSettings["RTPS"].ToString().Replace("#", "&");
            FramerateCam = Convert.ToInt16(ConfigurationManager.AppSettings["Framerate"].ToString());
            sCanal = ConfigurationManager.AppSettings["Canal"].ToString();
            sPan = "5"; // ConfigurationManager.AppSettings["Canal"].ToString();

            tabControl1.SelectedIndex = 1;
            sCanalMem = sCanal;
            this.Text += " " + sCanal;
            sCanal = sCanal.Replace("B", "");
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            string sTitulo = this.Text.Replace("B", "");
            int iMul = Convert.ToInt16(sTitulo.Substring(sTitulo.Length - 1, 1));
            if (iMul == 0)
                iMul = 1;
            this.Top = Screen.PrimaryScreen.WorkingArea.Height - (this.Height + (this.Height / iMul));
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - (this.Width * 2);
            this.Refresh();
            Application.DoEvents();
            timerF.Enabled = true;

            try
            {
                Connection = new SqlConnection(cmdBd.sqlConnectionString);
                updatBds(ref bdsDados, "PPVerificaImagem", "");
                cmfw.CriaGrid(ref dtgEquipamentos, "Serial Detran", "SerialDetran", 90);
                cmfw.CriaGrid(ref dtgEquipamentos, "Nº Serie", "Nserie", 90);
                cmfw.CriaGrid(ref dtgEquipamentos, "Faixa", "Faixa", 80);
                cmfw.CriaGrid(ref dtgEquipamentos, "Tipificação", "Tipificacao", 80);
                cmfw.CriaGrid(ref dtgEquipamentos, "Sinalização", "Sinalizacao", 80);

                dtgEquipamentos.AutoGenerateColumns = false;
                dtgEquipamentos.DataSource = bdsDados;

                btnPesquisar.Click += btnPesquisar_Click;
                dtgEquipamentos.CellClick += dtgEquipamentos_CellClick;

                if (dtgEquipamentos.CurrentRow != null) // verifica se a linha atual não é nula
                {
                    serialDetran = dtgEquipamentos.CurrentRow.Cells["SerialDetran"].Value.ToString();
                }
            }
            catch
            {
                MessageBox.Show($"Ocorreu um erro: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            try
            {
                Connection = new SqlConnection(cmdBd.sqlConnectionString);
                updatBds(ref bdsDados2, "PPSelCadastro", "");
                cmfw2.CriaGrid(ref dtgCadastros, "Serial Detran", "SerialDetran", 90);
                cmfw2.CriaGrid(ref dtgCadastros, "Nº Serie", "Nserie", 90);
                cmfw2.CriaGrid(ref dtgCadastros, "Faixa", "Faixa", 80);
                cmfw2.CriaGrid(ref dtgCadastros, "Tipificação", "Tipificacao", 80);
                cmfw2.CriaGrid(ref dtgCadastros, "Sinalização", "Sinalizacao", 80);


                dtgCadastros.AutoGenerateColumns = false;
                dtgCadastros.DataSource = bdsDados2;
            }
            catch
            {
                MessageBox.Show($"Ocorreu um erro: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void iniRTSP()
        {
            Uri uRIRstp = new Uri(Url);
            userContRTSP.bExibir = true;
            userContRTSP.OnErroCamera += UserContRTSP_OnErroCamera;
            userContRTSP.iniCam(Url, FramerateCam, Convert.ToInt16(sCanal), sCanalMem, Convert.ToInt16(sPan));
        }

        private void UserContRTSP_OnErroCamera(string sMsg)
        {
            if (sMsg.Trim() != "")
                AtualizaLog(sMsg);
        }

        void AtualizaLog(string sMsg)
        {
            if (sMsg.Trim() == "")
                return;

            try
            {
                this.BeginInvoke(new SetDeleg(AddLog), new object[] { sMsg });
            }
            catch { }
        }

        public void AddLog(string Line)
        {
            try
            {
                if ((Line.Contains("OK")) || (Line.Contains("Camera Conectada")))
                {
                    imgVd.Visible = false;
                    timerF.Enabled = true;
                    tabControl1.SelectedIndex = 0;
                }
                if (Line.Contains("Desconectado"))
                {
                    imgVd.Visible = true;
                    tabControl1.SelectedIndex = 1;
                }


                string sMili = "000" + DateTime.Now.Millisecond.ToString();
                sMili = sMili.Substring(sMili.Length - 3, 3);
                if (txtLog.Lines.Length > 100)
                    txtLog.Clear();
                string sMsg = DateTime.Now.ToLongTimeString() + "." + sMili + " - " + Line;
                txtLog.Text += sMsg + "\r\n";
                if (txtLog.Text.Length > 0)
                {
                    txtLog.Select(txtLog.Text.Length - 1, 0);
                    txtLog.ScrollToCaret();
                }
                if (OnCapturaErro != null)
                    OnCapturaErro(Line, sCanal);
            }
            catch { }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string filtro = $"SerialDetran LIKE '%{txtSerial.Text}%'"; // Define o filtro de pesquisa baseado no texto do TextBox txtSerial.
            bdsDados.Filter = filtro; // Aplica o filtro ao conjunto de dados bdsDados.

            if (bdsDados.Count == 0) // Verifica se não há registros no BindingSource bdsDados após a aplicação do filtro.
            {
                MessageBox.Show("Equipamento não cadastrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bdsDados.Filter = ""; // Remove o filtro para mostrar todos os equipamentos.
            }
        }

        private void dtgEquipamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEquipamentos.CurrentRow != null) // verifica se a linha atual não é nula
            {
                serialDetran = dtgEquipamentos.CurrentRow.Cells["SerialDetran"].Value.ToString();
                NSerie = dtgEquipamentos.CurrentRow.Cells["Nserie"].Value.ToString();
                sFaixa = dtgEquipamentos.CurrentRow.Cells["Faixa"].Value.ToString();
            }
        }

        private void dtgCadastros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgCadastros.Columns["SerialDetran"].Index)
            {
                // Obtém o valor do SerialDetran da célula clicada
                string serialDetran = dtgCadastros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Chama a procedure para obter os dados correspondentes
                SqlConnection con = new SqlConnection(cmdBd.sqlConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("PPRegistro", con);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("SerialDetran", serialDetran);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);

                //Preenche o segundo DataGridView com os dados obtidos
                dtgHistorico.DataSource = tabela;

            }
        }

        private void timerF_Tick(object sender, EventArgs e)
        {
            //lblFrame.Text = $"Frames: {userContRTSP1.iCalculateFrameRate}/ seg";
        }

        private void FrmRgVideo_Activated(object sender, EventArgs e)
        {
            userContRTSP.bExibir = true;
        }

        private void FrmRgVideo_Deactivate(object sender, EventArgs e)
        {
            userContRTSP.bExibir = bPrimeiraVez;
        }

        private void FrmRgVideo_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRgVideo_Resize(object sender, EventArgs e)
        {

        }

        private void FrmRgVideo_Shown(object sender, EventArgs e)
        {
            iniRTSP();
        }

        private void userContRTSP1_Load(object sender, EventArgs e)
        {

        }

        private void FrmRgVideo_FormClosing(object sender, FormClosingEventArgs e)
        {
            userContRTSP.Stop();
            userContRTSP.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            sVideo = Path.GetDirectoryName(Application.ExecutablePath) + @"\Videos\" + "#"+ serialDetran.ToString() +"#"+ String.Format("{0:yyyyMMdd}", DateTime.Now) + "#" + String.Format("{0:HHmmss}", DateTime.Now) + NSerie.ToString() +"#"+ sFaixa.ToString() +".mp4";
            btnParar.Enabled = userContRTSP.iniVideo(sVideo);
            btnGravar.Enabled = !btnParar.Enabled;
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            userContRTSP.fechaVideo();
            btnParar.Enabled = false;
            btnGravar.Enabled = !btnParar.Enabled;
        }

        private void ckView_CheckedChanged(object sender, EventArgs e)
        {
            userContRTSP.bExibir = ckView.Checked;
        }

        private void timerF_Tick_1(object sender, EventArgs e)
        {
            lblFrame.Text = $"Frames: {userContRTSP.iCalculateFrameRate}/ seg";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
