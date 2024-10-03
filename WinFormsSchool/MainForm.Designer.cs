namespace WinFormsSchool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            MyPersonalDataToolStripMenuItem = new ToolStripMenuItem();
            UserAdministraionToolStripMenuItem = new ToolStripMenuItem();
            StudentsToolStripMenuItem = new ToolStripMenuItem();
            TeachersToolStripMenuItem = new ToolStripMenuItem();
            SchoolShopToolStripMenuItem = new ToolStripMenuItem();
            InfoToolStripMenuItem = new ToolStripMenuItem();
            CloseToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { MyPersonalDataToolStripMenuItem, UserAdministraionToolStripMenuItem, StudentsToolStripMenuItem, TeachersToolStripMenuItem, SchoolShopToolStripMenuItem, InfoToolStripMenuItem, CloseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 5, 0, 5);
            menuStrip1.Size = new Size(176, 510);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "MenuStripSideBar";
            // 
            // MyPersonalDataToolStripMenuItem
            // 
            MyPersonalDataToolStripMenuItem.Image = Properties.Resources.Person1;
            MyPersonalDataToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            MyPersonalDataToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            MyPersonalDataToolStripMenuItem.Name = "MyPersonalDataToolStripMenuItem";
            MyPersonalDataToolStripMenuItem.Size = new Size(163, 54);
            MyPersonalDataToolStripMenuItem.Text = "Personal Data";
            MyPersonalDataToolStripMenuItem.Click += MyPersonalDataToolStripMenuItem_Click;
            // 
            // UserAdministraionToolStripMenuItem
            // 
            UserAdministraionToolStripMenuItem.Image = (Image)resources.GetObject("UserAdministraionToolStripMenuItem.Image");
            UserAdministraionToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            UserAdministraionToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            UserAdministraionToolStripMenuItem.Name = "UserAdministraionToolStripMenuItem";
            UserAdministraionToolStripMenuItem.Size = new Size(163, 54);
            UserAdministraionToolStripMenuItem.Text = "User";
            UserAdministraionToolStripMenuItem.Click += UserAdministraionToolStripMenuItem_Click;
            // 
            // StudentsToolStripMenuItem
            // 
            StudentsToolStripMenuItem.Image = (Image)resources.GetObject("StudentsToolStripMenuItem.Image");
            StudentsToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            StudentsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            StudentsToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
            StudentsToolStripMenuItem.Padding = new Padding(5);
            StudentsToolStripMenuItem.Size = new Size(163, 64);
            StudentsToolStripMenuItem.Text = "Student";
            StudentsToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            StudentsToolStripMenuItem.Click += StudentsToolStripMenuItem_Click;
            // 
            // TeachersToolStripMenuItem
            // 
            TeachersToolStripMenuItem.Image = (Image)resources.GetObject("TeachersToolStripMenuItem.Image");
            TeachersToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            TeachersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            TeachersToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem";
            TeachersToolStripMenuItem.Padding = new Padding(5);
            TeachersToolStripMenuItem.Size = new Size(163, 64);
            TeachersToolStripMenuItem.Text = "Teacher";
            TeachersToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            TeachersToolStripMenuItem.Click += TeachersToolStripMenuItem_Click;
            // 
            // SchoolShopToolStripMenuItem
            // 
            SchoolShopToolStripMenuItem.Image = (Image)resources.GetObject("SchoolShopToolStripMenuItem.Image");
            SchoolShopToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            SchoolShopToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            SchoolShopToolStripMenuItem.Name = "SchoolShopToolStripMenuItem";
            SchoolShopToolStripMenuItem.Padding = new Padding(5);
            SchoolShopToolStripMenuItem.Size = new Size(163, 64);
            SchoolShopToolStripMenuItem.Text = "SchoolShop";
            SchoolShopToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            SchoolShopToolStripMenuItem.Click += SchoolShopToolStripMenuItem_Click;
            // 
            // InfoToolStripMenuItem
            // 
            InfoToolStripMenuItem.Image = Properties.Resources.info3;
            InfoToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            InfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            InfoToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            InfoToolStripMenuItem.Size = new Size(163, 54);
            InfoToolStripMenuItem.Text = "Info";
            InfoToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            InfoToolStripMenuItem.Click += InfoToolStripMenuItem_Click;
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Image = Properties.Resources.Close2;
            CloseToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            CloseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            CloseToolStripMenuItem.Margin = new Padding(0, 5, 0, 5);
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(163, 54);
            CloseToolStripMenuItem.Text = "Close Program";
            CloseToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(176, 484);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(766, 26);
            statusStrip1.TabIndex = 31;
            statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Padding = new Padding(0, 0, 50, 0);
            ToolStripStatusLabel1.Size = new Size(201, 20);
            ToolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(151, 20);
            ToolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 510);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "School";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
        private ToolStripMenuItem StudentsToolStripMenuItem;
        private ToolStripMenuItem TeachersToolStripMenuItem;
        private ToolStripMenuItem SchoolShopToolStripMenuItem;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem InfoToolStripMenuItem;
        private ToolStripMenuItem MyPersonalDataToolStripMenuItem;
        private ToolStripMenuItem UserAdministraionToolStripMenuItem;
    }
}