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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(39, 234);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.Size = new Size(690, 360);
            textBoxInfo.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(39, 138);
            label3.Name = "label3";
            label3.Size = new Size(92, 30);
            label3.TabIndex = 44;
            label3.Text = "Belgium";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(39, 185);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 43;
            label2.Text = "Vosselaar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(39, 82);
            label1.Name = "label1";
            label1.Size = new Size(371, 35);
            label1.TabIndex = 42;
            label1.Text = "Programmed by Verboven Koen";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 624);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxInfo);
            Name = "InfoForm";
            Text = "InfoForm";
            Load += InfoForm_Load;
            Controls.SetChildIndex(textBoxInfo, 0);
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}