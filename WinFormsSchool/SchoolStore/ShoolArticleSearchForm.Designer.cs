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
            gridViewArticles = new DataGridView();
            buttonSearch = new Button();
            textboxSearch = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewArticles).BeginInit();
            SuspendLayout();
            // 
            // gridViewArticles
            // 
            gridViewArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewArticles.Location = new Point(37, 168);
            gridViewArticles.Name = "gridViewArticles";
            gridViewArticles.RowHeadersWidth = 51;
            gridViewArticles.Size = new Size(732, 330);
            gridViewArticles.TabIndex = 0;
            gridViewArticles.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(322, 88);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 29);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += btnGetAllArticles_Click;
            // 
            // textboxSearch
            // 
            textboxSearch.Location = new Point(37, 88);
            textboxSearch.Name = "textboxSearch";
            textboxSearch.Size = new Size(279, 27);
            textboxSearch.TabIndex = 18;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 512);
            label3.Name = "label3";
            label3.Size = new Size(321, 20);
            label3.TabIndex = 25;
            label3.Text = "Dubbel click on GridRow to open detailscreen  ";
            // 
            // SchoolArticleSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 564);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textboxSearch);
            Controls.Add(buttonSearch);
            Controls.Add(gridViewArticles);
            Name = "SchoolArticleSearchForm";
            Text = "SchoolArticleSearchForm";
            ((System.ComponentModel.ISupportInitialize)gridViewArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridViewArticles;
        private Button buttonSearch;
        private TextBox textboxSearch;
        private Label label1;
        private Label label3;
    }
}