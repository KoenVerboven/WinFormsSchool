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
            menuStrip1 = new MenuStrip();
            studentsToolStripMenuItem1 = new ToolStripMenuItem();
            teachersToolStripMenuItem1 = new ToolStripMenuItem();
            schoolShopToolStripMenuItem = new ToolStripMenuItem();
            windowsToolStripMenuItem = new ToolStripMenuItem();
            closeAllFormsToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem1, teachersToolStripMenuItem1, schoolShopToolStripMenuItem, windowsToolStripMenuItem, infoToolStripMenuItem1, aboutToolStripMenuItem, closeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(156, 510);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "MenuStripSideBar";
            // 
            // studentsToolStripMenuItem1
            // 
            studentsToolStripMenuItem1.Name = "studentsToolStripMenuItem1";
            studentsToolStripMenuItem1.Size = new Size(143, 24);
            studentsToolStripMenuItem1.Text = "Students";
            studentsToolStripMenuItem1.Click += studentsToolStripMenuItem1_Click;
            // 
            // teachersToolStripMenuItem1
            // 
            teachersToolStripMenuItem1.Name = "teachersToolStripMenuItem1";
            teachersToolStripMenuItem1.Size = new Size(143, 24);
            teachersToolStripMenuItem1.Text = "Teachers";
            teachersToolStripMenuItem1.Click += teachersToolStripMenuItem1_Click;
            // 
            // schoolShopToolStripMenuItem
            // 
            schoolShopToolStripMenuItem.Name = "schoolShopToolStripMenuItem";
            schoolShopToolStripMenuItem.Size = new Size(143, 24);
            schoolShopToolStripMenuItem.Text = "SchoolShop";
            schoolShopToolStripMenuItem.Click += schoolShopToolStripMenuItem_Click;
            // 
            // windowsToolStripMenuItem
            // 
            windowsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeAllFormsToolStripMenuItem });
            windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            windowsToolStripMenuItem.Size = new Size(143, 24);
            windowsToolStripMenuItem.Text = "Windows";
            // 
            // closeAllFormsToolStripMenuItem
            // 
            closeAllFormsToolStripMenuItem.BackColor = SystemColors.ControlDarkDark;
            closeAllFormsToolStripMenuItem.ForeColor = Color.White;
            closeAllFormsToolStripMenuItem.Name = "closeAllFormsToolStripMenuItem";
            closeAllFormsToolStripMenuItem.Size = new Size(186, 26);
            closeAllFormsToolStripMenuItem.Text = "CloseAllForms";
            closeAllFormsToolStripMenuItem.Click += closeAllFormsToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem1
            // 
            infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            infoToolStripMenuItem1.Size = new Size(143, 24);
            infoToolStripMenuItem1.Text = "Info";
            infoToolStripMenuItem1.Click += infoToolStripMenuItem1_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(143, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(143, 24);
            closeToolStripMenuItem.Text = "Close Program";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(156, 484);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(786, 26);
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
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem windowsToolStripMenuItem;
        private ToolStripMenuItem closeAllFormsToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
        private ToolStripMenuItem studentsToolStripMenuItem1;
        private ToolStripMenuItem teachersToolStripMenuItem1;
        private ToolStripMenuItem schoolShopToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem1;
    }
}