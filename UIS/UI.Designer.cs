namespace UIS
{
    partial class UI
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));

            this.ColorBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.About = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Settings = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Traning = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Replays = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.page_Home1 = new UIS.Page_Home();
            this.page_Traning1 = new UIS.Page_Traning();
            this.page_Settings1 = new UIS.Page_Settings();
            this.page_About1 = new UIS.Page_About();
            this.page_Replays1 = new UIS.Page_Replays();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorBar
            // 
            this.ColorBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(138)))), ((int)(((byte)(77)))));
            this.ColorBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ColorBar.Location = new System.Drawing.Point(0, 0);
            this.ColorBar.Name = "ColorBar";
            this.ColorBar.Size = new System.Drawing.Size(10, 500);
            this.ColorBar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 31);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BAR_MD);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(148)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = null;
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 27;
            this.bunifuTileButton2.LabelText = "─";
            this.bunifuTileButton2.Location = new System.Drawing.Point(810, 0);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(40, 31);
            this.bunifuTileButton2.TabIndex = 11;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(115)))), ((int)(((byte)(105)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = null;
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 27;
            this.bunifuTileButton1.LabelText = "X";
            this.bunifuTileButton1.Location = new System.Drawing.Point(850, 0);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(40, 31);
            this.bunifuTileButton1.TabIndex = 10;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.About);
            this.panel2.Controls.Add(this.Settings);
            this.panel2.Controls.Add(this.Traning);
            this.panel2.Controls.Add(this.Replays);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(10, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 469);
            this.panel2.TabIndex = 2;
            // 
            // About
            // 
            this.About.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.About.BorderRadius = 0;
            this.About.ButtonText = "About";
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.DisabledColor = System.Drawing.Color.Gray;
            this.About.Dock = System.Windows.Forms.DockStyle.Top;
            this.About.Iconcolor = System.Drawing.Color.Transparent;
            this.About.Iconimage = global::UIS.Properties.Resources.Teams;
            this.About.Iconimage_right = null;
            this.About.Iconimage_right_Selected = null;
            this.About.Iconimage_Selected = null;
            this.About.IconMarginLeft = 0;
            this.About.IconMarginRight = 0;
            this.About.IconRightVisible = true;
            this.About.IconRightZoom = 0D;
            this.About.IconVisible = true;
            this.About.IconZoom = 90D;
            this.About.IsTab = false;
            this.About.Location = new System.Drawing.Point(0, 176);
            this.About.Name = "About";
            this.About.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.About.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.About.OnHoverTextColor = System.Drawing.Color.White;
            this.About.selected = false;
            this.About.Size = new System.Drawing.Size(201, 44);
            this.About.TabIndex = 10;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Textcolor = System.Drawing.Color.White;
            this.About.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Click += new System.EventHandler(this.Clicks);
            // 
            // Settings
            // 
            this.Settings.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settings.BorderRadius = 0;
            this.Settings.ButtonText = "Settings";
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.DisabledColor = System.Drawing.Color.Gray;
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.Iconcolor = System.Drawing.Color.Transparent;
            this.Settings.Iconimage = global::UIS.Properties.Resources.Settings;
            this.Settings.Iconimage_right = null;
            this.Settings.Iconimage_right_Selected = null;
            this.Settings.Iconimage_Selected = null;
            this.Settings.IconMarginLeft = 0;
            this.Settings.IconMarginRight = 0;
            this.Settings.IconRightVisible = true;
            this.Settings.IconRightZoom = 0D;
            this.Settings.IconVisible = true;
            this.Settings.IconZoom = 90D;
            this.Settings.IsTab = false;
            this.Settings.Location = new System.Drawing.Point(0, 132);
            this.Settings.Name = "Settings";
            this.Settings.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Settings.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.Settings.OnHoverTextColor = System.Drawing.Color.White;
            this.Settings.selected = false;
            this.Settings.Size = new System.Drawing.Size(201, 44);
            this.Settings.TabIndex = 9;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Textcolor = System.Drawing.Color.White;
            this.Settings.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Click += new System.EventHandler(this.Clicks);
            // 
            // Traning
            // 
            this.Traning.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.Traning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Traning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Traning.BorderRadius = 0;
            this.Traning.ButtonText = "Console";
            this.Traning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Traning.DisabledColor = System.Drawing.Color.Gray;
            this.Traning.Dock = System.Windows.Forms.DockStyle.Top;
            this.Traning.Iconcolor = System.Drawing.Color.Transparent;
            this.Traning.Iconimage = global::UIS.Properties.Resources.brain;
            this.Traning.Iconimage_right = null;
            this.Traning.Iconimage_right_Selected = null;
            this.Traning.Iconimage_Selected = null;
            this.Traning.IconMarginLeft = 0;
            this.Traning.IconMarginRight = 0;
            this.Traning.IconRightVisible = true;
            this.Traning.IconRightZoom = 0D;
            this.Traning.IconVisible = true;
            this.Traning.IconZoom = 90D;
            this.Traning.IsTab = false;
            this.Traning.Location = new System.Drawing.Point(0, 88);
            this.Traning.Name = "Traning";
            this.Traning.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Traning.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.Traning.OnHoverTextColor = System.Drawing.Color.White;
            this.Traning.selected = false;
            this.Traning.Size = new System.Drawing.Size(201, 44);
            this.Traning.TabIndex = 8;
            this.Traning.Text = "Console";
            this.Traning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Traning.Textcolor = System.Drawing.Color.White;
            this.Traning.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Traning.Click += new System.EventHandler(this.Clicks);
            // 
            // Replays
            // 
            this.Replays.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.Replays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Replays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Replays.BorderRadius = 0;
            this.Replays.ButtonText = "Replays";
            this.Replays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Replays.DisabledColor = System.Drawing.Color.Gray;
            this.Replays.Dock = System.Windows.Forms.DockStyle.Top;
            this.Replays.Iconcolor = System.Drawing.Color.Transparent;
            this.Replays.Iconimage = global::UIS.Properties.Resources.album;
            this.Replays.Iconimage_right = null;
            this.Replays.Iconimage_right_Selected = null;
            this.Replays.Iconimage_Selected = null;
            this.Replays.IconMarginLeft = 0;
            this.Replays.IconMarginRight = 0;
            this.Replays.IconRightVisible = true;
            this.Replays.IconRightZoom = 0D;
            this.Replays.IconVisible = true;
            this.Replays.IconZoom = 90D;
            this.Replays.IsTab = false;
            this.Replays.Location = new System.Drawing.Point(0, 44);
            this.Replays.Name = "Replays";
            this.Replays.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Replays.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.Replays.OnHoverTextColor = System.Drawing.Color.White;
            this.Replays.selected = false;
            this.Replays.Size = new System.Drawing.Size(201, 44);
            this.Replays.TabIndex = 7;
            this.Replays.Text = "Replays";
            this.Replays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Replays.Textcolor = System.Drawing.Color.White;
            this.Replays.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Replays.Click += new System.EventHandler(this.Clicks);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuImageButton1.Image = global::UIS.Properties.Resources.Exit;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 425);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(201, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Home
            // 
            this.Home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(107)))));
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Home.BorderRadius = 0;
            this.Home.ButtonText = "Home";
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.DisabledColor = System.Drawing.Color.Gray;
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.Iconcolor = System.Drawing.Color.Transparent;
            this.Home.Iconimage = global::UIS.Properties.Resources.home;
            this.Home.Iconimage_right = null;
            this.Home.Iconimage_right_Selected = null;
            this.Home.Iconimage_Selected = null;
            this.Home.IconMarginLeft = 0;
            this.Home.IconMarginRight = 0;
            this.Home.IconRightVisible = true;
            this.Home.IconRightZoom = 0D;
            this.Home.IconVisible = true;
            this.Home.IconZoom = 90D;
            this.Home.IsTab = false;
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(62)))), ((int)(((byte)(76)))));
            this.Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(83)))), ((int)(((byte)(101)))));
            this.Home.OnHoverTextColor = System.Drawing.Color.White;
            this.Home.selected = false;
            this.Home.Size = new System.Drawing.Size(201, 44);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Textcolor = System.Drawing.Color.White;
            this.Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Click += new System.EventHandler(this.Clicks);
            // 
            // page_Home1
            // 
            this.page_Home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.page_Home1.Location = new System.Drawing.Point(211, 31);
            this.page_Home1.Name = "page_Home1";
            this.page_Home1.Size = new System.Drawing.Size(689, 469);
            this.page_Home1.TabIndex = 7;
            // 
            // page_Traning1
            // 
            this.page_Traning1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.page_Traning1.Location = new System.Drawing.Point(211, 31);
            this.page_Traning1.Name = "page_Traning1";
            this.page_Traning1.Size = new System.Drawing.Size(686, 469);
            this.page_Traning1.TabIndex = 5;
            // 
            // page_Settings1
            // 
            this.page_Settings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.page_Settings1.Location = new System.Drawing.Point(211, 31);
            this.page_Settings1.Name = "page_Settings1";
            this.page_Settings1.Size = new System.Drawing.Size(686, 469);
            this.page_Settings1.TabIndex = 4;
            // 
            // page_About1
            // 
            this.page_About1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.page_About1.Location = new System.Drawing.Point(211, 31);
            this.page_About1.Name = "page_About1";
            this.page_About1.Size = new System.Drawing.Size(689, 469);
            this.page_About1.TabIndex = 3;
            // 
            // page_Replays1
            // 
            this.page_Replays1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.page_Replays1.Location = new System.Drawing.Point(211, 31);
            this.page_Replays1.Name = "page_Replays1";
            this.page_Replays1.Size = new System.Drawing.Size(689, 469);
            this.page_Replays1.TabIndex = 8;
            // 
            // UI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.page_Home1);
            this.Controls.Add(this.page_Traning1);
            this.Controls.Add(this.page_Settings1);
            this.Controls.Add(this.page_About1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ColorBar);
            this.Controls.Add(this.page_Replays1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UI";
            this.Text = "Anti-Theft";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));

        }

        #endregion

        private System.Windows.Forms.Panel ColorBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Home;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton Settings;
        private Bunifu.Framework.UI.BunifuFlatButton Traning;
        private Bunifu.Framework.UI.BunifuFlatButton Replays;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuFlatButton About;
        private Page_About page_About1;
        private Page_Settings page_Settings1;
        private Page_Traning page_Traning1;
        private Page_Home page_Home1;
        private Page_Replays page_Replays1;
    }
}

