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
            TextBoxUserName = new TextBox();
            TextBoxPassWord = new TextBox();
            labelMessage = new Label();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            CheckBoxShowPassWord = new CheckBox();
            LabelNumberOfAttemps = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            ButtonLogin.Location = new Point(245, 249);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(123, 29);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "LogIn";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // TextBoxUserName
            // 
            TextBoxUserName.Location = new Point(111, 60);
            TextBoxUserName.Name = "TextBoxUserName";
            TextBoxUserName.Size = new Size(266, 27);
            TextBoxUserName.TabIndex = 45;
            // 
            // TextBoxPassWord
            // 
            TextBoxPassWord.Location = new Point(112, 111);
            TextBoxPassWord.Name = "TextBoxPassWord";
            TextBoxPassWord.Size = new Size(265, 27);
            TextBoxPassWord.TabIndex = 46;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(59, 210);
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
            splitContainer1.Panel2.Controls.Add(pictureBox2);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(CheckBoxShowPassWord);
            splitContainer1.Panel2.Controls.Add(LabelNumberOfAttemps);
            splitContainer1.Panel2.Controls.Add(labelMessage);
            splitContainer1.Panel2.Controls.Add(ButtonLogin);
            splitContainer1.Panel2.Controls.Add(TextBoxPassWord);
            splitContainer1.Panel2.Controls.Add(TextBoxUserName);
            splitContainer1.Size = new Size(781, 397);
            splitContainer1.SplitterDistance = 260;
            splitContainer1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.key1;
            pictureBox1.Location = new Point(59, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 35);
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // CheckBoxShowPassWord
            // 
            CheckBoxShowPassWord.AutoSize = true;
            CheckBoxShowPassWord.ForeColor = Color.Cornsilk;
            CheckBoxShowPassWord.Location = new Point(112, 156);
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
            LabelNumberOfAttemps.Location = new Point(59, 230);
            LabelNumberOfAttemps.Name = "LabelNumberOfAttemps";
            LabelNumberOfAttemps.Size = new Size(50, 20);
            LabelNumberOfAttemps.TabIndex = 49;
            LabelNumberOfAttemps.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user2;
            pictureBox2.Location = new Point(59, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 45);
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonLogin;
        private TextBox TextBoxUserName;
        private TextBox TextBoxPassWord;
        private Label labelMessage;
        private SplitContainer splitContainer1;
        private Label LabelNumberOfAttemps;
        private CheckBox CheckBoxShowPassWord;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}