using AppCode.BLL.BLLClasses;
using AppCode.BLL.Models;


namespace WinFormsSchool
{
    public partial class SchoolArticleForm : Form
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
        }

        internal void LoadSelectedArticle(int selectedArticleId)
        {
            try
            {
                var selectedArticle = SchoolArticle.GetArticleById(selectedArticleId);//selectedArticle Met hoofdletter?
                
                if(selectedArticle is not null)
                {
                    TextboxArticleId.Text = selectedArticle.ArticleId.ToString();
                    TextboxArticleName.Text = selectedArticle.ArticleName;
                    TextboxArticlePrice.Text = (selectedArticle.ArticlePrice is not null) ? selectedArticle.ArticlePrice.ToString() + " €" : "Price unkown"; // rekening houden met null value
                    TextBoxNumberInStock.Text = selectedArticle.NumberInStock.ToString();
                    TextBoxMinimumStock.Text = selectedArticle.MinStock.ToString();
                    TextBoxFragile.Text = selectedArticle.Fragile.ToString();
                    TextBoxArticleSize.Text =  Convert.ToString(selectedArticle.ArticleSize);
                    LabelMessage.Text = (selectedArticle.Message is not null) ? selectedArticle.Message.ToString() : "";

                    if (Convert.ToBoolean(selectedArticle.Fragile))
                    {
                        TextBoxFragile.ForeColor = Color.Red;
                    }

                    if (selectedArticle.ArticlePicture == null)
                    {
                        LabelArticleFoto.Text = "No picture available";
                    }
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Article with ArticleId " + selectedArticleId + " doesn't exist", 
                                 "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
    }
}
