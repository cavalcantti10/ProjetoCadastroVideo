using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;
using RtspClientSharp;
using RtspClientSharp.RawFrames;
using RtspClientSharp.RawFrames.Video;
using RtspClientSharp.Rtsp;
using RTSPSnapshotMaker.RawFramesDecoding;
using RTSPSnapshotMaker.RawFramesDecoding.DecodedFrames;
using RTSPSnapshotMaker.RawFramesDecoding.FFmpeg;
using AForge.Video.FFMPEG;

namespace ControleRTSP
{
    public partial class UserContRTSP : UserControl
    {
        public bool bExibir = true;
        System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 12);
        System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
        System.Drawing.SolidBrush drawBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
        System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();

        Color greenColor = Color.FromArgb(128, 0, 255, 0);
        Color yellowColor = Color.FromArgb(128, 255, 255, 0);
        Color redColor = Color.FromArgb(128, 255, 0, 0);
        private Color rectsColor = Color.FromArgb(0, 255, 0);
        private Color rectsColor2 = Color.FromArgb(0, 0, 255);

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static int intervalMs = 5000;
        static int lastTimeSnapshotSaved;
        private static readonly Dictionary<FFmpegVideoCodecId, FFmpegVideoDecoder> _videoDecodersMap = new Dictionary<FFmpegVideoCodecId, FFmpegVideoDecoder>();
        private static byte[] _decodedFrameBuffer = new byte[0];
        private delegate void SetBmpDeleg(Bitmap bImg);
        private delegate void SetMemDeleg(byte[] bImagem);

        public int iIDCam = 0;
        public int iIDPan = 4;
        public string sCamURL = "";
        public int iNumCamFrames = 0;

        //public bool bMemoria = false;
        string sCanaMem = "";

        public delegate void PassagemCapturaHandler(byte[] MsImg);
        public event PassagemCapturaHandler OnCapturaCamera;

        public delegate void PassagemErroHandler(string sMsg);
        public event PassagemErroHandler OnErroCamera;

        public bool bResizeImage = false;

        private static int lastTick;
        private static int lastFrameRate;
        public static int frameRate;
        public int iCalculateFrameRate;

        private static FFmpegVideoDecoder decoder1;
        private static FFmpegVideoDecoder decoder2;
        private static FFmpegVideoDecoder decoder3;
        private static FFmpegVideoDecoder decoder4;
        private static FFmpegVideoDecoder decoder5;
        private static FFmpegVideoDecoder decoder6;
        private static FFmpegVideoDecoder decoder7;
        private static FFmpegVideoDecoder decoder8;

        static VideoFileWriter writer;
        static int iFrames = 20, iBitRate = 1000000;
        public static bool bGravar = false;
        public static int iLargura = 0;
        public static int iAltura = 0;
        static string snapshotName = "Videp.mp4";
        DateTime dIniVideo;


        public UserContRTSP()
        {
            InitializeComponent();
        }

        public bool fechaVideo()
        {
            if (bGravar)
            {
                writer.Close();
                bGravar = false;
                return !bGravar;
            }
            else
                return false;
        }
        public bool iniVideo(string sVideo)
        {
            try
            {
                writer = new VideoFileWriter();
                string sDir = Path.GetDirectoryName(sVideo);
                if (!Directory.Exists(sDir))
                    Directory.CreateDirectory(sDir);
                writer.Open(sVideo, iLargura, iAltura, iFrames, VideoCodec.MPEG4, iBitRate);
                bGravar = true;
                dIniVideo = DateTime.Now;
                //writer.WriteVideoFrame((Bitmap)newImage, sPantime);

            }
            catch (Exception ex)
            {
                ExibirLog("Erro (iniVideo): " + ex.Message);
                return false;
            }
            return true;
        }

        bool gravaFrame(Bitmap newImage)
        {
            try
            {
                writer.WriteVideoFrame(newImage, dIniVideo.Subtract(DateTime.Now));
            }
            catch (Exception ex)
            {
                ExibirLog("Erro (gravaFrame): " + ex.Message);
                ExibirLog("Erro Abortando Gravação...");
                bGravar = false;
                return false;
            }
            return true;
        }


