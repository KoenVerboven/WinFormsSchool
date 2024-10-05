namespace WinFormsSchool.UserForms
{
    partial class UserForm
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
            ButtonClose = new Button();
            LabelUserId = new Label();
            LabelUserName = new Label();
            LabelSecurityGroupId = new Label();
            LabelActiveFrom = new Label();
            LabelBlocked = new Label();
            LabelPersonId = new Label();
            TextBoxUserName = new TextBox();
            CheckBoxBlocked = new CheckBox();
            DateTimePickerActiveFrom = new DateTimePicker();
            TextBoxSecurityGroupId = new TextBox();
            TextBoxPersonId = new TextBox();
            ButtonCancel = new Button();
            ButtonSave = new Button();
            LabelUserIdValue = new Label();
            LabelErrorMessage = new Label();
            ButtonResetPassword = new Button();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // ButtonClose
            // 
            ButtonClose.Location = new Point(39, 62);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(94, 29);
            ButtonClose.TabIndex = 64;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelUserId
            // 
            LabelUserId.AutoSize = true;
            LabelUserId.Location = new Point(39, 152);
            LabelUserId.Name = "LabelUserId";
            LabelUserId.Size = new Size(58, 20);
            LabelUserId.TabIndex = 65;
            LabelUserId.Text = "UserId :";
            // 
            // LabelUserName
            // 
            LabelUserName.AutoSize = true;
            LabelUserName.Location = new Point(39, 200);
            LabelUserName.Name = "LabelUserName";
            LabelUserName.Size = new Size(78, 20);
            LabelUserName.TabIndex = 66;
            LabelUserName.Text = "UserName";
            // 
            // LabelSecurityGroupId
            // 
            LabelSecurityGroupId.AutoSize = true;
            LabelSecurityGroupId.Location = new Point(42, 245);
            LabelSecurityGroupId.Name = "LabelSecurityGroupId";
            LabelSecurityGroupId.Size = new Size(115, 20);
            LabelSecurityGroupId.TabIndex = 67;
            LabelSecurityGroupId.Text = "SecurityGroupId";
            // 
            // LabelActiveFrom
            // 
            LabelActiveFrom.AutoSize = true;
            LabelActiveFrom.Location = new Point(43, 291);
            LabelActiveFrom.Name = "LabelActiveFrom";
            LabelActiveFrom.Size = new Size(84, 20);
            LabelActiveFrom.TabIndex = 68;
            LabelActiveFrom.Text = "ActiveFrom";
            // 
            // LabelBlocked
            // 
            LabelBlocked.AutoSize = true;
            LabelBlocked.Location = new Point(47, 387);
            LabelBlocked.Name = "LabelBlocked";
            LabelBlocked.Size = new Size(62, 20);
            LabelBlocked.TabIndex = 69;
            LabelBlocked.Text = "Blocked";
            // 
            // LabelPersonId
            // 
            LabelPersonId.AutoSize = true;
            LabelPersonId.Location = new Point(44, 342);
            LabelPersonId.Name = "LabelPersonId";
            LabelPersonId.Size = new Size(65, 20);
            LabelPersonId.TabIndex = 70;
            LabelPersonId.Text = "PersonId";
            // 
            // TextBoxUserName
            // 
            TextBoxUserName.Location = new Point(179, 198);
            TextBoxUserName.Name = "TextBoxUserName";
            TextBoxUserName.Size = new Size(249, 27);
            TextBoxUserName.TabIndex = 71;
            // 
            // CheckBoxBlocked
            // 
            CheckBoxBlocked.AutoSize = true;
            CheckBoxBlocked.Location = new Point(175, 387);
            CheckBoxBlocked.Name = "CheckBoxBlocked";
            CheckBoxBlocked.Size = new Size(18, 17);
            CheckBoxBlocked.TabIndex = 72;
            CheckBoxBlocked.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerActiveFrom
            // 
            DateTimePickerActiveFrom.Location = new Point(175, 290);
            DateTimePickerActiveFrom.Name = "DateTimePickerActiveFrom";
            DateTimePickerActiveFrom.Size = new Size(250, 27);
            DateTimePickerActiveFrom.TabIndex = 73;
            // 
            // TextBoxSecurityGroupId
            // 
            TextBoxSecurityGroupId.Location = new Point(179, 245);
            TextBoxSecurityGroupId.Name = "TextBoxSecurityGroupId";
            TextBoxSecurityGroupId.Size = new Size(246, 27);
            TextBoxSecurityGroupId.TabIndex = 74;
            // 
            // TextBoxPersonId
            // 
            TextBoxPersonId.Location = new Point(175, 339);
            TextBoxPersonId.Name = "TextBoxPersonId";
            TextBoxPersonId.Size = new Size(250, 27);
            TextBoxPersonId.TabIndex = 75;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(266, 62);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(57, 29);
            ButtonCancel.TabIndex = 77;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Visible = false;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(195, 61);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(56, 30);
            ButtonSave.TabIndex = 76;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Visible = false;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // LabelUserIdValue
            // 
            LabelUserIdValue.AutoSize = true;
            LabelUserIdValue.Location = new Point(179, 152);
            LabelUserIdValue.Name = "LabelUserIdValue";
            LabelUserIdValue.Size = new Size(87, 20);
            LabelUserIdValue.TabIndex = 78;
            LabelUserIdValue.Text = "UserIdValue";
            // 
            // LabelErrorMessage
            // 
            LabelErrorMessage.AutoSize = true;
            LabelErrorMessage.Location = new Point(503, 71);
            LabelErrorMessage.Name = "LabelErrorMessage";
            LabelErrorMessage.Size = new Size(99, 20);
            LabelErrorMessage.TabIndex = 79;
            LabelErrorMessage.Text = "ErrorMessage";
            // 
            // ButtonResetPassword
            // 
            ButtonResetPassword.Location = new Point(172, 441);
            ButtonResetPassword.Name = "ButtonResetPassword";
            ButtonResetPassword.Size = new Size(253, 29);
            ButtonResetPassword.TabIndex = 80;
            ButtonResetPassword.Text = "Reset Password";
            ButtonResetPassword.UseVisualStyleBackColor = true;
            ButtonResetPassword.Click += ButtonResetPassword_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 510);
            Controls.Add(ButtonResetPassword);
            Controls.Add(LabelErrorMessage);
            Controls.Add(LabelUserIdValue);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonSave);
            Controls.Add(TextBoxPersonId);
            Controls.Add(TextBoxSecurityGroupId);
            Controls.Add(DateTimePickerActiveFrom);
            Controls.Add(CheckBoxBlocked);
            Controls.Add(TextBoxUserName);
            Controls.Add(LabelPersonId);
            Controls.Add(LabelBlocked);
            Controls.Add(LabelActiveFrom);
            Controls.Add(LabelSecurityGroupId);
            Controls.Add(LabelUserName);
            Controls.Add(LabelUserId);
            Controls.Add(ButtonClose);
            Name = "UserForm";
            Text = "UserForm";
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(ButtonClose, 0);
            Controls.SetChildIndex(LabelUserId, 0);
            Controls.SetChildIndex(LabelUserName, 0);
            Controls.SetChildIndex(LabelSecurityGroupId, 0);
            Controls.SetChildIndex(LabelActiveFrom, 0);
            Controls.SetChildIndex(LabelBlocked, 0);
            Controls.SetChildIndex(LabelPersonId, 0);
            Controls.SetChildIndex(TextBoxUserName, 0);
            Controls.SetChildIndex(CheckBoxBlocked, 0);
            Controls.SetChildIndex(DateTimePickerActiveFrom, 0);
            Controls.SetChildIndex(TextBoxSecurityGroupId, 0);
            Controls.SetChildIndex(TextBoxPersonId, 0);
            Controls.SetChildIndex(ButtonSave, 0);
            Controls.SetChildIndex(ButtonCancel, 0);
            Controls.SetChildIndex(LabelUserIdValue, 0);
            Controls.SetChildIndex(LabelErrorMessage, 0);
            Controls.SetChildIndex(ButtonResetPassword, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelUserId;
        private Label LabelUserName;
        private Label LabelSecurityGroupId;
        private Label LabelActiveFrom;
        private Label LabelBlocked;
        private Label LabelPersonId;
        private TextBox TextBoxUserName;
        private CheckBox CheckBoxBlocked;
        private DateTimePicker DateTimePickerActiveFrom;
        private TextBox TextBoxSecurityGroupId;
        private TextBox TextBoxPersonId;
        public Button ButtonCancel;
        public Button ButtonSave;
        private Label LabelUserIdValue;
        private Label LabelErrorMessage;
        private Button ButtonResetPassword;
    }
}