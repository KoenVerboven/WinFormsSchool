namespace WinFormsSchool
{
    partial class StudentSearchForm
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
            textboxSearch = new TextBox();
            buttonSearch = new Button();
            label1 = new Label();
            gridViewStudents = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            labelStudentsFound = new Label();
            ((System.ComponentModel.ISupportInitialize)gridViewStudents).BeginInit();
            SuspendLayout();
            // 
            // textboxSearch
            // 
            textboxSearch.Location = new Point(34, 68);
            textboxSearch.Name = "textboxSearch";
            textboxSearch.Size = new Size(279, 27);
            textboxSearch.TabIndex = 19;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(319, 68);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(171, 29);
            buttonSearch.TabIndex = 20;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(327, 20);
            label1.TabIndex = 21;
            label1.Text = "Give the full student name or a part of the name";
            // 
            // gridViewStudents
            // 
            gridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewStudents.Location = new Point(24, 142);
            gridViewStudents.Name = "gridViewStudents";
            gridViewStudents.RowHeadersWidth = 51;
            gridViewStudents.Size = new Size(764, 296);
            gridViewStudents.TabIndex = 22;
            gridViewStudents.CellDoubleClick += dgrStudents_CellDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 29);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 23;
            label2.Text = "You can also search on the PersonId";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 448);
            label3.Name = "label3";
            label3.Size = new Size(321, 20);
            label3.TabIndex = 24;
            label3.Text = "Double click on GridRow to open detailscreen  ";
            // 
            // labelStudentsFound
            // 
            labelStudentsFound.AutoSize = true;
            labelStudentsFound.Font = new Font("Segoe UI", 9F);
            labelStudentsFound.Location = new Point(34, 109);
            labelStudentsFound.Name = "labelStudentsFound";
            labelStudentsFound.Size = new Size(140, 20);
            labelStudentsFound.TabIndex = 25;
            labelStudentsFound.Text = "labelStudentsFound";
            // 
            // StudentSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 492);
            Controls.Add(labelStudentsFound);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gridViewStudents);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textboxSearch);
            Name = "StudentSearchForm";
            Text = "StudentSearchForm";
            ((System.ComponentModel.ISupportInitialize)gridViewStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textboxSearch;
        private Button buttonSearch;
        private Label label1;
        private DataGridView gridViewStudents;
        private Label label2;
        private Label label3;
        private Label labelStudentsFound;
    }
}