        public void iniCam(string sURL, int iNumFrames, int iDCam, string sMem, int iDPan)
        {
            try
            {
                iIDCam = iDCam;
                sCamURL = sURL;
                iNumCamFrames = iNumFrames;
                sCanaMem = sMem;
                iIDPan = iDPan - 4;
                startCam(sURL, iNumFrames, iDCam);
            }
            catch (Exception ex)
            {
                ExibirLog("Erro (iniCam/" + sCanaMem + "): " + ex.Message);
            }
        }

        void startCam(string sURL, int iNumFrames, int iiDCam)
        {
            try
            {
                iIDCam = iiDCam;
                string sRTSP = sURL;
                Uri Uri = new Uri(sRTSP.Replace("#", "&"));
                Task makeSnapshotsTask = ConnectAsync(Uri, cancellationTokenSource.Token, iNumFrames);
            }
            catch (Exception ex)
            {
                ExibirLog("Erro (startCam/" + sCanaMem + "): " + ex.Message);
            }
        }

        public void Stop()
        {
            if (bGravar)
                fechaVideo();
            cancellationTokenSource.Cancel();
        }

        void ExibirLog(string sMsg)
        {
            if (OnErroCamera != null)
                OnErroCamera(sMsg);    
        }

        private async Task ConnectAsync(Uri Uri, CancellationToken token, int iNumFrames)
        {
            try
            {
                ConnectionParameters connectionParameters = new ConnectionParameters(Uri);
                intervalMs = (int)((double)1000 / (double)iNumFrames);
                lastTimeSnapshotSaved = Environment.TickCount - intervalMs;
                string sErroCamOld = "";
                int iErro = 0;
                using (var rtspClient = new RtspClient(connectionParameters))
                {
                    rtspClient.FrameReceived += OnFrameReceived;
                    while (true)
                    {
                        ExibirLog("Conectando Camera: " + sCanaMem + "...");
                        try
                        {
                            await rtspClient.ConnectAsync(token);
                        }
                        catch (OperationCanceledException)
                        {
                            return;
                        }
                        catch (RtspClientException e)
                        {
                            if (sErroCamOld != e.Message)
                                ExibirLog("Erro (ConnectAsync/" + sCanaMem + "): " + e.Message);
                            else
                                ExibirLog("Erro (ConnectAsync/" + sCanaMem + "): Falha Conexao...");
                            if (iErro > 1)
                                sErroCamOld = e.Message;
                            iErro++;
                            continue;
                        }

                        ExibirLog("Camera Conectada: " + sCanaMem + "...");

                        try
                        {
                            await rtspClient.ReceiveAsync(token);
                        }
                        catch (OperationCanceledException)
                        {
                            return;
                        }
                        catch (RtspClientException e)
                        {
                            if (sErroCamOld != e.Message)
                                ExibirLog("Erro (ReceiveAsync/" + sCanaMem + "): " + e.Message);
                            sErroCamOld = e.Message;
                        }
                    }
                }
            }
            catch (OperationCanceledException ex)
            {
                ExibirLog("Erro (Geral/" + sCanaMem + "): " + ex.Message);
            }
        }

        private static FFmpegVideoDecoder GetDecoderForFrameOk(RawVideoFrame videoFrame, int iDCam)
        {
            FFmpegVideoCodecId codecId = DetectCodecId(videoFrame);
            if (!_videoDecodersMap.TryGetValue(codecId, out FFmpegVideoDecoder decoder))
            {
                decoder = FFmpegVideoDecoder.CreateDecoder(codecId);
                _videoDecodersMap.Add(codecId, decoder);
            }
            return decoder;
        }

