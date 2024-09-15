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
            ButtonSearch = new Button();
            label1 = new Label();
            GridViewStudents = new DataGridView();
            label2 = new Label();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextboxSearch
            // 
            TextboxSearch.Location = new Point(34, 68);
            TextboxSearch.Name = "TextboxSearch";
            TextboxSearch.Size = new Size(279, 27);
            TextboxSearch.TabIndex = 19;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(319, 68);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(171, 29);
            ButtonSearch.TabIndex = 20;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 21;
            label1.Text = "Give the full student name or a part of the name";
            // 
            // GridViewStudents
            // 
            GridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewStudents.Location = new Point(24, 117);
            GridViewStudents.Name = "GridViewStudents";
            GridViewStudents.RowHeadersWidth = 51;
            GridViewStudents.Size = new Size(764, 321);
            GridViewStudents.TabIndex = 22;
            GridViewStudents.CellDoubleClick += dgrStudents_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 29);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 23;
            label2.Text = "You can also search on the PersonId";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 535);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
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
            // StudentSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 561);
            Controls.Add(statusStrip1);
            Controls.Add(label2);
            Controls.Add(GridViewStudents);
            Controls.Add(label1);
            Controls.Add(ButtonSearch);
            Controls.Add(TextboxSearch);
            Name = "StudentSearchForm";
            Text = "StudentSearchForm";
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextboxSearch;
        private Button ButtonSearch;
        private Label label1;
        private DataGridView GridViewStudents;
        private Label label2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
    }
}