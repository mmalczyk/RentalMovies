namespace RentalMovies
{
    partial class Users
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
            this.label18 = new System.Windows.Forms.Label();
            this.UserResetButton = new System.Windows.Forms.Button();
            this.SortUserByJobDesc = new System.Windows.Forms.RadioButton();
            this.SortUserBySurnameDesc = new System.Windows.Forms.RadioButton();
            this.SortUserByNameDesc = new System.Windows.Forms.RadioButton();
            this.SortUserByJobAsc = new System.Windows.Forms.RadioButton();
            this.SortUserBySurnameAsc = new System.Windows.Forms.RadioButton();
            this.SortUserByNameAsc = new System.Windows.Forms.RadioButton();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserPasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.UserLoginTextBox2 = new System.Windows.Forms.TextBox();
            this.UserSurnameTextBox2 = new System.Windows.Forms.TextBox();
            this.UserNameTextBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.UserIDTextBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.UsersListView = new System.Windows.Forms.ListView();
            this.UserJobTextBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.Location = new System.Drawing.Point(668, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 20);
            this.label18.TabIndex = 93;
            this.label18.Text = "Rola:";
            // 
            // UserResetButton
            // 
            this.UserResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserResetButton.Location = new System.Drawing.Point(1100, 50);
            this.UserResetButton.Name = "UserResetButton";
            this.UserResetButton.Size = new System.Drawing.Size(113, 48);
            this.UserResetButton.TabIndex = 92;
            this.UserResetButton.Text = "Reset";
            this.UserResetButton.UseVisualStyleBackColor = true;
            this.UserResetButton.Click += new System.EventHandler(this.UserResetButton_Click);
            // 
            // SortUserByJobDesc
            // 
            this.SortUserByJobDesc.AutoSize = true;
            this.SortUserByJobDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortUserByJobDesc.Location = new System.Drawing.Point(941, 480);
            this.SortUserByJobDesc.Name = "SortUserByJobDesc";
            this.SortUserByJobDesc.Size = new System.Drawing.Size(82, 24);
            this.SortUserByJobDesc.TabIndex = 91;
            this.SortUserByJobDesc.TabStop = true;
            this.SortUserByJobDesc.Text = "> po roli";
            this.SortUserByJobDesc.UseVisualStyleBackColor = true;
            this.SortUserByJobDesc.Click += new System.EventHandler(this.SortUserByJobDesc_CheckedChanged);
            // 
            // SortUserBySurnameDesc
            // 
            this.SortUserBySurnameDesc.AutoSize = true;
            this.SortUserBySurnameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortUserBySurnameDesc.Location = new System.Drawing.Point(941, 427);
            this.SortUserBySurnameDesc.Name = "SortUserBySurnameDesc";
            this.SortUserBySurnameDesc.Size = new System.Drawing.Size(127, 24);
            this.SortUserBySurnameDesc.TabIndex = 90;
            this.SortUserBySurnameDesc.TabStop = true;
            this.SortUserBySurnameDesc.Text = "> po nazwisku";
            this.SortUserBySurnameDesc.UseVisualStyleBackColor = true;
            this.SortUserBySurnameDesc.Click += new System.EventHandler(this.SortUserBySurnameDesc_CheckedChanged);
            // 
            // SortUserByNameDesc
            // 
            this.SortUserByNameDesc.AutoSize = true;
            this.SortUserByNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortUserByNameDesc.Location = new System.Drawing.Point(941, 366);
            this.SortUserByNameDesc.Name = "SortUserByNameDesc";
            this.SortUserByNameDesc.Size = new System.Drawing.Size(111, 24);
            this.SortUserByNameDesc.TabIndex = 89;
            this.SortUserByNameDesc.TabStop = true;
            this.SortUserByNameDesc.Text = "> po imieniu";
            this.SortUserByNameDesc.UseVisualStyleBackColor = true;
            this.SortUserByNameDesc.Click += new System.EventHandler(this.SortUserByNameDesc_CheckedChanged);
            // 
            // SortUserByJobAsc
            // 
            this.SortUserByJobAsc.AutoSize = true;
            this.SortUserByJobAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortUserByJobAsc.Location = new System.Drawing.Point(775, 480);
            this.SortUserByJobAsc.Name = "SortUserByJobAsc";
            this.SortUserByJobAsc.Size = new System.Drawing.Size(82, 24);
            this.SortUserByJobAsc.TabIndex = 88;
            this.SortUserByJobAsc.TabStop = true;
            this.SortUserByJobAsc.Text = "< po roli";
            this.SortUserByJobAsc.UseVisualStyleBackColor = true;
            this.SortUserByJobAsc.Click += new System.EventHandler(this.SortUserByJobAsc_CheckedChanged);
            // 
            // SortUserBySurnameAsc
            // 
            this.SortUserBySurnameAsc.AutoSize = true;
            this.SortUserBySurnameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortUserBySurnameAsc.Location = new System.Drawing.Point(775, 427);
            this.SortUserBySurnameAsc.Name = "SortUserBySurnameAsc";
            this.SortUserBySurnameAsc.Size = new System.Drawing.Size(127, 24);
            this.SortUserBySurnameAsc.TabIndex = 87;
            this.SortUserBySurnameAsc.TabStop = true;
            this.SortUserBySurnameAsc.Text = "< po nazwisku";
            this.SortUserBySurnameAsc.UseVisualStyleBackColor = true;
            this.SortUserBySurnameAsc.Click += new System.EventHandler(this.SortUserBySurnameAsc_CheckedChanged);
            // 
            // SortUserByNameAsc
            // 
            this.SortUserByNameAsc.AutoSize = true;
            this.SortUserByNameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortUserByNameAsc.Location = new System.Drawing.Point(775, 366);
            this.SortUserByNameAsc.Name = "SortUserByNameAsc";
            this.SortUserByNameAsc.Size = new System.Drawing.Size(111, 24);
            this.SortUserByNameAsc.TabIndex = 86;
            this.SortUserByNameAsc.TabStop = true;
            this.SortUserByNameAsc.Text = "< po imieniu";
            this.SortUserByNameAsc.UseVisualStyleBackColor = true;
            this.SortUserByNameAsc.Click += new System.EventHandler(this.SortUserByNameAsc_CheckedChanged);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditUserButton.Location = new System.Drawing.Point(1100, 254);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(113, 48);
            this.EditUserButton.TabIndex = 85;
            this.EditUserButton.Text = "Zatwierdź";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteUserButton.Location = new System.Drawing.Point(1100, 187);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteUserButton.TabIndex = 84;
            this.DeleteUserButton.Text = "Usuń";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddUserButton.Location = new System.Drawing.Point(1100, 117);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(113, 48);
            this.AddUserButton.TabIndex = 83;
            this.AddUserButton.Text = "Dodaj";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserPasswordTextBox2
            // 
            this.UserPasswordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserPasswordTextBox2.Location = new System.Drawing.Point(800, 233);
            this.UserPasswordTextBox2.Name = "UserPasswordTextBox2";
            this.UserPasswordTextBox2.Size = new System.Drawing.Size(229, 26);
            this.UserPasswordTextBox2.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(668, 239);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 81;
            this.label13.Text = "Hasło:";
            // 
            // UserLoginTextBox2
            // 
            this.UserLoginTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserLoginTextBox2.Location = new System.Drawing.Point(800, 187);
            this.UserLoginTextBox2.Name = "UserLoginTextBox2";
            this.UserLoginTextBox2.Size = new System.Drawing.Size(229, 26);
            this.UserLoginTextBox2.TabIndex = 80;
            // 
            // UserSurnameTextBox2
            // 
            this.UserSurnameTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserSurnameTextBox2.Location = new System.Drawing.Point(800, 140);
            this.UserSurnameTextBox2.Name = "UserSurnameTextBox2";
            this.UserSurnameTextBox2.Size = new System.Drawing.Size(229, 26);
            this.UserSurnameTextBox2.TabIndex = 79;
            // 
            // UserNameTextBox2
            // 
            this.UserNameTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserNameTextBox2.Location = new System.Drawing.Point(800, 93);
            this.UserNameTextBox2.Name = "UserNameTextBox2";
            this.UserNameTextBox2.Size = new System.Drawing.Size(229, 26);
            this.UserNameTextBox2.TabIndex = 78;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(668, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 77;
            this.label14.Text = "Login:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(668, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 76;
            this.label15.Text = "Nazwisko:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(668, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 75;
            this.label16.Text = "Imię:";
            // 
            // UserIDTextBox2
            // 
            this.UserIDTextBox2.Enabled = false;
            this.UserIDTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserIDTextBox2.Location = new System.Drawing.Point(800, 45);
            this.UserIDTextBox2.Name = "UserIDTextBox2";
            this.UserIDTextBox2.Size = new System.Drawing.Size(77, 26);
            this.UserIDTextBox2.TabIndex = 74;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.Location = new System.Drawing.Point(668, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 20);
            this.label17.TabIndex = 73;
            this.label17.Text = "ID pracownika:";
            // 
            // UsersListView
            // 
            this.UsersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsersListView.FullRowSelect = true;
            this.UsersListView.HideSelection = false;
            this.UsersListView.Location = new System.Drawing.Point(57, 28);
            this.UsersListView.Name = "UsersListView";
            this.UsersListView.Size = new System.Drawing.Size(509, 558);
            this.UsersListView.TabIndex = 72;
            this.UsersListView.UseCompatibleStateImageBehavior = false;
            this.UsersListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.UsersListView_ItemSelectionChanged);
            // 
            // UserJobTextBox2
            // 
            this.UserJobTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UserJobTextBox2.FormattingEnabled = true;
            this.UserJobTextBox2.ItemHeight = 20;
            this.UserJobTextBox2.Location = new System.Drawing.Point(800, 285);
            this.UserJobTextBox2.Name = "UserJobTextBox2";
            this.UserJobTextBox2.Size = new System.Drawing.Size(136, 24);
            this.UserJobTextBox2.TabIndex = 95;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 641);
            this.Controls.Add(this.UserJobTextBox2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.UserResetButton);
            this.Controls.Add(this.SortUserByJobDesc);
            this.Controls.Add(this.SortUserBySurnameDesc);
            this.Controls.Add(this.SortUserByNameDesc);
            this.Controls.Add(this.SortUserByJobAsc);
            this.Controls.Add(this.SortUserBySurnameAsc);
            this.Controls.Add(this.SortUserByNameAsc);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UserPasswordTextBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UserLoginTextBox2);
            this.Controls.Add(this.UserSurnameTextBox2);
            this.Controls.Add(this.UserNameTextBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.UserIDTextBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.UsersListView);
            this.Name = "Users";
            this.Text = "Pracownicy";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Button UserResetButton;
        public System.Windows.Forms.RadioButton SortUserByJobDesc;
        public System.Windows.Forms.RadioButton SortUserBySurnameDesc;
        public System.Windows.Forms.RadioButton SortUserByNameDesc;
        public System.Windows.Forms.RadioButton SortUserByJobAsc;
        public System.Windows.Forms.RadioButton SortUserBySurnameAsc;
        public System.Windows.Forms.RadioButton SortUserByNameAsc;
        public System.Windows.Forms.Button EditUserButton;
        public System.Windows.Forms.Button DeleteUserButton;
        public System.Windows.Forms.Button AddUserButton;
        public System.Windows.Forms.TextBox UserPasswordTextBox2;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox UserLoginTextBox2;
        public System.Windows.Forms.TextBox UserSurnameTextBox2;
        public System.Windows.Forms.TextBox UserNameTextBox2;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox UserIDTextBox2;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.ListView UsersListView;
        private System.Windows.Forms.ListBox UserJobTextBox2;
    }
}