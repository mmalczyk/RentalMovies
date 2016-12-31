namespace RentalMovies
{
    partial class Customers
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
            this.CustomersListView = new System.Windows.Forms.ListView();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SortByNameAsc = new System.Windows.Forms.RadioButton();
            this.SortBySurnameAsc = new System.Windows.Forms.RadioButton();
            this.SortByNameDesc = new System.Windows.Forms.RadioButton();
            this.SortBySurnameDesc = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.PeselTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.BorrowButton = new System.Windows.Forms.Button();
            this.FindCustomersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomersListView
            // 
            this.CustomersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CustomersListView.FullRowSelect = true;
            this.CustomersListView.HideSelection = false;
            this.CustomersListView.Location = new System.Drawing.Point(29, 26);
            this.CustomersListView.Name = "CustomersListView";
            this.CustomersListView.Size = new System.Drawing.Size(735, 558);
            this.CustomersListView.TabIndex = 73;
            this.CustomersListView.UseCompatibleStateImageBehavior = false;
            this.CustomersListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CustomersListView_ItemSelectionChanged);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.Location = new System.Drawing.Point(1248, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 48);
            this.AddButton.TabIndex = 93;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(1248, 178);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteButton.TabIndex = 94;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditButton.Location = new System.Drawing.Point(1248, 245);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 48);
            this.EditButton.TabIndex = 95;
            this.EditButton.Text = "Zatwierdź";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResetButton.Location = new System.Drawing.Point(1248, 41);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(113, 48);
            this.ResetButton.TabIndex = 96;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SortByNameAsc
            // 
            this.SortByNameAsc.AutoSize = true;
            this.SortByNameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortByNameAsc.Location = new System.Drawing.Point(807, 325);
            this.SortByNameAsc.Name = "SortByNameAsc";
            this.SortByNameAsc.Size = new System.Drawing.Size(111, 24);
            this.SortByNameAsc.TabIndex = 97;
            this.SortByNameAsc.TabStop = true;
            this.SortByNameAsc.Text = "< po imieniu";
            this.SortByNameAsc.UseVisualStyleBackColor = true;
            this.SortByNameAsc.Click += new System.EventHandler(this.SortByNameAsc_CheckedChanged);
            // 
            // SortBySurnameAsc
            // 
            this.SortBySurnameAsc.AutoSize = true;
            this.SortBySurnameAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortBySurnameAsc.Location = new System.Drawing.Point(807, 365);
            this.SortBySurnameAsc.Name = "SortBySurnameAsc";
            this.SortBySurnameAsc.Size = new System.Drawing.Size(127, 24);
            this.SortBySurnameAsc.TabIndex = 98;
            this.SortBySurnameAsc.TabStop = true;
            this.SortBySurnameAsc.Text = "< po nazwisku";
            this.SortBySurnameAsc.UseVisualStyleBackColor = true;
            this.SortBySurnameAsc.Click += new System.EventHandler(this.SortBySurnameAsc_CheckedChanged);
            // 
            // SortByNameDesc
            // 
            this.SortByNameDesc.AutoSize = true;
            this.SortByNameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortByNameDesc.Location = new System.Drawing.Point(973, 325);
            this.SortByNameDesc.Name = "SortByNameDesc";
            this.SortByNameDesc.Size = new System.Drawing.Size(111, 24);
            this.SortByNameDesc.TabIndex = 100;
            this.SortByNameDesc.TabStop = true;
            this.SortByNameDesc.Text = "> po imieniu";
            this.SortByNameDesc.UseVisualStyleBackColor = true;
            this.SortByNameDesc.Click += new System.EventHandler(this.SortByNameDesc_CheckedChanged);
            // 
            // SortBySurnameDesc
            // 
            this.SortBySurnameDesc.AutoSize = true;
            this.SortBySurnameDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortBySurnameDesc.Location = new System.Drawing.Point(973, 365);
            this.SortBySurnameDesc.Name = "SortBySurnameDesc";
            this.SortBySurnameDesc.Size = new System.Drawing.Size(127, 24);
            this.SortBySurnameDesc.TabIndex = 101;
            this.SortBySurnameDesc.TabStop = true;
            this.SortBySurnameDesc.Text = "> po nazwisku";
            this.SortBySurnameDesc.UseVisualStyleBackColor = true;
            this.SortBySurnameDesc.Click += new System.EventHandler(this.SortBySurnameDesc_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(803, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 105;
            this.label16.Text = "Imię:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(803, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 20);
            this.label15.TabIndex = 106;
            this.label15.Text = "Nazwisko:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(803, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 107;
            this.label14.Text = "PESEL:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NameTextBox.Location = new System.Drawing.Point(935, 61);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(229, 26);
            this.NameTextBox.TabIndex = 108;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SurnameTextBox.Location = new System.Drawing.Point(935, 108);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(229, 26);
            this.SurnameTextBox.TabIndex = 109;
            // 
            // PeselTextBox
            // 
            this.PeselTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PeselTextBox.Location = new System.Drawing.Point(935, 155);
            this.PeselTextBox.Name = "PeselTextBox";
            this.PeselTextBox.Size = new System.Drawing.Size(229, 26);
            this.PeselTextBox.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(803, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 111;
            this.label13.Text = "Nr tel:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PhoneTextBox.Location = new System.Drawing.Point(935, 201);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(229, 26);
            this.PhoneTextBox.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(803, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Adres:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddressTextBox.Location = new System.Drawing.Point(935, 245);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(229, 26);
            this.AddressTextBox.TabIndex = 114;
            // 
            // BorrowButton
            // 
            this.BorrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BorrowButton.Location = new System.Drawing.Point(1173, 428);
            this.BorrowButton.Name = "BorrowButton";
            this.BorrowButton.Size = new System.Drawing.Size(188, 93);
            this.BorrowButton.TabIndex = 119;
            this.BorrowButton.Text = "Wypożyczone";
            this.BorrowButton.UseVisualStyleBackColor = true;
            this.BorrowButton.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // FindCustomersButton
            // 
            this.FindCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FindCustomersButton.Location = new System.Drawing.Point(898, 428);
            this.FindCustomersButton.Name = "FindCustomersButton";
            this.FindCustomersButton.Size = new System.Drawing.Size(186, 93);
            this.FindCustomersButton.TabIndex = 122;
            this.FindCustomersButton.Text = "Znajdź";
            this.FindCustomersButton.UseVisualStyleBackColor = true;
            this.FindCustomersButton.Click += new System.EventHandler(this.FindCustomersButton_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 613);
            this.Controls.Add(this.FindCustomersButton);
            this.Controls.Add(this.BorrowButton);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PeselTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SortBySurnameDesc);
            this.Controls.Add(this.SortByNameDesc);
            this.Controls.Add(this.SortBySurnameAsc);
            this.Controls.Add(this.SortByNameAsc);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomersListView);
            this.Name = "Customers";
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.CustomerAddressTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListView CustomersListView;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button EditButton;
        public System.Windows.Forms.Button ResetButton;
        public System.Windows.Forms.RadioButton SortByNameAsc;
        public System.Windows.Forms.RadioButton SortBySurnameAsc;
        public System.Windows.Forms.RadioButton SortByNameDesc;
        public System.Windows.Forms.RadioButton SortBySurnameDesc;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox NameTextBox;
        public System.Windows.Forms.TextBox SurnameTextBox;
        public System.Windows.Forms.TextBox PeselTextBox;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox PhoneTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox AddressTextBox;
        public System.Windows.Forms.Button BorrowButton;
        public System.Windows.Forms.Button FindCustomersButton;

    }
}