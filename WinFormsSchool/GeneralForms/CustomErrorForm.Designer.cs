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
            ButtonClose.Location = new Point(515, 217);
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
            LabelErrorMessage.Location = new Point(43, 106);
            LabelErrorMessage.Name = "LabelErrorMessage";
            LabelErrorMessage.Size = new Size(99, 20);
            LabelErrorMessage.TabIndex = 1;
            LabelErrorMessage.Text = "ErrorMessage";
            // 
            // LabelErrorTimeTitle
            // 
            LabelErrorTimeTitle.AutoSize = true;
            LabelErrorTimeTitle.Location = new Point(43, 54);
            LabelErrorTimeTitle.Name = "LabelErrorTimeTitle";
            LabelErrorTimeTitle.Size = new Size(49, 20);
            LabelErrorTimeTitle.TabIndex = 46;
            LabelErrorTimeTitle.Text = "Time :";
            // 
            // LabelErrorTime
            // 
            LabelErrorTime.AutoSize = true;
            LabelErrorTime.Location = new Point(200, 54);
            LabelErrorTime.Name = "LabelErrorTime";
            LabelErrorTime.Size = new Size(110, 20);
            LabelErrorTime.TabIndex = 47;
            LabelErrorTime.Text = "LabelErrorTime";
            // 
            // CustomErrorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 273);
            Controls.Add(LabelErrorTime);
            Controls.Add(LabelErrorTimeTitle);
            Controls.Add(LabelErrorMessage);
            Controls.Add(ButtonClose);
            Name = "CustomErrorForm";
            Text = "CustomErrorForm";
            Load += CustomErrorForm_Load;
            Controls.SetChildIndex(ButtonClose, 0);
            Controls.SetChildIndex(LabelErrorMessage, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(LabelErrorTimeTitle, 0);
            Controls.SetChildIndex(LabelErrorTime, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonClose;
        private Label LabelErrorMessage;
        private Label LabelErrorTimeTitle;
        private Label LabelErrorTime;
    }
}