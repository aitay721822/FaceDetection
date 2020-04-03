using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;


namespace UIS
{
    public partial class Page_Settings : UserControl
    {
        public Page_Settings()
        {
            InitializeComponent();
            RefreshSettings();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked)
            {
                bunifuMaterialTextbox3.Enabled = true;
                bunifuCheckbox5.Enabled = true;
            }
            else
            {
                bunifuMaterialTextbox3.Enabled = false;
                bunifuCheckbox5.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            SetupIniIP setini = new SetupIniIP();
            setini.IniWriteValue("Settings", "FilName", @"Camera_[XXXX]", iniFileName);
            setini.IniWriteValue("Settings", "Extension", @"1", iniFileName);
            setini.IniWriteValue("Settings", "Path", @".\Image", iniFileName);
            setini.IniWriteValue("CycleStorage", "Capacity", @"500MB", iniFileName);
            setini.IniWriteValue("FaceDetection", "Detection", @"1", iniFileName);
            setini.IniWriteValue("CycleStorage", "Enabled", @"1", iniFileName);
            RefreshSettings();
        }


        private void RefreshSettings()
        {
            SetupIniIP setini = new SetupIniIP();
            string filename = setini.IniReadValue("Settings", "FilName", iniFileName);
            string Extension = setini.IniReadValue("Settings", "Extension", iniFileName);
            string Path = setini.IniReadValue("Settings", "Path", iniFileName);
            string CycleStorage = setini.IniReadValue("CycleStorage", "Capacity", iniFileName);
            string C_Enabled = setini.IniReadValue("CycleStorage", "Enabled", iniFileName);
            string FaceDetection = setini.IniReadValue("FaceDetection", "Detection", iniFileName);

            bunifuMaterialTextbox1.Text = filename;
            bunifuDropdown1.selectedIndex = Convert.ToInt16(Extension);
            bunifuMaterialTextbox2.Text = Path;
            bunifuMaterialTextbox3.Text = CycleStorage;
            if (FaceDetection == "1") bunifuCheckbox2.Checked = true;
            else bunifuCheckbox2.Checked = false;

            if (bunifuCheckbox4.Checked) bunifuFlatButton1.Enabled = false;
            else bunifuFlatButton1.Enabled = true;

        }