        private static FFmpegVideoDecoder GetDecoderForFrame(RawVideoFrame videoFrame, int iDCam)
        {
            FFmpegVideoCodecId codecId = DetectCodecId(videoFrame);
            FFmpegVideoDecoder decoder = null;
            if (iDCam == 1)
            {
                if (decoder1 == null)
                    decoder1 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder1;
            }
            if (iDCam == 2)
            {
                if (decoder2 == null)
                    decoder2 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder2;
            }
            if (iDCam == 3)
            {
                if (decoder3 == null)
                    decoder3 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder3;
            }
            if (iDCam == 4)
            {
                if (decoder4 == null)
                    decoder4 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder4;
            }
            if (iDCam == 5)
            {
                if (decoder5 == null)
                    decoder5 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder5;
            }
            if (iDCam == 6)
            {
                if (decoder6 == null)
                    decoder6 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder6;
            }
            if (iDCam == 7)
            {
                if (decoder7 == null)
                    decoder7 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder7;
            }
            if (iDCam == 8)
            {
                if (decoder8 == null)
                    decoder8 = FFmpegVideoDecoder.CreateDecoder(codecId);
                return decoder8;
            }
            return decoder;
        }


        private static FFmpegVideoCodecId DetectCodecId(RawVideoFrame videoFrame)
        {
            if (videoFrame is RawJpegFrame)
                return FFmpegVideoCodecId.MJPEG;
            if (videoFrame is RawH264Frame)
                return FFmpegVideoCodecId.H264;

            throw new ArgumentOutOfRangeException(nameof(videoFrame));
        }

