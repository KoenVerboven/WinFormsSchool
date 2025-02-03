using AppCode.BLL.BLLClasses;
using AppCode.BLL.GeneralClasses;
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
            WindowState = FormWindowState.Maximized;
            
            LabelMessage.Text = string.Empty;
            LabelMessage.Font = new Font(Font, FontStyle.Italic);
            LabelMessage.ForeColor = Color.Red;

            ButtonClose.BackColor = Color.White;
            ButtonClose.ForeColor = Color.White;
            ButtonClose.Height = 45;
            ButtonClose.Width = 45;
            ButtonClose.Image = Properties.Resources.back1;
            ButtonClose.FlatStyle = FlatStyle.Flat;
            ButtonClose.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonClose.Text = string.Empty;

            PictureBoxArticle.BackColor = Color.LightGray;

            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel2.Text = string.Empty;

            SetAllTextboxesOnFormReadOnly(true);

            SetLabelProperties(Color.White, new Font("Helvetica", 10));

            LabelPageTitle.Text = "Article Detail";

            ToolStripStatusLabel1.BackColor = Color.White;
            ToolStripStatusLabel2.BackColor = Color.White;

            CheckBoxFragile.AutoCheck = false;

            var ToolTip2 = new ToolTip();
            ToolTip2.SetToolTip(this.ButtonClose, "Close this page");

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
            catch (Exception oEx)
            {
                var dictErrorData = new Dictionary<string, string>()
                {
                  { "UserName", "" },
                  { "Form", "SchoolArticleForm" },
                  { "Method", "LoadSelectedArticle" },
                  { "selectedArticleId", selectedArticleId.ToString() }
                };
                var logError = new LogError();
                LogError.LogException(oEx, dictErrorData);

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

        private void ButtonClose_Click(object sender, EventArgs e) => Close();

    }
}
