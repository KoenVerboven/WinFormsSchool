﻿using AppCode.BLL.BLLClasses;
using WinFormsSchool.GeneralForms;


namespace WinFormsSchool
{
    public partial class SchoolArticleForm : Base.BaseForm1
    {
        readonly ArticleBLL SchoolArticle;

        public SchoolArticleForm()
        {
            InitializeComponent();
            InitializeControls();
            Height = 610;
            Width = 1100;
            SchoolArticle = new ArticleBLL();
        }

        private void InitializeControls()
        {
            LabelMessage.Text = string.Empty;
            LabelMessage.Font = new Font(Font, FontStyle.Italic);
            LabelMessage.ForeColor = Color.Red;

            PictureBoxArticle.BackColor = Color.LightGray;

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel2.Text = string.Empty;

            SetAllTextboxesOnFormReadOnly(true);

            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            LabelPageTitle.Text = "Article Detail";

            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;
           
            CheckBoxFragile.AutoCheck = false;

        }

        private void SetAllTextboxesOnFormReadOnly(bool readOnly)
        {
            foreach (var control in Controls)
            {
                if (control is TextBox textEdit)
                {
                    textEdit.ReadOnly = readOnly;
                }
            }
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

        internal void LoadSelectedArticle(int selectedArticleId)
        {
            try
            {
                var selectedArticle = SchoolArticle.GetArticleById(selectedArticleId);//selectedArticle Met hoofdletter?

                if (selectedArticle is not null)
                {
                    //selectedArticle = null;//ToDo error uitlokken weg doen
                    TextboxArticleId.Text = selectedArticle.ArticleId.ToString();
                    TextboxArticleName.Text = selectedArticle.ArticleName;
                    TextboxArticlePrice.Text = (selectedArticle.ArticlePrice is not null) ? selectedArticle.ArticlePrice.ToString() + " €" : "Price unkown"; // rekening houden met null value
                    TextBoxNumberInStock.Text = selectedArticle.NumberInStock.ToString();
                    TextBoxMinimumStock.Text = selectedArticle.MinStock.ToString();
                    CheckBoxFragile.Checked = selectedArticle.Fragile;
                    TextBoxArticleSize.Text = Convert.ToString(selectedArticle.ArticleSize);
                    LabelMessage.Text = (selectedArticle.Message is not null) ? selectedArticle.Message.ToString() : "";
                    LabelMessage.ForeColor = Color.Yellow;
                    if (selectedArticle.ArticlePicture == null)
                    {
                        LabelArticleFoto.Text = "No picture available";
                        PictureBoxArticle.Visible = false;
                    }
                }

            }
            catch (ArgumentOutOfRangeException oEx)
            {
                LogException(oEx, "", "SchoolArticleForm", "LoadSelectedArticle", "selectedArticleId=" + selectedArticleId, DateTime.Now);
                ShowErrorMessage();
            }
            catch (Exception oEx)
            {
                LogException(oEx,"","SchoolArticleForm", "LoadSelectedArticle", "selectedArticleId=" + selectedArticleId, DateTime.Now);
                ShowErrorMessage();
            }
        }

        private static void ShowErrorMessage()
        {
            CustomErrorForm customErrorForm = new(
                             new("An error occurred. Please try again later.", "", "", "", false, null, DateTime.Now)
                                                 );
            customErrorForm.ShowDialog();
        }

        private static void LogException(Exception oEx, string userName, 
                                         string PageOrFormName, string methodName,
                                         string moreInfo, DateTime dateTime)
        {
            string[] lines =
            { "Date :" + dateTime,
              "UserName :" + userName,
              "Exception :" + oEx.Message,
              "FormName :" + PageOrFormName,
              "Methodname :" + methodName,
              "MoreInfo :" + moreInfo,
              "   "
            };

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using StreamWriter outputFile = new(Path.Combine(docPath, "WinFormsSchoolErrorLog.txt"), true);
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }

    }
}