        private void OnFrameReceived(object sender, RawFrame rawFrame)
        {
            lock (this)
            {
                if (Math.Abs(Environment.TickCount - lastTimeSnapshotSaved) < (intervalMs/2))
                    return;
                lastTimeSnapshotSaved = Environment.TickCount;

                try
                {
                    if (!(rawFrame is RawVideoFrame rawVideoFrame))
                        return;

                    FFmpegVideoDecoder decoder = GetDecoderForFrame(rawVideoFrame, iIDPan);
                    if (!decoder.TryDecode(rawVideoFrame, out DecodedVideoFrameParameters decodedFrameParameters))
                        return;

                    if (iLargura == 0)
                        iLargura = decodedFrameParameters.Width;
                    if (iAltura == 0)
                        iAltura = decodedFrameParameters.Height;

                    int bufferSize;

                    bufferSize = decodedFrameParameters.Height *
                                 ImageUtils.GetStride(decodedFrameParameters.Width, RTSPSnapshotMaker.RawFramesDecoding.PixelFormat.Bgr24); //Abgr32);

                    if (_decodedFrameBuffer.Length != bufferSize)
                        _decodedFrameBuffer = new byte[bufferSize];

                    var bufferSegment = new ArraySegment<byte>(_decodedFrameBuffer);

                    var postVideoDecodingParameters = new PostVideoDecodingParameters(RectangleF.Empty,
                        new Size(decodedFrameParameters.Width, decodedFrameParameters.Height),
                        ScalingPolicy.Stretch, RTSPSnapshotMaker.RawFramesDecoding.PixelFormat.Bgr24, ScalingQuality.Bicubic);

                    IDecodedVideoFrame decodedFrame = decoder.GetDecodedFrame(bufferSegment, postVideoDecodingParameters);

                    ArraySegment<byte> frameSegment = decodedFrame.DecodedBytes;
                    //snapshotName = decodedFrame.Timestamp.ToString("O").Replace(":", "_") + ".jpg";

                    ToImage(decodedFrameParameters.Width, decodedFrameParameters.Height, snapshotName, System.Drawing.Imaging.PixelFormat.Format24bppRgb, frameSegment.Array);
                }
                catch (Exception ex)
                {
                    ExibirLog("Erro (OnFrameReceived/" + iIDCam.ToString() + "): " + ex.Message);
                }

            }

        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public Bitmap ResizeImage(ref MemoryStream ms, int width, int height)
        {
            using (Bitmap img = new Bitmap(ms))
            {
                Bitmap b = new Bitmap(width, height);
                using (Graphics g = Graphics.FromImage((System.Drawing.Image)b))
                {
                    g.DrawImage(img, 0, 0, width, height);
                }
                return b;
            }
        }

        public static byte[] ResizeImage(MemoryStream ms, Bitmap img, int width, int height)
        {
            using (Bitmap b = new Bitmap(width, height))
            {
                using (Graphics g = Graphics.FromImage((System.Drawing.Image)b))
                {
                    g.DrawImage(img, 0, 0, width, height);
                }


                //ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
                //System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
                //EncoderParameters encoderParams = new EncoderParameters(1);
                //EncoderParameter myEncoderParameter = new EncoderParameter(encoder, 80L);
                //encoderParams.Param[0] = myEncoderParameter;
                //bitMap.Save(SnapshotPath + imgName, jgpEncoder, encoderParams);


                //b.Save(ms, jgpEncoder, encoderParams);//System.Drawing.Imaging.ImageFormat.Jpeg);
                b.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            ColorMatrix colorMatrix = new ColorMatrix(
               new float[][]
               {
         new float[] {.3f, .3f, .3f, 0, 0},
         new float[] {.59f, .59f, .59f, 0, 0},
         new float[] {.11f, .11f, .11f, 0, 0},
         new float[] {0, 0, 0, 1, 0},
         new float[] {0, 0, 0, 0, 1}
               });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        public static int CalculateFrameRate()
        {
            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
            }
            frameRate++;
            return lastFrameRate;
        }


        private void ToImage(int Width, int Height, string imgName, System.Drawing.Imaging.PixelFormat pixelFormat, byte[] rgbValues)
        {
            try
            {
                using (Bitmap bitMap = new Bitmap(Width, Height, pixelFormat))
                {
                    Rectangle BoundsRect = new Rectangle(0, 0, Width, Height);
                    BitmapData bitmapData = bitMap.LockBits(BoundsRect, ImageLockMode.WriteOnly, bitMap.PixelFormat);
                    IntPtr _dataPointer = bitmapData.Scan0;
                    int _byteData = bitmapData.Stride * bitMap.Height;
                    Marshal.Copy(rgbValues, 0, _dataPointer, _byteData);
                    bitMap.UnlockBits(bitmapData);
                    //Para Salvar Imagem
                    //ImageCodecInfo jgpEncoder = GetEncoder(ImageFormat.Jpeg);
                    //System.Drawing.Imaging.Encoder encoder = System.Drawing.Imaging.Encoder.Quality;
                    //EncoderParameters encoderParams = new EncoderParameters(1);
                    //EncoderParameter myEncoderParameter = new EncoderParameter(encoder, 50L);
                    //encoderParams.Param[0] = myEncoderParameter;
                    //bitMap.Save(SnapshotPath + imgName, jgpEncoder, encoderParams);
                    //Console.WriteLine($"New frame {imgName} saved");
                    if (bGravar)
                        gravaFrame((Bitmap)bitMap.Clone());
                    if (OnCapturaCamera != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {

                            byte[] bImagem = new byte[1];
                            bImagem = null;
                            if (bResizeImage)
                                bImagem = ResizeImage(ms, bitMap, bitMap.Width / 2, bitMap.Height / 2);
                            else
                            {
                                bitMap.Save(ms,ImageFormat.Jpeg);
                                bImagem = ms.ToArray();
                            }

                            OnCapturaCamera(bImagem);
                        }
                    }
                    if (bExibir)
                    {
                        using (Graphics g = this.CreateGraphics())
                        {
                            g.DrawImage(bitMap, 0, 0, this.Width, this.Height);
                            g.Dispose();
                            bitMap.Dispose();
                        }
                    }
                    iCalculateFrameRate = CalculateFrameRate();
                }
            }
            catch (Exception ex)
            {
                ExibirLog("Erro (ToImage/" + sCanaMem + "): " + ex.Message);
            }
        }

        private void CamImagem_ReceiveHandler(byte[] item)
        {
            if (bExibir)
                this.BeginInvoke(new SetMemDeleg(ExibirImagem), new object[] { item });
        }

        void ExibirImagem(byte[] ms)
        {
            try
            {
                using (Bitmap bitMap = new Bitmap(new MemoryStream(ms)))
                {
                    using (Graphics g = this.CreateGraphics())
                    {
                        g.DrawImage(bitMap, 0, 0, this.Width, this.Height);
                        g.Dispose();
                        bitMap.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string sErro = ex.Message;
            }
        }

        private void UserContRTSP_Load(object sender, EventArgs e)
        {
        }
    }
}
