using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Runtime.InteropServices;


namespace UIS
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(0);
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();

            Environment.Exit(0);
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SwitchPage_About_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Clicks(object sender, EventArgs e)
        {
            List<UserControl> list_Control = new List<UserControl>() { page_Home1, page_Replays1, page_Traning1, page_Settings1, page_About1 };
            switch (((BunifuFlatButton)sender).Text)
            {
                case "Home":
                    for (int i = 0; i < list_Control.Count; i++)
                        list_Control[i].Visible = false;
                    page_Home1.Visible = true;
                    break;
                case "Replays":
                    for (int i = 0; i < list_Control.Count; i++)
                        list_Control[i].Visible = false;
                    page_Replays1.Visible = true;
                    break;
                case "Console":
                    for (int i = 0; i < list_Control.Count; i++)
                        list_Control[i].Visible = false;
                    page_Traning1.Visible = true;
                    break;
                case "Settings":
                    for (int i = 0; i < list_Control.Count; i++)
                        list_Control[i].Visible = false;
                    page_Settings1.Visible = true;
                    break;
                case "About":
                    for (int i = 0; i < list_Control.Count; i++)
                        list_Control[i].Visible = false;
                    page_About1.Visible = true;
                    break;
            }


        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void BAR_MD(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);

        }
    }
}
