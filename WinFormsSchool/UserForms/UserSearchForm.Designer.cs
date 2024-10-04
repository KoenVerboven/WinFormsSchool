namespace WinFormsSchool
{
    partial class UserSearchForm
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
            DataGridViewUsers = new DataGridView();
            TextboxSearch = new TextBox();
            ButtonSearch = new Button();
            ButtonUpdateUser = new Button();
            ButtonInsertNewUser = new Button();
            ButtonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // LabelPageTitle
            // 
            LabelPageTitle.Font = new Font("Arial", 14F);
            LabelPageTitle.ForeColor = Color.White;
            LabelPageTitle.Size = new Size(171, 27);
            // 
            // DataGridViewUsers
            // 
            DataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewUsers.Location = new Point(39, 121);
            DataGridViewUsers.Name = "DataGridViewUsers";
            DataGridViewUsers.RowHeadersWidth = 51;
            DataGridViewUsers.Size = new Size(1045, 295);
            DataGridViewUsers.TabIndex = 43;
            DataGridViewUsers.CellDoubleClick += DataGridViewUsers_CellDoubleClick;
            // 
            // TextboxSearch
            // 
            TextboxSearch.Location = new Point(39, 65);
            TextboxSearch.Name = "TextboxSearch";
            TextboxSearch.Size = new Size(279, 27);
            TextboxSearch.TabIndex = 44;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(375, 65);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(171, 29);
            ButtonSearch.TabIndex = 45;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click_1;
            // 
            // ButtonUpdateUser
            // 
            ButtonUpdateUser.Location = new Point(741, 65);
            ButtonUpdateUser.Name = "ButtonUpdateUser";
            ButtonUpdateUser.Size = new Size(154, 29);
            ButtonUpdateUser.TabIndex = 48;
            ButtonUpdateUser.Text = "Update User";
            ButtonUpdateUser.UseVisualStyleBackColor = true;
            ButtonUpdateUser.Click += ButtonUpdateUser_Click;
            // 
            // ButtonInsertNewUser
            // 
            ButtonInsertNewUser.Location = new Point(569, 65);
            ButtonInsertNewUser.Name = "ButtonInsertNewUser";
            ButtonInsertNewUser.Size = new Size(154, 29);
            ButtonInsertNewUser.TabIndex = 47;
            ButtonInsertNewUser.Text = "Insert new User";
            ButtonInsertNewUser.UseVisualStyleBackColor = true;
            ButtonInsertNewUser.Click += ButtonInsertNewUser_Click;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(921, 66);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(124, 27);
            ButtonDelete.TabIndex = 46;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // UserSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 708);
            Controls.Add(ButtonUpdateUser);
            Controls.Add(ButtonInsertNewUser);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonSearch);
            Controls.Add(TextboxSearch);
            Controls.Add(DataGridViewUsers);
            Name = "UserSearchForm";
            Text = "UserAdministration";
            Controls.SetChildIndex(LabelPageTitle, 0);
            Controls.SetChildIndex(DataGridViewUsers, 0);
            Controls.SetChildIndex(TextboxSearch, 0);
            Controls.SetChildIndex(ButtonSearch, 0);
            Controls.SetChildIndex(ButtonDelete, 0);
            Controls.SetChildIndex(ButtonInsertNewUser, 0);
            Controls.SetChildIndex(ButtonUpdateUser, 0);
            ((System.ComponentModel.ISupportInitialize)DataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DataGridViewUsers;
        private TextBox TextboxSearch;
        private Button ButtonSearch;
        private Button ButtonUpdateUser;
        private Button ButtonInsertNewUser;
        private Button ButtonDelete;
    }
}