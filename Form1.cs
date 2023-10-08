using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Face;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private VideoCapture _capture;
        private CascadeClassifier _faceCascade;
        private Mat _frame;
        private bool _countdownActive = false;
        private int _countdown = 5; // Geri sayým süresi (saniye)
        public Form1()
        {
            InitializeComponent();

            lblCountdown.Parent = pictureBox1;
            lblCountdown.BackColor = Color.Transparent;

            _capture = new VideoCapture(0); // Varsayýlan kamera eriþimi
            _faceCascade = new CascadeClassifier(@"C:\Users\User\source\repos\WinFormsApp1\haarcascade_frontalface_default.xml");

            // Timer'ý baþlat
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _frame = new Mat();
            _capture.Read(_frame);

            if (_frame.Empty())
            {
                lblCountdown.Visible = false;
                return;
            }


            var grayFrame = new Mat();
            Cv2.CvtColor(_frame, grayFrame, ColorConversionCodes.BGR2GRAY);

            var faces = _faceCascade.DetectMultiScale(grayFrame);

            if (faces.Length == 0)
            {
                // Yüz algýlanmadý, geri sayýmý baþlat
                _countdownActive = true;
                _countdown = 5;
                timer2.Start();
                lblCountdown.Visible = false;
            }

            foreach (var faceRect in faces)
            {
                _frame.Rectangle(faceRect, Scalar.Red, 2);
            }

            pictureBox1.Image = BitmapConverter.ToBitmap(_frame);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblCountdown.Visible = false;
            if (_countdownActive)
            {
                if (_countdown > 0)
                {
                    lblCountdown.Visible = true;
                    lblCountdown.Text = "Fotoðraf Çekililiyor" + "\n" + _countdown.ToString() + " saniye bekleyin";
                    _countdown--;
                }
                else
                {
                    // Geri sayým tamamlandýðýnda fotoðrafý çek ve diðer iþlemleri yap
                    CaptureAndSavePhoto();
                    _countdownActive = false;
                    timer2.Stop();
                    lblCountdown.Text = "";
                }
            }
        }

        private void CaptureAndSavePhoto()
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var folderPath = Path.Combine(desktopPath, "Fotolar");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            var filePath = Path.Combine(folderPath, $"photo_{DateTime.Now:yyyyMMddHHmmss}.jpg");
            _frame.SaveImage(filePath);
        }
    }
}