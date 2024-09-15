namespace WinFormsSchool
{
    partial class SchoolArticleForm
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
            labelArticlePrice = new Label();
            labelArticleName = new Label();
            labelArticleId = new Label();
            textboxArticleId = new TextBox();
            textboxArticleName = new TextBox();
            textboxArticlePrice = new TextBox();
            labelMessage = new Label();
            labelNumberInStock = new Label();
            labelMinimumStock = new Label();
            labelFragile = new Label();
            textBoxNumberInStock = new TextBox();
            textBoxMinimumStock = new TextBox();
            textBoxFragile = new TextBox();
            labelArticleFoto = new Label();
            pictureBoxArticle = new PictureBox();
            textBoxArticleSize = new TextBox();
            labelSize = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArticle).BeginInit();
            SuspendLayout();
            // 
            // labelArticlePrice
            // 
            labelArticlePrice.AutoSize = true;
            labelArticlePrice.Location = new Point(35, 92);
            labelArticlePrice.Name = "labelArticlePrice";
            labelArticlePrice.Size = new Size(84, 20);
            labelArticlePrice.TabIndex = 13;
            labelArticlePrice.Text = "ArticlePrice";
            // 
            // labelArticleName
            // 
            labelArticleName.AutoSize = true;
            labelArticleName.Location = new Point(35, 58);
            labelArticleName.Name = "labelArticleName";
            labelArticleName.Size = new Size(92, 20);
            labelArticleName.TabIndex = 12;
            labelArticleName.Text = "ArticleName";
            // 
            // labelArticleId
            // 
            labelArticleId.AutoSize = true;
            labelArticleId.Location = new Point(35, 29);
            labelArticleId.Name = "labelArticleId";
            labelArticleId.Size = new Size(65, 20);
            labelArticleId.TabIndex = 17;
            labelArticleId.Text = "ArticleId";
            // 
            // textboxArticleId
            // 
            textboxArticleId.Location = new Point(187, 26);
            textboxArticleId.Name = "textboxArticleId";
            textboxArticleId.Size = new Size(222, 27);
            textboxArticleId.TabIndex = 18;
            // 
            // textboxArticleName
            // 
            textboxArticleName.Location = new Point(187, 59);
            textboxArticleName.Name = "textboxArticleName";
            textboxArticleName.Size = new Size(222, 27);
            textboxArticleName.TabIndex = 19;
            // 
            // textboxArticlePrice
            // 
            textboxArticlePrice.Location = new Point(187, 92);
            textboxArticlePrice.Name = "textboxArticlePrice";
            textboxArticlePrice.Size = new Size(222, 27);
            textboxArticlePrice.TabIndex = 20;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(35, 307);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(100, 20);
            labelMessage.TabIndex = 22;
            labelMessage.Text = "labelMessage";
            // 
            // labelNumberInStock
            // 
            labelNumberInStock.AutoSize = true;
            labelNumberInStock.Location = new Point(35, 132);
            labelNumberInStock.Name = "labelNumberInStock";
            labelNumberInStock.Size = new Size(111, 20);
            labelNumberInStock.TabIndex = 23;
            labelNumberInStock.Text = "NumberInStock";
            // 
            // labelMinimumStock
            // 
            labelMinimumStock.AutoSize = true;
            labelMinimumStock.Location = new Point(35, 161);
            labelMinimumStock.Name = "labelMinimumStock";
            labelMinimumStock.Size = new Size(108, 20);
            labelMinimumStock.TabIndex = 24;
            labelMinimumStock.Text = "MinimumStock";
            // 
            // labelFragile
            // 
            labelFragile.AutoSize = true;
            labelFragile.Location = new Point(35, 202);
            labelFragile.Name = "labelFragile";
            labelFragile.Size = new Size(54, 20);
            labelFragile.TabIndex = 25;
            labelFragile.Text = "Fragile";
            // 
            // textBoxNumberInStock
            // 
            textBoxNumberInStock.Location = new Point(187, 129);
            textBoxNumberInStock.Name = "textBoxNumberInStock";
            textBoxNumberInStock.Size = new Size(222, 27);
            textBoxNumberInStock.TabIndex = 26;
            // 
            // textBoxMinimumStock
            // 
            textBoxMinimumStock.Location = new Point(188, 163);
            textBoxMinimumStock.Name = "textBoxMinimumStock";
            textBoxMinimumStock.Size = new Size(221, 27);
            textBoxMinimumStock.TabIndex = 27;
            // 
            // textBoxFragile
            // 
            textBoxFragile.Location = new Point(186, 202);
            textBoxFragile.Name = "textBoxFragile";
            textBoxFragile.Size = new Size(223, 27);
            textBoxFragile.TabIndex = 28;
            // 
            // labelArticleFoto
            // 
            labelArticleFoto.AutoSize = true;
            labelArticleFoto.Location = new Point(507, 29);
            labelArticleFoto.Name = "labelArticleFoto";
            labelArticleFoto.Size = new Size(82, 20);
            labelArticleFoto.TabIndex = 29;
            labelArticleFoto.Text = "ArticleFoto";
            // 
            // pictureBoxArticle
            // 
            pictureBoxArticle.Location = new Point(507, 66);
            pictureBoxArticle.Name = "pictureBoxArticle";
            pictureBoxArticle.Size = new Size(216, 174);
            pictureBoxArticle.TabIndex = 30;
            pictureBoxArticle.TabStop = false;
            // 
            // textBoxArticleSize
            // 
            textBoxArticleSize.Location = new Point(186, 242);
            textBoxArticleSize.Name = "textBoxArticleSize";
            textBoxArticleSize.Size = new Size(222, 27);
            textBoxArticleSize.TabIndex = 31;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(34, 242);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(146, 20);
            labelSize.TabIndex = 32;
            labelSize.Text = "Size (HxWxD) in mm";
            // 
            // SchoolArticleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSize);
            Controls.Add(textBoxArticleSize);
            Controls.Add(pictureBoxArticle);
            Controls.Add(labelArticleFoto);
            Controls.Add(textBoxFragile);
            Controls.Add(textBoxMinimumStock);
            Controls.Add(textBoxNumberInStock);
            Controls.Add(labelFragile);
            Controls.Add(labelMinimumStock);
            Controls.Add(labelNumberInStock);
            Controls.Add(labelMessage);
            Controls.Add(textboxArticlePrice);
            Controls.Add(textboxArticleName);
            Controls.Add(textboxArticleId);
            Controls.Add(labelArticleId);
            Controls.Add(labelArticlePrice);
            Controls.Add(labelArticleName);
            Name = "SchoolArticleForm";
            Text = "SchoolArticleForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxArticle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelArticlePrice;
        private Label labelArticleName;
        private Label labelArticleId;
        private TextBox textboxArticleId;
        private TextBox textboxArticleName;
        private TextBox textboxArticlePrice;
        private Label labelMessage;
        private Label labelNumberInStock;
        private Label labelMinimumStock;
        private Label labelFragile;
        private TextBox textBoxNumberInStock;
        private TextBox textBoxMinimumStock;
        private TextBox textBoxFragile;
        private Label labelArticleFoto;
        private PictureBox pictureBoxArticle;
        private TextBox textBoxArticleSize;
        private Label labelSize;
    }
}