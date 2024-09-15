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
            ButtonDoubleClickGrid = new Label();
            ((System.ComponentModel.ISupportInitialize)GridViewArticles).BeginInit();
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
            GridViewArticles.CellDoubleClick += dataGridView1_CellDoubleClick;
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
            // ButtonDoubleClickGrid
            // 
            ButtonDoubleClickGrid.AutoSize = true;
            ButtonDoubleClickGrid.Location = new Point(37, 512);
            ButtonDoubleClickGrid.Name = "ButtonDoubleClickGrid";
            ButtonDoubleClickGrid.Size = new Size(321, 20);
            ButtonDoubleClickGrid.TabIndex = 25;
            ButtonDoubleClickGrid.Text = "Double click on GridRow to open detailscreen  ";
            // 
            // SchoolArticleSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 564);
            Controls.Add(ButtonDoubleClickGrid);
            Controls.Add(label1);
            Controls.Add(TextboxSearch);
            Controls.Add(ButtonSearch);
            Controls.Add(GridViewArticles);
            Name = "SchoolArticleSearchForm";
            Text = "SchoolArticleSearchForm";
            ((System.ComponentModel.ISupportInitialize)GridViewArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridViewArticles;
        private Button ButtonSearch;
        private TextBox TextboxSearch;
        private Label label1;
        private Label ButtonDoubleClickGrid;
    }
}