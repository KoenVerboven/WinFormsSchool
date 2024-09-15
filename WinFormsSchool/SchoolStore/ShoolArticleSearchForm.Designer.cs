namespace WinFormsSchool
{
    partial class SchoolArticleSearchForm
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
            GridViewArticles = new DataGridView();
            ButtonSearch = new Button();
            TextboxSearch = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)GridViewArticles).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GridViewArticles
            // 
            GridViewArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewArticles.Location = new Point(37, 168);
            GridViewArticles.Name = "GridViewArticles";
            GridViewArticles.RowHeadersWidth = 51;
            GridViewArticles.Size = new Size(732, 330);
            GridViewArticles.TabIndex = 0;
            GridViewArticles.CellDoubleClick += DataGridView1_CellDoubleClick;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(322, 88);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(171, 29);
            ButtonSearch.TabIndex = 16;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonGetAllArticles_Click;
            // 
            // TextboxSearch
            // 
            TextboxSearch.Location = new Point(37, 88);
            TextboxSearch.Name = "TextboxSearch";
            TextboxSearch.Size = new Size(279, 27);
            TextboxSearch.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(319, 20);
            label1.TabIndex = 19;
            label1.Text = "Give the full article name or a part of the name";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel1, ToolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 558);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(873, 26);
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
            // SchoolArticleSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 584);
            Controls.Add(statusStrip1);
            Controls.Add(label1);
            Controls.Add(TextboxSearch);
            Controls.Add(ButtonSearch);
            Controls.Add(GridViewArticles);
            Name = "SchoolArticleSearchForm";
            Text = "SchoolArticleSearchForm";
            ((System.ComponentModel.ISupportInitialize)GridViewArticles).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridViewArticles;
        private Button ButtonSearch;
        private TextBox TextboxSearch;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
    }
}