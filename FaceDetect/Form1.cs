using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace FaceDetect
{

    public partial class Form1 : Form
    {
        public Stopwatch watch { get; set; }
        MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.6d, 0.6d);
        HaarCascade FaceDetected;
        Image<Bgr, Byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> TrainedFace = null;
        Image<Gray, byte> grayFace = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> Users = new List<string>();
        int Count, NumLabels;
        string name, names = null;
        double cameraSizeX, cameraSizeY;



        public Form1() // Verifica se possui algum no DataBase  
        {
            InitializeComponent();
            FaceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
            cameraSizeY = 240;
            cameraSizeX = cameraSizeY * 1.3333333;

        }

        private void start_Click(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
            // port.Open();
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(frameProcedure);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            Count = Count + 1;
            grayFace = camera.QueryGrayFrame().Resize(Convert.ToInt32(cameraSizeX), Convert.ToInt32(cameraSizeY), Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            MCvAvgComp[][] DetectedFaces = grayFace.DetectHaarCascade(FaceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            foreach (MCvAvgComp f in DetectedFaces[0])
            {
                TrainedFace = Frame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(textName.Text);
            File.WriteAllText(Application.StartupPath + "/Faces/Faces.txt", trainingImages.ToArray().Length.ToString() + ",");
            for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
            {
                trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/Faces/face" + i + ".bmp");
                File.AppendAllText(Application.StartupPath + "/Faces/Faces.txt", labels.ToArray()[i - 1] + ",");

            }

        }

        private void frameProcedure(object sender, EventArgs e)
        {
            int xIR = 0, xIL = 0, yIT = 0, yIB = 0;

            Users.Add("");
            Frame = camera.QueryFrame().Resize(Convert.ToInt32(cameraSizeX), Convert.ToInt32(cameraSizeY), Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(FaceDetected, 1.1, 20, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            foreach (MCvAvgComp f in facesDetectedNow[0])
            {
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(Convert.ToInt32(cameraSizeX), Convert.ToInt32(cameraSizeY), Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                Frame.Draw(f.rect, new Bgr(Color.Green), 2);
                if (trainingImages.ToArray().Length != 0)
                {
                    MCvTermCriteria termCriterias = new MCvTermCriteria(Count, 0.001);
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 1500, ref termCriterias);
                    name = recognizer.Recognize(result);
                    Frame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y), new Bgr(Color.Red));

                }

                Users.Add("");

                xIR = f.rect.Right;
                xIL = f.rect.Left;
                yIB = f.rect.Bottom;
                yIT = f.rect.Top;

                if (watch.ElapsedMilliseconds > 15)
                {
                    watch = Stopwatch.StartNew();
                    //port.Write(String.Format("{0}", (180 - xIR / (cameraSizeX / 180))));
                }

            }
            coordinateXR.Text = xIR.ToString();
            coordinateXL.Text = xIL.ToString();
            coordinateYT.Text = yIB.ToString();
            coordinateYB.Text = yIT.ToString();
            sumX.Text = (xIR + xIL - 20).ToString();
            sumY.Text = (yIB + yIT - 20).ToString();

            cameraBox.Image = Frame;
            
            
            
            
            names = "";
            Users.Clear();


        }
    }
}
