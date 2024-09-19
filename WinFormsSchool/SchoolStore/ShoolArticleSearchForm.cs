﻿using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;
using System.Data;

namespace WinFormsSchool
{
    public partial class SchoolArticleSearchForm : Base.BaseForm1
    {
        readonly ArticleBLL SchoolArticle;
        List<Article> searchArticles;

        public SchoolArticleSearchForm()
        {
            InitializeComponent();
            InitializeControls();
            GridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SchoolArticle = new ArticleBLL();
        }

        private void InitializeControls()
        {
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel2.Text = string.Empty;
            GridViewArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewArticles.Visible = false;
            GridViewArticles.ReadOnly = true;
            GridViewArticles.ColumnHeadersDefaultCellStyle.Padding = new Padding(6);
            GridViewArticles.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkCyan;
            GridViewArticles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            GridViewArticles.ColumnHeadersDefaultCellStyle.Font = new Font("Helvetica", 10);
            GridViewArticles.EnableHeadersVisualStyles = false;
            splitContainer1.Panel2.Padding = new Padding(16);
            ButtonSearch.BackColor = Color.FromArgb(55, 150, 55);
            ButtonSearch.ForeColor = Color.White;
            ButtonSearch.Height = 35;
            ButtonSearch.Image = Properties.Resources.SearchIcon;
            ButtonSearch.FlatStyle = FlatStyle.Flat;
            ButtonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonDelete.BackColor = Color.FromArgb(200, 50, 50);
            ButtonDelete.ForeColor = Color.White;
            ButtonDelete.Height = 35;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Visible = false;
            SetLabelProperties(Color.White, new Font("Helvetica", 10));
            LabelPageTitle.Text = "Search Article";
            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
            label1.ForeColor = Color.White;
        }

        private void SetLabelProperties(Color color, Font font)
        {
            foreach (var control in Controls)
            {
                if (control is Label labelEdit)
                {
                    labelEdit.ForeColor = color;
                    labelEdit.Font = font;
                }
            }
        }

        private void ButtonGetAllArticles_Click(object sender, EventArgs e)
        {
            searchArticles = SchoolArticle.GetArticles();
            _ = int.TryParse(TextboxSearch.Text, out int articleId);

            if (searchArticles != null)
            {
                searchArticles = searchArticles
                          .Where(X => (X.ArticleName.ToLower()).Contains(TextboxSearch.Text.ToLower())
                                   || (X.ArticleId == articleId)
                                   ).ToList();


                if (searchArticles.Count > 0)
                {
                    GridViewArticles.DataSource = searchArticles;
                    GridViewArticles.Visible = true;
                    ToolStripStatusLabel1.Text = "Double click on GridRow to open detailscreen";
                    ButtonDelete.Visible = true;   
                }
                else
                {
                    GridViewArticles.Visible = false;
                    ToolStripStatusLabel1.Text = "No Articles found";
                    ToolStripStatusLabel2.Text = string.Empty;
                    ButtonDelete.Visible= false;
                }

            }

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var success = int.TryParse(GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(), out int selectedId);

            if (success)
            {
                SchoolArticleForm schoolArticleForm = new();
                schoolArticleForm.MdiParent = MdiParent;
                schoolArticleForm.LoadSelectedArticle(selectedId);
                schoolArticleForm.Show();
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure delete the selected article "
                                             + GridViewArticles.SelectedRows[0].Cells["ArticleName"].Value.ToString() + " ?"
                                             , "Delete article",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                
                if (result == DialogResult.Yes)
                {
                    var success = int.TryParse(GridViewArticles.SelectedRows[0].Cells["ArticleId"].Value.ToString(), out int selectedId);
                    if (success)
                    {
                        var itemRemove = searchArticles.Single(r => r.ArticleId == selectedId);
                       
                        if (itemRemove != null)
                        {
                            searchArticles.Remove(itemRemove);
                        }
                        
                        if (searchArticles.Count > 0)
                        {
                            GridViewArticles.DataSource = null;
                            GridViewArticles.DataSource = searchArticles;
                        }

                    }
                }

            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


