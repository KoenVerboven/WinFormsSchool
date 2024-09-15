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
            GridViewTeachers = new DataGridView();
            label1 = new Label();
            ButtonSearch = new Button();
            TextBoxSearch = new TextBox();
            LabelDoubleClickGrid = new Label();
            LabelTeachersFound = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // GridViewTeachers
            // 
            GridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewTeachers.Location = new Point(79, 157);
            GridViewTeachers.Name = "GridViewTeachers";
            GridViewTeachers.RowHeadersWidth = 51;
            GridViewTeachers.Size = new Size(643, 296);
            GridViewTeachers.TabIndex = 26;
            GridViewTeachers.CellDoubleClick += gridViewTeachers_CellDoubleClick;
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
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(383, 74);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(171, 29);
            ButtonSearch.TabIndex = 24;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TextBoxSearch
            // 
            TextBoxSearch.Location = new Point(89, 76);
            TextBoxSearch.Name = "TextBoxSearch";
            TextBoxSearch.Size = new Size(279, 27);
            TextBoxSearch.TabIndex = 23;
            // 
            // LabelDoubleClickGrid
            // 
            LabelDoubleClickGrid.AutoSize = true;
            LabelDoubleClickGrid.Location = new Point(79, 456);
            LabelDoubleClickGrid.Name = "LabelDoubleClickGrid";
            LabelDoubleClickGrid.Size = new Size(321, 20);
            LabelDoubleClickGrid.TabIndex = 27;
            LabelDoubleClickGrid.Text = "Double click on GridRow to open detailscreen  ";
            // 
            // LabelTeachersFound
            // 
            LabelTeachersFound.AutoSize = true;
            LabelTeachersFound.Location = new Point(90, 117);
            LabelTeachersFound.Name = "LabelTeachersFound";
            LabelTeachersFound.Size = new Size(140, 20);
            LabelTeachersFound.TabIndex = 28;
            LabelTeachersFound.Text = "labelTeachersFound";
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
            Controls.Add(LabelTeachersFound);
            Controls.Add(LabelDoubleClickGrid);
            Controls.Add(GridViewTeachers);
            Controls.Add(label1);
            Controls.Add(ButtonSearch);
            Controls.Add(TextBoxSearch);
            Name = "TeacherSearchForm";
            Text = "TeacherSearchForm";
            ((System.ComponentModel.ISupportInitialize)GridViewTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridViewTeachers;
        private Label label1;
        private Button ButtonSearch;
        private TextBox TextBoxSearch;
        private Label LabelDoubleClickGrid;
        private Label LabelTeachersFound;
        private Label label2;
    }
}