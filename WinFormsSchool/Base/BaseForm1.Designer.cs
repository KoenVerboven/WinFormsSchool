namespace WinFormsSchool.Base
{
    partial class BaseForm1
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
            LabelPageTitle = new Label();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.AutoSize = true;
            LabelPageTitle.Location = new Point(39, 9);
            LabelPageTitle.Name = "LabelPageTitle";
            LabelPageTitle.Size = new Size(106, 20);
            LabelPageTitle.TabIndex = 41;
            LabelPageTitle.Text = "LabelPageTitle";
            // 
            // BaseForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelPageTitle);
            Name = "BaseForm1";
            Text = "BaseForm1";
            Load += BaseForm1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label LabelPageTitle;
    }
}