namespace RentalMovies
{
    partial class MainForm
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
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.TagsButton = new System.Windows.Forms.Button();
            this.MyAccountButton = new System.Windows.Forms.Button();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(632, 243);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.loginErrorLabel.TabIndex = 18;
            // 
            // logoutButton
            // 
            this.logoutButton.Enabled = false;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.logoutButton.Location = new System.Drawing.Point(787, 464);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(107, 38);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginButton.Location = new System.Drawing.Point(787, 408);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(107, 38);
            this.loginButton.TabIndex = 16;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.passwordTextBox.Location = new System.Drawing.Point(636, 348);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(162, 26);
            this.passwordTextBox.TabIndex = 15;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loginTextBox.Location = new System.Drawing.Point(636, 286);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(162, 26);
            this.loginTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(540, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(543, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Login:";
            // 
            // CustomersButton
            // 
            this.CustomersButton.Enabled = false;
            this.CustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomersButton.Location = new System.Drawing.Point(291, 46);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(169, 66);
            this.CustomersButton.TabIndex = 20;
            this.CustomersButton.Text = "Klienci";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // MoviesButton
            // 
            this.MoviesButton.Enabled = false;
            this.MoviesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MoviesButton.Location = new System.Drawing.Point(58, 46);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(169, 66);
            this.MoviesButton.TabIndex = 19;
            this.MoviesButton.Text = "Filmy";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Enabled = false;
            this.UsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UsersButton.Location = new System.Drawing.Point(766, 46);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(169, 66);
            this.UsersButton.TabIndex = 22;
            this.UsersButton.Text = "Użytkownicy";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // TagsButton
            // 
            this.TagsButton.Enabled = false;
            this.TagsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TagsButton.Location = new System.Drawing.Point(533, 46);
            this.TagsButton.Name = "TagsButton";
            this.TagsButton.Size = new System.Drawing.Size(169, 66);
            this.TagsButton.TabIndex = 21;
            this.TagsButton.Text = "Tagi";
            this.TagsButton.UseVisualStyleBackColor = true;
            this.TagsButton.Click += new System.EventHandler(this.TagsButton_Click);
            // 
            // MyAccountButton
            // 
            this.MyAccountButton.Enabled = false;
            this.MyAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MyAccountButton.Location = new System.Drawing.Point(1233, 46);
            this.MyAccountButton.Name = "MyAccountButton";
            this.MyAccountButton.Size = new System.Drawing.Size(169, 66);
            this.MyAccountButton.TabIndex = 24;
            this.MyAccountButton.Text = "Moje konto";
            this.MyAccountButton.UseVisualStyleBackColor = true;
            this.MyAccountButton.Click += new System.EventHandler(this.MyAccountButton_Click);
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.Enabled = false;
            this.AdministrationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdministrationButton.Location = new System.Drawing.Point(1000, 46);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Size = new System.Drawing.Size(169, 66);
            this.AdministrationButton.TabIndex = 23;
            this.AdministrationButton.Text = "Zarządzanie";
            this.AdministrationButton.UseVisualStyleBackColor = true;
            this.AdministrationButton.Click += new System.EventHandler(this.AdministrationButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 720);
            this.Controls.Add(this.MyAccountButton);
            this.Controls.Add(this.AdministrationButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.TagsButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.MoviesButton);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Wypożyczalnia filmów";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label loginErrorLabel;
        public System.Windows.Forms.Button logoutButton;
        public System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox loginTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button TagsButton;
        private System.Windows.Forms.Button MyAccountButton;
        private System.Windows.Forms.Button AdministrationButton;
    }
}

