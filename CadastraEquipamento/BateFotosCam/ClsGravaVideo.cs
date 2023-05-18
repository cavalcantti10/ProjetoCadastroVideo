using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.IO;

namespace clsBateFotosCam
{
    public partial class ClsGravaVideo : Form
    {
        public ClsGravaVideo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public byte[] geImagemCgi(string sCGI, string login = null, string password = null)
        {
            int bufferSize = ((1920 * 1080) * 3) + 10240;
            int readSize = 2048;
            byte[] buffer = null;
            byte[] buffer2 = null;
            int read, total = 0;
            // web responce
            // stream for MJPEG downloading
            Stream stream = null;
            WebResponse response = null;
            HttpWebRequest request = null;
            //buffer2 = new byte[bufferSize];
            buffer = new byte[bufferSize];
            try
            {
                //SetAllowUnsafeHeaderParsing20();
                //if (request == null)
                request = (HttpWebRequest)WebRequest.Create(sCGI);
                request.Timeout = 2000;
                if ((login != null) && (password != null) && (login != string.Empty))
                    request.Credentials = new NetworkCredential(login, password);
                response = request.GetResponse();
                stream = response.GetResponseStream();
                // loop
                int bytesReceived = 0;
                while (true)
                {
                    // check total read
                    if (total > bufferSize - readSize)
                    {
                        total = 0;
                    }
                    // read next portion from stream
                    if ((read = stream.Read(buffer, total, readSize)) == 0)
                        break;

                    total += read;
                    // increment received bytes counter
                    bytesReceived += read;
                }
                buffer2 = new byte[bytesReceived];
                Array.Copy(buffer, buffer2, bytesReceived);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                // abort request
                if (request != null)
                {
                    request.Abort();
                    request = null;
                }
                // close response stream
                if (stream != null)
                {
                    stream.Close();
                    stream = null;
                }
                // close response
                if (response != null)
                {
                    response.Close();
                    response = null;
                }
            }
            return buffer2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] bImgem = gravaVideo(TxtCGI.Text);
            File.WriteAllBytes("ImagemTemp.jpg", bImgem);
            pictureBox2.Load("ImagemTemp.jpg");
        }

        public byte[] gravaVideo(string sUrl = null)
        {
            if (sUrl == null)
                sUrl = @"http://192.168.10.153/cgi-bin/snapshot.cgi?channel=1@admin@killall123";
            string[] sDados = TxtCGI.Text.Split('@');
            string sCGI = sDados[0];
            string login = sDados[1];
            string password = sDados[2];
            return geImagemCgi(sCGI, login, password);



        }

       
    }
}
