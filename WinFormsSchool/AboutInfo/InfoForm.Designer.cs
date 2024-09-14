namespace WinFormsSchool
{
    partial class InfoForm
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
            textBoxInfo = new TextBox();
            SuspendLayout();
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(53, 51);
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(656, 27);
            textBoxInfo.TabIndex = 0;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 408);
            Controls.Add(textBoxInfo);
            Name = "InfoForm";
            Text = "InfoForm";
            Load += InfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo;
    }
}