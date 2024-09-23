namespace WinFormsSchool.GeneralForms
{
    partial class CustomErrorForm
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
            LabelErrorMessage = new Label();
            LabelErrorMessageTitle = new Label();
            LabelPageOrFormNameTitle = new Label();
            LabelPageOrFormName = new Label();
            LabelMethodNameTitle = new Label();
            LabelMethodName = new Label();
            LabelErrorTimeTitle = new Label();
            LabelErrorTime = new Label();
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
            ButtonClose.Location = new Point(639, 263);
            ButtonClose.Name = "ButtonClose";
            ButtonClose.Size = new Size(94, 29);
            ButtonClose.TabIndex = 0;
            ButtonClose.Text = "Close";
            ButtonClose.UseVisualStyleBackColor = true;
            ButtonClose.Click += ButtonClose_Click;
            // 
            // LabelErrorMessage
            // 
            LabelErrorMessage.AutoSize = true;
            LabelErrorMessage.Location = new Point(43, 200);
            LabelErrorMessage.Name = "LabelErrorMessage";
            LabelErrorMessage.Size = new Size(99, 20);
            LabelErrorMessage.TabIndex = 1;
            LabelErrorMessage.Text = "ErrorMessage";
            // 
            // LabelErrorMessageTitle
            // 
            LabelErrorMessageTitle.AutoSize = true;
            LabelErrorMessageTitle.Location = new Point(43, 169);
            LabelErrorMessageTitle.Name = "LabelErrorMessageTitle";
            LabelErrorMessageTitle.Size = new Size(106, 20);
            LabelErrorMessageTitle.TabIndex = 2;
            LabelErrorMessageTitle.Text = "ErrorMessage :";
            // 
            // LabelPageOrFormNameTitle
            // 
            LabelPageOrFormNameTitle.AutoSize = true;
            LabelPageOrFormNameTitle.Location = new Point(43, 67);
            LabelPageOrFormNameTitle.Name = "LabelPageOrFormNameTitle";
            LabelPageOrFormNameTitle.Size = new Size(145, 20);
            LabelPageOrFormNameTitle.TabIndex = 42;
            LabelPageOrFormNameTitle.Text = "Page or Form name :";
            // 
            // LabelPageOrFormName
            // 
            LabelPageOrFormName.AutoSize = true;
            LabelPageOrFormName.Location = new Point(226, 67);
            LabelPageOrFormName.Name = "LabelPageOrFormName";
            LabelPageOrFormName.Size = new Size(167, 20);
            LabelPageOrFormName.TabIndex = 43;
            LabelPageOrFormName.Text = "LabelPageOrFormName";
            // 
            // LabelMethodNameTitle
            // 
            LabelMethodNameTitle.AutoSize = true;
            LabelMethodNameTitle.Location = new Point(43, 96);
            LabelMethodNameTitle.Name = "LabelMethodNameTitle";
            LabelMethodNameTitle.Size = new Size(108, 20);
            LabelMethodNameTitle.TabIndex = 44;
            LabelMethodNameTitle.Text = "MethodName :";
            // 
            // LabelMethodName
            // 
            LabelMethodName.AutoSize = true;
            LabelMethodName.Location = new Point(226, 96);
            LabelMethodName.Name = "LabelMethodName";
            LabelMethodName.Size = new Size(137, 20);
            LabelMethodName.TabIndex = 45;
            LabelMethodName.Text = "LabelMethodName";
            // 
            // LabelErrorTimeTitle
            // 
            LabelErrorTimeTitle.AutoSize = true;
            LabelErrorTimeTitle.Location = new Point(43, 126);
            LabelErrorTimeTitle.Name = "LabelErrorTimeTitle";
            LabelErrorTimeTitle.Size = new Size(85, 20);
            LabelErrorTimeTitle.TabIndex = 46;
            LabelErrorTimeTitle.Text = "Error Time :";
            // 
            // LabelErrorTime
            // 
            LabelErrorTime.AutoSize = true;
            LabelErrorTime.Location = new Point(226, 126);
            LabelErrorTime.Name = "LabelErrorTime";
            LabelErrorTime.Size = new Size(110, 20);
            LabelErrorTime.TabIndex = 47;
            LabelErrorTime.Text = "LabelErrorTime";
            // 
            // CustomErrorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 315);
            Controls.Add(LabelErrorTime);
            Controls.Add(LabelErrorTimeTitle);
            Controls.Add(LabelMethodName);
            Controls.Add(LabelMethodNameTitle);
            Controls.Add(LabelPageOrFormName);
            Controls.Add(LabelPageOrFormNameTitle);
            Controls.Add(LabelErrorMessageTitle);
            Controls.Add(LabelErrorMessage);
            Controls.Add(ButtonClose);
            Name = "CustomErrorForm";
            Text = "CustomErrorForm";
            Load += CustomErrorForm_Load;
            Controls.SetChildIndex(ButtonClose, 0);
            Controls.SetChildIndex(LabelErrorMessage, 0);
            Controls.SetChildIndex(LabelErrorMessageTitle, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(LabelPageOrFormNameTitle, 0);
            Controls.SetChildIndex(LabelPageOrFormName, 0);
            Controls.SetChildIndex(LabelMethodNameTitle, 0);
            Controls.SetChildIndex(LabelMethodName, 0);
            Controls.SetChildIndex(LabelErrorTimeTitle, 0);
            Controls.SetChildIndex(LabelErrorTime, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelErrorMessage;
        private Label LabelErrorMessageTitle;
        private Label LabelPageOrFormNameTitle;
        private Label LabelPageOrFormName;
        private Label LabelMethodNameTitle;
        private Label LabelMethodName;
        private Label LabelErrorTimeTitle;
        private Label LabelErrorTime;
    }
}