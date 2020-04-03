using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.IO;
using System.Drawing.Imaging;
using System.Xml;
using System.Threading;
using Emgu.Util;
using Emgu.CV.Face;
using Emgu.CV.Util;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif

namespace UIS
{
    public partial class Page_Home : UserControl
    {
        #region variables
        TrainFace Eigen_Recog = new TrainFace();

        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        Image prev_Face;
        List<Rectangle> faces = new List<Rectangle>();

        private VideoCapture _capture = null;
        private bool _captureInProgress;
        private Mat _frame;
        private string img_path = string.Empty;
        private string[] img_extension = new string[]{"jpg","png","bmp","tiff"};
        private string img_Name = string.Empty;
        private string img_ext = string.Empty;
        private Image<Bgr, byte> PreviousImage;
        public int delaytime = 10;
        #endregion
        #region Initialize
        public Page_Home()
        {
            InitializeComponent();
            checkexists();
            CvInvoke.UseOpenCL = false;
            try
            {
                _capture = new VideoCapture();
                _capture.ImageGrabbed += ProcessFrame_Standard;
                _frame = new Mat();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            if (Eigen_Recog.IsTrained)
            {
                MessageBox.Show("Training Data loaded");
            }
            else
            {
                MessageBox.Show("No training data found, please train program.");
            }
            Eigen_Recog.Set_Eigen_Threshold = 2000;
            SetupIniIP ip = new SetupIniIP();
            img_path = ip.IniReadValue("Settings", "Path", iniFileName);
            img_Name = ip.IniReadValue("Settings", "FilName",iniFileName);
            img_ext = img_extension[Convert.ToInt32(ip.IniReadValue("Settings", "Extension",iniFileName))];
            getLastestFileName(@"C:\Users\aitay\Desktop\src");
        }
        #endregion
        #region  refresh
        public void refreshsettings()
        {
            SetupIniIP ip = new SetupIniIP();
            img_path = ip.IniReadValue("Settings", "Path", iniFileName);
            img_Name = ip.IniReadValue("Settings", "FilName", iniFileName);
            img_ext = img_extension[Convert.ToInt32(ip.IniReadValue("Settings", "Extension", iniFileName))];

        }
        #endregion
        #region RefreshTrainingData
        public void retrain()
        {
            Eigen_Recog = new TrainFace();
            if (Eigen_Recog.IsTrained)
            {
                MessageBox.Show("Training Data loaded");
            }
            else
            {
                MessageBox.Show("No training data found, please train program using Train menu option");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            savingImage(prev_Face);
            if (Eigen_Recog.Retrain()) MessageBox.Show("Retrain Success");
        }

        #endregion
        #region Process_Standard
        DateTime dtsav = DateTime.Now;
        bool lockPrevious = false;
        string iniFileName = Application.StartupPath + "\\" + "Setting.ini";
        string pathes = Application.StartupPath + "\\" + "save.log";
        WriteIN win = new WriteIN();
        DateTime unknowntime = new DateTime();
        private void ProcessFrame_Standard(object sender, EventArgs arg)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                SetupIniIP ini = new SetupIniIP();
                string F_Detected = ini.IniReadValue("FaceDetection", "Detection", iniFileName);
                bool isOk = _capture.Retrieve(_frame, 0);
                if (_frame != null) currentFrame = new Image<Bgr, byte>(_frame.Bitmap);
                if (currentFrame != null )
                {
                    if (F_Detected == @"1")
                    {
                        using (CascadeClassifier face = new CascadeClassifier(@".\haarcascades\haarcascade_frontalface_default.xml"))
                        {
                            using (gray = currentFrame.Convert<Gray, byte>())
                            {
                                gray._EqualizeHist();
                                Rectangle[] facesDetected = face.DetectMultiScale(
                                    gray,
                                    1.1,
                                    10,
                                    new Size(20, 20),
                                    Size.Empty);
                                faces.AddRange(facesDetected);

                                if (facesDetected.Length > 0) //如果有人進來(辨識到臉)
                                {
                                    lockPrevious = true;
                                    if (PreviousImage == null) PreviousImage = currentFrame; //如果本身沒有儲存那就使用目前的pic當作背景
                                    dtsav = DateTime.Now;
                                }
                                else 
                                {
                                    DateTime dn = DateTime.Now;
                                    TimeSpan ts = dn - dtsav;
                                    if(ts.Seconds > delaytime)
                                    {
                                        if (PreviousImage != null && currentFrame != null)
                                        {
                                            Image<Bgr, byte> save = currentFrame;
                                            Gray_subtraction(PreviousImage, currentFrame,ref save);
                                            if (img_path != string.Empty && img_ext != string.Empty)
                                            {
                                                refreshsettings();
                                                try
                                                {
                                                    string s = getLastestFileName(img_path);
                                                    save.Save(string.Format(@"{0}\{1}.{2}", img_path, s, img_ext));
                                                    PreviousImage.Save(string.Format(@"{0}\Original_{1}.{2}", img_path, s, img_ext));
                                                    win.WriteIn(String.Format(@"Person ALL Leave.PIC Stored to {0}\{1}.{2}", img_path, s, img_ext), pathes);
                                                }
                                                catch { }
                                            }
                                            lockPrevious = false; 
                                        }
                                    }
                                    else {  }
                                }

                                for (int i = 0; i < facesDetected.Length; i++)
                                {
                                    facesDetected[i].X += (int)(facesDetected[i].Height * 0.15);
                                    facesDetected[i].Y += (int)(facesDetected[i].Width * 0.22);
                                    facesDetected[i].Height -= (int)(facesDetected[i].Height * 0.3);
                                    facesDetected[i].Width -= (int)(facesDetected[i].Width * 0.35);

                                    result = currentFrame.Copy(facesDetected[i]).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.Inter.Cubic);
                                    result._EqualizeHist();
                                    currentFrame.Draw(facesDetected[i], new Bgr(Color.Red), 2);

                                    prev_Face = result.ToBitmap();

                                    if (Eigen_Recog.IsTrained)
                                    {
                                        string name = Eigen_Recog.Recognise(result);
                                        int match_value = (int)Eigen_Recog.Get_Eigen_Distance;

                                        CvInvoke.PutText(currentFrame,
                                            name + " ",
                                            new Point(facesDetected[i].X - 2, facesDetected[i].Y - 2),
                                            FontFace.HersheyComplex,
                                            1.0,
                                            new Bgr(0, 255, 0).MCvScalar);
                                        
                                        win.WriteIn(string.Format("{0} INTO THE ROOM", name), pathes);
                                        if(name.ToUpper() == ("Unknown").ToUpper())
                                        {
                                            TimeSpan n = DateTime.Now - unknowntime;
                                            if(n.Seconds > 10)
                                            {
                                                String nowt = DateTime.Now.ToString();
                                                nowt = nowt.Replace("/", ".");
                                                nowt = nowt.Replace(":", ".");
                                                currentFrame.Save(string.Format(@"{0}\Unknown_{1}.{2}", img_path, nowt, img_ext));
                                                unknowntime = DateTime.Now;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    Imagebox1.Image = currentFrame;
                    if (!lockPrevious) {
                        PreviousImage = new Image<Bgr, byte>(_frame.Bitmap); dtsav = DateTime.Now; }
                }
            }
        }

        private string getLastestFileName(string path)
        {
            string Lastest = string.Empty;
            try
            { 
                DirectoryInfo fi = new DirectoryInfo(path);
                List<FileInfo> f = fi.GetFiles().ToList<FileInfo>();
                f.OrderBy(x => x.CreationTimeUtc).ToList();
                try
                {
                    int ind = 0;
                    while (ind != f.Count)
                    {
                        int open = f[ind].Name.IndexOf('[');
                        int close = f[ind].Name.IndexOf(']');
                        string text = f[ind].Name.Replace(f[ind].Name.Substring(open, close - open + 1),"[XXXX]");
                        if (text.IndexOf(img_Name) == 0) 
                        { 
                            Lastest = f[ind].Name.Split('.')[0]; 
                        }
                        ind++;
                    }
                }
                catch { Lastest = img_Name; }
                if (Lastest == string.Empty) Lastest = img_Name;
                int index = Lastest.IndexOf("[");
                int finalindex = Lastest.IndexOf("]");
                string sub = Lastest.Substring(index + 1, finalindex - index -1 );
                int sLength = sub.Length;
                Lastest = Lastest.Replace(sub, (Convert.ToInt32(sub) + 1).ToString().PadLeft(sLength,'0'));
            }
            catch 
            { 
                Lastest = Lastest.Replace("X", "0");
            }
            return Lastest;
        }   


        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }
        #endregion
        #region OpenCamera
        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {  
                    _capture.Stop();
                }
                else
                {
                    _capture.Start();
                }
                _captureInProgress = !_captureInProgress;
            }
        }
        #endregion
        #region Traning XMAL Saving
        List<string> NamestoWrite = new List<string>();
        List<string> NamesforFile = new List<string>();
        XmlDocument docu = new XmlDocument();
        private bool save_training_data(Image face_data)
        {
            try
            {
                Random rand = new Random();
                bool file_create = true;
                string facename = "face_" + bunifuMetroTextbox1.Text + "_" + rand.Next().ToString() + ".jpg";
                while (file_create)
                {

                    if (!File.Exists(Application.StartupPath + "/TrainedFaces/" + facename))
                    {
                        file_create = false;
                    }
                    else
                    {
                        facename = "face_" + bunifuMetroTextbox1.Text + "_" + rand.Next().ToString() + ".jpg";
                    }
                }

                if (Directory.Exists(Application.StartupPath + "/TrainedFaces/"))
                {
                    face_data.Save(Application.StartupPath + "/TrainedFaces/" + facename, ImageFormat.Jpeg);
                }
                else
                {
                    Directory.CreateDirectory(Application.StartupPath + "/TrainedFaces/");
                    face_data.Save(Application.StartupPath + "/TrainedFaces/" + facename, ImageFormat.Jpeg);
                }
                if (File.Exists(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml"))
                {
                    bool loading = true;
                    while (loading)
                    {
                        try
                        {
                            docu.Load(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                            loading = false;
                        }
                        catch
                        {
                            docu = null;
                            docu = new XmlDocument();
                            Thread.Sleep(10);
                        }
                    }

                    XmlElement root = docu.DocumentElement;

                    XmlElement face_D = docu.CreateElement("FACE");
                    XmlElement name_D = docu.CreateElement("NAME");
                    XmlElement file_D = docu.CreateElement("FILE");

                    //Add the values for each nodes
                    //name.Value = textBoxName.Text;
                    //age.InnerText = textBoxAge.Text;
                    //gender.InnerText = textBoxGender.Text;
                    name_D.InnerText = bunifuMetroTextbox1.Text;
                    file_D.InnerText = facename;

                    //Construct the Person element
                    //person.Attributes.Append(name);
                    face_D.AppendChild(name_D);
                    face_D.AppendChild(file_D);

                    //Add the New person element to the end of the root element
                    root.AppendChild(face_D);

                    //Save the document
                    docu.Save(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                }
                else
                {
                    FileStream FS_Face = File.OpenWrite(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                    using (XmlWriter writer = XmlWriter.Create(FS_Face))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("Faces_For_Training");

                        writer.WriteStartElement("FACE");
                        writer.WriteElementString("NAME", bunifuMetroTextbox1.Text);
                        writer.WriteElementString("FILE", facename);
                        writer.WriteEndElement();

                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                    FS_Face.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion
        #region SavingTraningDataImage
        void savingImage(Image img)
        {
            if (!save_training_data(img)) MessageBox.Show("Error", "Error in saving file info. Training data not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Success", "Saving Success", MessageBoxButtons.OK);
        }
        #endregion
        #region Gray_subtraction
        private void Gray_subtraction(Image<Bgr, byte> Background, Image<Bgr, byte> NOWIMAGE, ref Image<Bgr, byte> outputImage)
        {
            try
            {
                Image<Gray, byte> g1 = Background.SmoothGaussian(1).Convert<Gray, byte>();
                Image<Gray, byte> g2 = NOWIMAGE.SmoothGaussian(3).Convert<Gray, byte>();
                g1._EqualizeHist();
                g2._EqualizeHist();
                Image<Gray, byte> img = g1.AbsDiff(g2);

                
                var threshImage = img.CopyBlank();
                CvInvoke.Threshold(img, threshImage, 50, 255, ThresholdType.Binary);

                Mat denoiseddiffframe = new Mat();
                CvInvoke.Erode(threshImage,denoiseddiffframe,null, new Point(-1, -1), 3, BorderType.Default, new MCvScalar(1));
                CvInvoke.Dilate(denoiseddiffframe, denoiseddiffframe, null, new Point(-1, -1), 3, BorderType.Default, new MCvScalar(1));

                outputImage = NOWIMAGE;

                using (Emgu.CV.Util.VectorOfVectorOfPoint contours = new Emgu.CV.Util.VectorOfVectorOfPoint())
                {
                    CvInvoke.FindContours(denoiseddiffframe, contours, null, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                    for (int i = 0; i < contours.Size; i++)
                    {
                        CvInvoke.DrawContours(outputImage, contours, i, new MCvScalar(0, 0, 0, 127.0),2);
                    }
                }
            }
            catch
            {

            }
        }
        #endregion
        #region CheckExists
        private void checkexists()
        {
            if (!File.Exists(iniFileName))
            {
                File.Create(iniFileName).Close();
                SetupIniIP setini = new SetupIniIP();
                setini.IniWriteValue("Settings", "FilName", @"Camera_[XXXX]", iniFileName);
                setini.IniWriteValue("Settings", "Extension", @"1", iniFileName);
                setini.IniWriteValue("Settings", "Path", @".\Image", iniFileName);
                setini.IniWriteValue("CycleStorage", "Capacity", @"500MB", iniFileName);
                setini.IniWriteValue("FaceDetection", "Detection", @"1", iniFileName);
                setini.IniWriteValue("CycleStorage", "Enabled", @"1", iniFileName);
            }

            if (!File.Exists(pathes))
            {
                File.Create(pathes).Close();
            }
        }
        #endregion

        private void Imagebox1_Click(object sender, EventArgs e)
        {

        }
    }
}
