namespace WinFormsSchool
{
    partial class LoginForm
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
            ButtonLogin = new Button();
            labelUserName = new Label();
            labelPassWord = new Label();
            TextBoxUserName = new TextBox();
            TextBoxPassWord = new TextBox();
            labelMessage = new Label();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(481, 269);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(123, 29);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "LogIn";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += button1_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(271, 95);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(85, 20);
            labelUserName.TabIndex = 43;
            labelUserName.Text = "UserName :";
            // 
            // labelPassWord
            // 
            labelPassWord.AutoSize = true;
            labelPassWord.Location = new Point(278, 146);
            labelPassWord.Name = "labelPassWord";
            labelPassWord.Size = new Size(79, 20);
            labelPassWord.TabIndex = 44;
            labelPassWord.Text = "PassWord :";
            // 
            // TextBoxUserName
            // 
            TextBoxUserName.Location = new Point(377, 96);
            TextBoxUserName.Name = "TextBoxUserName";
            TextBoxUserName.Size = new Size(240, 27);
            TextBoxUserName.TabIndex = 45;
            // 
            // TextBoxPassWord
            // 
            TextBoxPassWord.Location = new Point(378, 146);
            TextBoxPassWord.Name = "TextBoxPassWord";
            TextBoxPassWord.Size = new Size(239, 27);
            TextBoxPassWord.TabIndex = 46;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(276, 207);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(100, 20);
            labelMessage.TabIndex = 47;
            labelMessage.Text = "labelMessage";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 326);
            Controls.Add(labelMessage);
            Controls.Add(TextBoxPassWord);
            Controls.Add(TextBoxUserName);
            Controls.Add(labelPassWord);
            Controls.Add(labelUserName);
            Controls.Add(ButtonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            Controls.SetChildIndex(ButtonLogin, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(labelUserName, 0);
            Controls.SetChildIndex(labelPassWord, 0);
            Controls.SetChildIndex(TextBoxUserName, 0);
            Controls.SetChildIndex(TextBoxPassWord, 0);
            Controls.SetChildIndex(labelMessage, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLogin;
        private Label labelUserName;
        private Label labelPassWord;
        private TextBox TextBoxUserName;
        private TextBox TextBoxPassWord;
        private Label labelMessage;
    }
}