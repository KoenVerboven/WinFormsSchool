﻿namespace WinFormsSchool
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
            TextboxSearch = new TextBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            ButtonClose = new Button();
            ButtonSearch = new Button();
            ButtonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewArticles).BeginInit();
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
            // GridViewArticles
            // 
            GridViewArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewArticles.Dock = DockStyle.Fill;
            GridViewArticles.Location = new Point(0, 0);
            GridViewArticles.Name = "GridViewArticles";
            GridViewArticles.RowHeadersWidth = 51;
            GridViewArticles.Size = new Size(873, 436);
            GridViewArticles.TabIndex = 0;
            GridViewArticles.CellDoubleClick += DataGridView1_CellDoubleClick;
            // 
            // TextboxSearch
            // 
            TextboxSearch.Location = new Point(39, 91);
            TextboxSearch.Name = "TextboxSearch";
            TextboxSearch.Size = new Size(279, 27);
            TextboxSearch.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 62);
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
            splitContainer1.Panel1.Controls.Add(ButtonDelete);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(TextboxSearch);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(GridViewArticles);
            splitContainer1.Size = new Size(873, 584);
            splitContainer1.SplitterDistance = 144;
            splitContainer1.TabIndex = 32;
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(407, 89);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(51, 30);
            ButtonClose.TabIndex = 50;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(324, 90);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(52, 29);
            ButtonSearch.TabIndex = 46;
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(497, 90);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(63, 34);
            ButtonDelete.TabIndex = 21;
            ButtonDelete.Text = "-";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // SchoolArticleSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 584);
            Controls.Add(statusStrip1);
            Controls.Add(splitContainer1);
            Name = "SchoolArticleSearchForm";
            Text = "SchoolArticleSearchForm";
            Controls.SetChildIndex(splitContainer1, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(statusStrip1, 0);
            ((System.ComponentModel.ISupportInitialize)GridViewArticles).EndInit();
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

        private DataGridView GridViewArticles;
        private TextBox TextboxSearch;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ToolStripStatusLabel1;
        private ToolStripStatusLabel ToolStripStatusLabel2;
        private SplitContainer splitContainer1;
        private Button ButtonDelete;
        private Button ButtonSearch;
        private Button ButtonClose;
    }
}