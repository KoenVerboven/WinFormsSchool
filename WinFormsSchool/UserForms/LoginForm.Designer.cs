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
            splitContainer1 = new SplitContainer();
            CheckBoxShowPassWord = new CheckBox();
            LabelNumberOfAttemps = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
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
            // ButtonLogin
            // 
            ButtonLogin.Location = new Point(283, 255);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(123, 29);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "LogIn";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(72, 60);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(85, 20);
            labelUserName.TabIndex = 43;
            labelUserName.Text = "UserName :";
            // 
            // labelPassWord
            // 
            labelPassWord.AutoSize = true;
            labelPassWord.Location = new Point(79, 111);
            labelPassWord.Name = "labelPassWord";
            labelPassWord.Size = new Size(79, 20);
            labelPassWord.TabIndex = 44;
            labelPassWord.Text = "PassWord :";
            // 
            // TextBoxUserName
            // 
            TextBoxUserName.Location = new Point(178, 61);
            TextBoxUserName.Name = "TextBoxUserName";
            TextBoxUserName.Size = new Size(240, 27);
            TextBoxUserName.TabIndex = 45;
            // 
            // TextBoxPassWord
            // 
            TextBoxPassWord.Location = new Point(179, 111);
            TextBoxPassWord.Name = "TextBoxPassWord";
            TextBoxPassWord.Size = new Size(239, 27);
            TextBoxPassWord.TabIndex = 46;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(79, 210);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(100, 20);
            labelMessage.TabIndex = 47;
            labelMessage.Text = "labelMessage";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(CheckBoxShowPassWord);
            splitContainer1.Panel2.Controls.Add(LabelNumberOfAttemps);
            splitContainer1.Panel2.Controls.Add(labelUserName);
            splitContainer1.Panel2.Controls.Add(labelMessage);
            splitContainer1.Panel2.Controls.Add(ButtonLogin);
            splitContainer1.Panel2.Controls.Add(TextBoxPassWord);
            splitContainer1.Panel2.Controls.Add(labelPassWord);
            splitContainer1.Panel2.Controls.Add(TextBoxUserName);
            splitContainer1.Size = new Size(781, 397);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 48;
            // 
            // CheckBoxShowPassWord
            // 
            CheckBoxShowPassWord.AutoSize = true;
            CheckBoxShowPassWord.ForeColor = Color.Cornsilk;
            CheckBoxShowPassWord.Location = new Point(180, 154);
            CheckBoxShowPassWord.Name = "CheckBoxShowPassWord";
            CheckBoxShowPassWord.Size = new Size(134, 24);
            CheckBoxShowPassWord.TabIndex = 50;
            CheckBoxShowPassWord.Text = "Show password";
            CheckBoxShowPassWord.UseVisualStyleBackColor = true;
            CheckBoxShowPassWord.CheckedChanged += CheckBoxShowPassWord_CheckedChanged;
            // 
            // LabelNumberOfAttemps
            // 
            LabelNumberOfAttemps.AutoSize = true;
            LabelNumberOfAttemps.Location = new Point(79, 230);
            LabelNumberOfAttemps.Name = "LabelNumberOfAttemps";
            LabelNumberOfAttemps.Size = new Size(50, 20);
            LabelNumberOfAttemps.TabIndex = 49;
            LabelNumberOfAttemps.Text = "label1";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 397);
            Controls.Add(splitContainer1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(splitContainer1, 0);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private Label LabelNumberOfAttemps;
        private CheckBox CheckBoxShowPassWord;
    }
}