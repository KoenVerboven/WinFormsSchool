namespace WinFormsSchool.Course
{
    partial class CourseSearchForm
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
            DataGridViewCourses = new DataGridView();
            ButtonClose = new Button();
            ButtonSearch = new Button();
            ButtonUpdate = new Button();
            ButtonInsertNewStudent = new Button();
            ButtonDelete = new Button();
            TextboxSearch = new TextBox();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // DataGridViewCourses
            // 
            DataGridViewCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCourses.Dock = DockStyle.Fill;
            DataGridViewCourses.Location = new Point(0, 0);
            DataGridViewCourses.Name = "DataGridViewCourses";
            DataGridViewCourses.RowHeadersWidth = 51;
            DataGridViewCourses.Size = new Size(1281, 488);
            DataGridViewCourses.TabIndex = 42;
            DataGridViewCourses.CellDoubleClick += DataGridViewCourses_CellDoubleClick;
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(415, 60);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(51, 30);
            ButtonClose.TabIndex = 55;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(324, 61);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(52, 29);
            ButtonSearch.TabIndex = 54;
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(549, 61);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(48, 28);
            ButtonUpdate.TabIndex = 53;
            ButtonUpdate.Text = "U";
            ButtonUpdate.UseVisualStyleBackColor = true;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // ButtonInsertNewStudent
            // 
            ButtonInsertNewStudent.Location = new Point(499, 61);
            ButtonInsertNewStudent.Name = "ButtonInsertNewStudent";
            ButtonInsertNewStudent.Size = new Size(44, 29);
            ButtonInsertNewStudent.TabIndex = 52;
            ButtonInsertNewStudent.Text = "I";
            ButtonInsertNewStudent.UseVisualStyleBackColor = true;
            ButtonInsertNewStudent.Click += ButtonInsertNewStudent_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(603, 62);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(45, 27);
            ButtonDelete.TabIndex = 51;
            ButtonDelete.Text = "-";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // TextboxSearch
            // 
            TextboxSearch.Location = new Point(39, 63);
            TextboxSearch.Name = "TextboxSearch";
            TextboxSearch.Size = new Size(279, 27);
            TextboxSearch.TabIndex = 56;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 598);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1281, 26);
            statusStrip1.TabIndex = 57;
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
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(TextboxSearch);
            splitContainer1.Panel1.Controls.Add(ButtonDelete);
            splitContainer1.Panel1.Controls.Add(ButtonInsertNewStudent);
            splitContainer1.Panel1.Controls.Add(ButtonClose);
            splitContainer1.Panel1.Controls.Add(ButtonUpdate);
            splitContainer1.Panel1.Controls.Add(ButtonSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DataGridViewCourses);
            splitContainer1.Size = new Size(1281, 624);
            splitContainer1.SplitterDistance = 132;
            splitContainer1.TabIndex = 58;
            // 
            // CourseSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 624);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Name = "CourseSearchForm";
            Text = "CourseSearchForm";
            Controls.SetChildIndex(splitContainer1, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)DataGridViewCourses).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataGridViewCourses;
        private Button ButtonClose;
        private Button ButtonSearch;
        private Button ButtonUpdate;
        private Button ButtonInsertNewStudent;
        private Button ButtonDelete;
        private TextBox TextboxSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
        private SplitContainer splitContainer1;
    }
}