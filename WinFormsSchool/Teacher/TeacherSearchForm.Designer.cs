namespace WinFormsSchool
{
    partial class TeacherSearchForm
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
            gridViewTeachers = new DataGridView();
            label1 = new Label();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            label3 = new Label();
            labelTeachersFound = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // gridViewTeachers
            // 
            gridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewTeachers.Location = new Point(79, 157);
            gridViewTeachers.Name = "gridViewTeachers";
            gridViewTeachers.RowHeadersWidth = 51;
            gridViewTeachers.Size = new Size(643, 296);
            gridViewTeachers.TabIndex = 26;
            gridViewTeachers.CellDoubleClick += gridViewTeachers_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 20);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 25;
            label1.Text = "Give the full teacher name or a part of the name";
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(383, 74);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 29);
            buttonSearch.TabIndex = 24;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(89, 76);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(279, 27);
            textBoxSearch.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 456);
            label3.Name = "label3";
            label3.Size = new Size(321, 20);
            label3.TabIndex = 27;
            label3.Text = "Dubbel click on GridRow to open detailscreen  ";
            // 
            // labelTeachersFound
            // 
            labelTeachersFound.AutoSize = true;
            labelTeachersFound.Location = new Point(90, 117);
            labelTeachersFound.Name = "labelTeachersFound";
            labelTeachersFound.Size = new Size(140, 20);
            labelTeachersFound.TabIndex = 28;
            labelTeachersFound.Text = "labelTeachersFound";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 40);
            label2.Name = "label2";
            label2.Size = new Size(251, 20);
            label2.TabIndex = 29;
            label2.Text = "You can also search on the TeacherId";
            // 
            // TeacherSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(label2);
            Controls.Add(labelTeachersFound);
            Controls.Add(label3);
            Controls.Add(gridViewTeachers);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Name = "TeacherSearchForm";
            Text = "TeacherSearchForm";
            ((System.ComponentModel.ISupportInitialize)gridViewTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridViewTeachers;
        private Label label1;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label label3;
        private Label labelTeachersFound;
        private Label label2;
    }
}