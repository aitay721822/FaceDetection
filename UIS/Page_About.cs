using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UIS
{
    public partial class Page_About : UserControl
    {
        public Page_About()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = "explorer.exe";
            ps.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ps.StartInfo.CreateNoWindow = false;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.Arguments = @"https://docs.microsoft.com/zh-tw/dotnet/csharp/";
            ps.Start();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = "explorer.exe";
            ps.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ps.StartInfo.CreateNoWindow = false;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.Arguments = @"https://opencv.org/";
            ps.Start();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process ps = new Process();
            ps.StartInfo.FileName = "explorer.exe";
            ps.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            ps.StartInfo.CreateNoWindow = false;
            ps.StartInfo.UseShellExecute = false;
            ps.StartInfo.Arguments = @"http://www.emgu.com";
            ps.Start();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