        string iniFileName = Application.StartupPath + "\\" + "Setting.ini";
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.ShowNewFolderButton = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bunifuMaterialTextbox2.Text = ofd.SelectedPath;
            }
        }

        private void Page_Settings_Load(object sender, EventArgs e)
        {
            if (bunifuCheckbox4.Checked)
            {
                bunifuMaterialTextbox1.Enabled = false;
                bunifuMaterialTextbox2.Enabled = false;
                bunifuDropdown1.Enabled = false;
            }
            else
            {
                bunifuMaterialTextbox1.Enabled = true;
                bunifuMaterialTextbox2.Enabled = true;
                bunifuDropdown1.Enabled = true;
            }

            if (bunifuCheckbox1.Checked)
            {
                if (bunifuCheckbox5.Checked)
                {
                    bunifuMaterialTextbox3.Enabled = false;
                }
                else
                {
                    bunifuMaterialTextbox3.Enabled = true;
                }
            }
            else
            {
                bunifuMaterialTextbox3.Enabled = false;
                bunifuCheckbox5.Enabled = false;
            }
        }

        private void bunifuCheckbox4_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox4.Checked)
            {
                bunifuMaterialTextbox1.Text = @"Camera_[XXXX]";
                bunifuMaterialTextbox2.Text = @".\Image";
                bunifuDropdown1.selectedIndex = 1;

                bunifuMaterialTextbox1.Enabled = false;
                bunifuMaterialTextbox2.Enabled = false;
                bunifuDropdown1.Enabled = false;
                bunifuFlatButton1.Enabled = false;
            }
            else
            {

                bunifuMaterialTextbox1.Enabled = true;
                bunifuMaterialTextbox2.Enabled = true;
                bunifuDropdown1.Enabled = true;
                bunifuFlatButton1.Enabled = true;
            }
        }

        private void bunifuCheckbox5_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox5.Checked)
            {
                bunifuMaterialTextbox3.Text = "500MB";
                bunifuMaterialTextbox3.Enabled = false;
            }
            else
            {
                bunifuMaterialTextbox3.Enabled = true;
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            SetupIniIP setini = new SetupIniIP();
            setini.IniWriteValue("Settings", "FilName", bunifuMaterialTextbox1.Text, iniFileName);
            setini.IniWriteValue("Settings", "Extension", Convert.ToString(bunifuDropdown1.selectedIndex), iniFileName);
            setini.IniWriteValue("Settings", "Path", bunifuMaterialTextbox2.Text, iniFileName);
            setini.IniWriteValue("CycleStorage", "Capacity", bunifuMaterialTextbox3.Text, iniFileName);

            if (bunifuCheckbox2.Checked) setini.IniWriteValue("FaceDetection", "Detection", @"1", iniFileName);
            else setini.IniWriteValue("FaceDetection", "Detection", @"0", iniFileName);

            if (bunifuCheckbox1.Checked) setini.IniWriteValue("CycleStorage", "Enabled", @"1", iniFileName);
            else setini.IniWriteValue("CycleStorage", "Enabled", @"0", iniFileName);
            RefreshSettings();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ini Files(*.ini)|*.ini";
            ofd.Title = "Open The Settings Files";
            ofd.Multiselect = false;
            ofd.InitialDirectory = @".\\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.OpenFile() != null)
                {
                    string inifile = ofd.FileName;
                    SetupIniIP setini = new SetupIniIP();

                    string filename = setini.IniReadValue("Settings", "FilName", inifile);
                    string Extension = setini.IniReadValue("Settings", "Extension", inifile);
                    string Path = setini.IniReadValue("Settings", "Path", inifile);
                    string CycleStorage = setini.IniReadValue("CycleStorage", "Capacity", inifile);
                    string FaceDetection = setini.IniReadValue("FaceDetection", "Detection", inifile);
                    string CycleEnabled = setini.IniReadValue("CycleStorage", "Enabled", inifile);
                    bunifuMaterialTextbox1.Text = filename;
                    bunifuDropdown1.selectedIndex = Convert.ToInt16(Extension);
                    bunifuMaterialTextbox2.Text = Path;
                    bunifuMaterialTextbox3.Text = CycleStorage;
                    if (FaceDetection == "1") bunifuCheckbox2.Checked = true;
                    else bunifuCheckbox2.Checked = false;

                    if (CycleEnabled == "1") bunifuCheckbox1.Checked = true;
                    else bunifuCheckbox1.Checked = false;
                    RefreshSettings();
                }
            }
        }

        private static long CalculateDirectorySize(string DirRoute)
        {
            try
            {
                Type tp = Type.GetTypeFromProgID("Scripting.FileSystemObject");
                object fso = Activator.CreateInstance(tp);
                object fd = tp.InvokeMember("GetFolder", BindingFlags.InvokeMethod, null, fso, new object[] { DirRoute });
                long ret = Convert.ToInt64(tp.InvokeMember("Size", BindingFlags.GetProperty, null, fd, null));
                Marshal.ReleaseComObject(fso);
                return ret;
            }
            catch
            {
                return 0;
            }
        }

        public string[] Split(string text)
        {
            try
            {
                string[] Extension = new string[] { "KB", "MB", "GB" };
                int Position = -1, Index = -1;
                for (int i = 0; i < Extension.Length; i++)
                {
                    Position = text.IndexOf(Extension[i]);
                    if (Position != -1) { Index = i; break; }
                }
                string num = text.Substring(0, Position);
                return new string[] { num, Extension[Index] };
            }
            catch
            {
                return null;
            }
        }

        private void RemoveTooOldFile(string folderName)
        {
            DirectoryInfo fi = new DirectoryInfo(folderName);
            List<FileInfo> f = fi.GetFiles().ToList<FileInfo>();
            f.OrderBy(x => x.CreationTimeUtc).ToList();
            if (needDelete)
            {
                FileInfo ex = f[0];
                ex.Delete();
                f.RemoveAt(0);
            }
        }

        bool needDelete = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                SetupIniIP setini = new SetupIniIP();
                string C_En = setini.IniReadValue("CycleStorage", "Enabled", iniFileName);
                if (C_En == "1")
                {
                    string Receive = setini.IniReadValue("CycleStorage", "Capacity", iniFileName);
                    string[] s = Split(Receive);
                    long Ori = toByte(s[0], s[1]);

                    string[] getFolderSize = GetSizeFolder(setini.IniReadValue("Settings", "Path", iniFileName));
                    long gin = toByte(getFolderSize[0], getFolderSize[1]);

                    double g = ((double)gin / (double)Ori) * 100.0;
                    string str = string.Format("({0}{1}/{2}{3})", getFolderSize[0], getFolderSize[1], s[0], s[1]);
                    label2.Text = str;
                    if (Convert.ToInt32(g) >= 100) { bunifuProgressBar1.Value = 100; needDelete = true; }
                    else { bunifuProgressBar1.Value = Convert.ToInt32(g); needDelete = false; }

                    RemoveTooOldFile(bunifuMaterialTextbox2.Text);
                }
                else
                {
                    label2.Text = "Max Capacity";
                }
            }
            catch
            {

            }

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private long toByte(string Num, string exten)
        {
            long Capacities = Convert.ToInt32(Num);
            switch (exten)
            {
                case "KB":
                    Capacities = Capacities * 1024;
                    break;
                case "MB":
                    Capacities = Capacities * 1024 * 1024;
                    break;
                case "GB":
                    Capacities = Capacities * 1024 * 1024 * 1024;
                    break;
            }
            return Capacities;
        }

        private string[] calcSize(long size)
        {
            string[] Exten = { "B", "KB", "MB", "GB", "TB" };
            int Index = 0;
            while (size >= 1024)
            {
                size = size / 1024;
                Index++;
            }
            return new string[] { size.ToString(), Exten[Index] };
        }

        private string[] GetSizeFolder(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            long Size = di.EnumerateFiles("*", SearchOption.AllDirectories).Sum(fi => fi.Length);
            return calcSize(Size);
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e) {
            char current = e.KeyChar;

        }
    }
}
