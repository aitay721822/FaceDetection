using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UIS
{
    public partial class Page_Replays : UserControl
    {
        SetupIniIP ip = new SetupIniIP();

        public Page_Replays()
        {

            InitializeComponent();
            try
            {
                FolderPath = ip.IniReadValue("Settings", "Path", iniFileName);

                while (!Directory.Exists(FolderPath))
                    Directory.CreateDirectory(FolderPath);
                if (Directory.Exists(FolderPath))
                {
                    LoadImage();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string[] ImagesArray = { };
        string FolderPath = @".\Image\";
        public void LoadImage()
        {
            imgs.Images.Clear();
            listView1.Items.Clear();
            imgs.ColorDepth = ColorDepth.Depth32Bit;
            imgs.ImageSize = new Size(100, 100);

            ImagesArray = Directory.GetFiles(FolderPath);

            string[] NameImage = new string[ImagesArray.Length];
            for (int i = 0; i < ImagesArray.Length; i++)
                NameImage[i] = new DirectoryInfo(ImagesArray[i]).Name;

            try
            {
                FileStream fs;
                foreach (String path in ImagesArray)
                {
                    fs = File.OpenRead(path);
                    imgs.Images.Add((Bitmap)Image.FromStream(fs));
                }
            }
            catch (Exception e)
            {

            }
            listView1.SmallImageList = imgs;
            for (int i = 0; i < ImagesArray.Length; i++)
            {
                listView1.Items.Add(NameImage[i], i);
            }
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                int ImageIndexes = listView1.SelectedItems[0].ImageIndex;
                pictureBox1.Image = Image.FromFile(ImagesArray[ImageIndexes]);
            }
            catch
            {

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string iniFileName = Application.StartupPath + "\\" + "Setting.ini";
        public void refreshsettings()
        {
            FolderPath = ip.IniReadValue("Settings", "Path", iniFileName);
            LoadImage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshsettings();
        }
    }
}
