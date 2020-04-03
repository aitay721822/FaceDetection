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
using Emgu.Util;
#if !(__IOS__ || NETFX_CORE)
using Emgu.CV.Cuda;
#endif
using Bunifu.Framework.UI;


namespace UIS
{
    public partial class Page_Traning : UserControl
    {
        public Page_Traning()
        {
            InitializeComponent();
            readNow = DateTime.Now;
            readPrevious = DateTime.Now;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValueChange(object sender, EventArgs e)
        {

        }

        private void Text_Entered(object sender, EventArgs e)
        {
            ((BunifuMaterialTextbox)sender).Text = string.Empty;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        DateTime readNow = new DateTime();
        DateTime readPrevious = new DateTime();

        private void loadLOG(string filepath)
        {
            try
            {
                if (!File.Exists(filepath)) File.Create(filepath);
                StreamReader str = new StreamReader(filepath);
                textBox2.Text = str.ReadToEnd();
                str.Close();
            }
            catch { }
        }

        string pathes = Application.StartupPath + "\\" + "save.log";
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string TB_Text=bunifuMaterialTextbox2.Text.ToUpper();
            bunifuMaterialTextbox2.Text = string.Empty;
            string[] arg = { "OPEN", "OPEN IT", "START", "START IT", "SHOW", "SHOW IT" };
            int index = -1;
            for(int i = 0; i < arg.Length; i++)
            {
                index = TB_Text.IndexOf(arg[i]);
                if (index >= 0) break;
            }
            if (index >= 0) { s.Open(); textBox2.Text += String.Format("[{0}]Opened EXPLORER\r\n", DateTime.Now);}
            else { textBox2.Text += String.Format("[{0}]{1}\r\n", DateTime.Now,TB_Text); }
        }

        WriteIN s = new WriteIN();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!s.inwrite) loadLOG(pathes);
        }

        private void keyenter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bunifuFlatButton1_Click(sender, e);
            }
        }

        private void Page_Traning_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
