namespace WinFormsSchool
{
    partial class TeacherSearchForm
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
            GridViewTeachers = new DataGridView();
            label1 = new Label();
            ButtonSearch = new Button();
            TextBoxSearch = new TextBox();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)GridViewTeachers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GridViewTeachers
            // 
            GridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewTeachers.Location = new Point(79, 123);
            GridViewTeachers.Name = "GridViewTeachers";
            GridViewTeachers.RowHeadersWidth = 51;
            GridViewTeachers.Size = new Size(686, 330);
            GridViewTeachers.TabIndex = 26;
            GridViewTeachers.CellDoubleClick += gridViewTeachers_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 20);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 25;
            label1.Text = "Give the full teacher name or a part of the name";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(383, 74);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(171, 29);
            ButtonSearch.TabIndex = 24;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(89, 76);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(279, 27);
            TextBoxSearch.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 40);
            label2.Name = "label2";
            label2.Size = new Size(251, 20);
            label2.TabIndex = 29;
            label2.Text = "You can also search on the TeacherId";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 524);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 30;
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
            // TeacherSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Controls.Add(GridViewTeachers);
            Controls.Add(label1);
            Controls.Add(ButtonSearch);
            Controls.Add(TextBoxSearch);
            Name = "TeacherSearchForm";
            Text = "TeacherSearchForm";
            ((System.ComponentModel.ISupportInitialize)GridViewTeachers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridViewTeachers;
        private Label label1;
        private Button ButtonSearch;
        private TextBox TextBoxSearch;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
    }
}