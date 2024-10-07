namespace WinFormsSchool
{
    partial class StudentSearchForm
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
            TextboxSearch = new TextBox();
            GridViewStudents = new DataGridView();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            ButtonClose = new Button();
            ButtonSearch = new Button();
            ButtonUpdateStudent = new Button();
            ButtonInsertNewStudent = new Button();
            ButtonDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).BeginInit();
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
            // TextboxSearch
            // 
            TextboxSearch.Location = new Point(39, 98);
            TextboxSearch.Name = "TextboxSearch";
            TextboxSearch.Size = new Size(279, 27);
            TextboxSearch.TabIndex = 19;
            // 
            // GridViewStudents
            // 
            GridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewStudents.Dock = DockStyle.Fill;
            GridViewStudents.Location = new Point(0, 0);
            GridViewStudents.Name = "GridViewStudents";
            GridViewStudents.RowHeadersWidth = 51;
            GridViewStudents.Size = new Size(1320, 472);
            GridViewStudents.TabIndex = 22;
            GridViewStudents.CellDoubleClick += dgrStudents_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 71);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 23;
            label2.Text = "You can also search on the PersonId";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1320, 26);
            statusStrip1.TabIndex = 26;
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
            splitContainer1.Panel1.Controls.Add(ButtonClose);
            splitContainer1.Panel1.Controls.Add(ButtonSearch);
            splitContainer1.Panel1.Controls.Add(ButtonUpdateStudent);
            splitContainer1.Panel1.Controls.Add(ButtonInsertNewStudent);
            splitContainer1.Panel1.Controls.Add(ButtonDelete);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(TextboxSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GridViewStudents);
            splitContainer1.Size = new Size(1320, 600);
            splitContainer1.SplitterDistance = 124;
            splitContainer1.TabIndex = 27;
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(405, 96);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(51, 30);
            ButtonClose.TabIndex = 50;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(324, 97);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(52, 29);
            ButtonSearch.TabIndex = 47;
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click_1;
            // 
            // ButtonUpdateStudent
            // 
            ButtonUpdateStudent.Location = new Point(539, 97);
            ButtonUpdateStudent.Name = "ButtonUpdateStudent";
            ButtonUpdateStudent.Size = new Size(48, 28);
            ButtonUpdateStudent.TabIndex = 29;
            ButtonUpdateStudent.Text = "U";
            ButtonUpdateStudent.UseVisualStyleBackColor = true;
            ButtonUpdateStudent.Click += ButtonUpdateStudent_Click;
            // 
            // ButtonInsertNewStudent
            // 
            ButtonInsertNewStudent.Location = new Point(489, 97);
            ButtonInsertNewStudent.Name = "ButtonInsertNewStudent";
            ButtonInsertNewStudent.Size = new Size(44, 29);
            ButtonInsertNewStudent.TabIndex = 28;
            ButtonInsertNewStudent.Text = "I";
            ButtonInsertNewStudent.UseVisualStyleBackColor = true;
            ButtonInsertNewStudent.Click += ButtonInsertNewStudent_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(593, 98);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(45, 27);
            ButtonDelete.TabIndex = 27;
            ButtonDelete.Text = "-";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(39, 47);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 26;
            label1.Text = "Give the full student name or a part of the name";
            // 
            // StudentSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 600);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Name = "StudentSearchForm";
            Text = "StudentSearchForm";
            Controls.SetChildIndex(splitContainer1, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).EndInit();
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
        private TextBox TextboxSearch;
        private DataGridView GridViewStudents;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
        private SplitContainer splitContainer1;
        private Label label1;
        private Button ButtonDelete;
        private Button ButtonInsertNewStudent;
        private Button ButtonUpdateStudent;
        private Button ButtonSearch;
        private Button ButtonClose;
    }
}