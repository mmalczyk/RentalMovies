namespace RentalMovies
{
    partial class Borrow
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
            this.label1 = new System.Windows.Forms.Label();
            this.BorrowedListView = new System.Windows.Forms.ListView();
            this.FindButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MoviesListView = new System.Windows.Forms.ListView();
            this.AvailableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BorrowedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OverdueTextBox = new System.Windows.Forms.TextBox();
            this.Overdue = new System.Windows.Forms.Label();
            this.PenaltyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(560, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 182;
            this.label1.Text = "Wypożyczone:";
            // 
            // BorrowedListView
            // 
            this.BorrowedListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BorrowedListView.FullRowSelect = true;
            this.BorrowedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.BorrowedListView.HideSelection = false;
            this.BorrowedListView.Location = new System.Drawing.Point(564, 78);
            this.BorrowedListView.Name = "BorrowedListView";
            this.BorrowedListView.Size = new System.Drawing.Size(608, 146);
            this.BorrowedListView.TabIndex = 179;
            this.BorrowedListView.UseCompatibleStateImageBehavior = false;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FindButton.Location = new System.Drawing.Point(953, 258);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(188, 93);
            this.FindButton.TabIndex = 178;
            this.FindButton.Text = "Znajdź";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(789, 303);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteButton.TabIndex = 165;
            this.DeleteButton.Text = "Oddaj";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.Location = new System.Drawing.Point(597, 303);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 48);
            this.AddButton.TabIndex = 162;
            this.AddButton.Text = "Wypożycz";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MoviesListView
            // 
            this.MoviesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MoviesListView.FullRowSelect = true;
            this.MoviesListView.HideSelection = false;
            this.MoviesListView.Location = new System.Drawing.Point(17, 43);
            this.MoviesListView.Name = "MoviesListView";
            this.MoviesListView.Size = new System.Drawing.Size(478, 486);
            this.MoviesListView.TabIndex = 161;
            this.MoviesListView.UseCompatibleStateImageBehavior = false;
            this.MoviesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MoviesListView_ItemSelectionChanged);
            // 
            // AvailableTextBox
            // 
            this.AvailableTextBox.Enabled = false;
            this.AvailableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AvailableTextBox.Location = new System.Drawing.Point(696, 466);
            this.AvailableTextBox.Name = "AvailableTextBox";
            this.AvailableTextBox.Size = new System.Drawing.Size(49, 26);
            this.AvailableTextBox.TabIndex = 186;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(570, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 185;
            this.label3.Text = "Dostępne:";
            // 
            // BorrowedTextBox
            // 
            this.BorrowedTextBox.Enabled = false;
            this.BorrowedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BorrowedTextBox.Location = new System.Drawing.Point(953, 466);
            this.BorrowedTextBox.Name = "BorrowedTextBox";
            this.BorrowedTextBox.Size = new System.Drawing.Size(49, 26);
            this.BorrowedTextBox.TabIndex = 184;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(827, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 183;
            this.label2.Text = "Wypożyczone:";
            // 
            // OverdueTextBox
            // 
            this.OverdueTextBox.Enabled = false;
            this.OverdueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OverdueTextBox.Location = new System.Drawing.Point(707, 248);
            this.OverdueTextBox.Name = "OverdueTextBox";
            this.OverdueTextBox.Size = new System.Drawing.Size(49, 26);
            this.OverdueTextBox.TabIndex = 190;
            // 
            // Overdue
            // 
            this.Overdue.AutoSize = true;
            this.Overdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Overdue.Location = new System.Drawing.Point(581, 254);
            this.Overdue.Name = "Overdue";
            this.Overdue.Size = new System.Drawing.Size(110, 20);
            this.Overdue.TabIndex = 189;
            this.Overdue.Text = "Przetrzymane:";
            // 
            // PenaltyTextBox
            // 
            this.PenaltyTextBox.Enabled = false;
            this.PenaltyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PenaltyTextBox.Location = new System.Drawing.Point(865, 248);
            this.PenaltyTextBox.Name = "PenaltyTextBox";
            this.PenaltyTextBox.Size = new System.Drawing.Size(49, 26);
            this.PenaltyTextBox.TabIndex = 188;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(789, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 187;
            this.label5.Text = "Kara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(915, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 191;
            this.label4.Text = "zł";
            // 
            // Borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 568);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OverdueTextBox);
            this.Controls.Add(this.Overdue);
            this.Controls.Add(this.PenaltyTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AvailableTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BorrowedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BorrowedListView);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MoviesListView);
            this.Name = "Borrow";
            this.Text = "Transakcja";
            this.Load += new System.EventHandler(this.Borrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView BorrowedListView;
        public System.Windows.Forms.Button FindButton;
        public System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.ListView MoviesListView;
        public System.Windows.Forms.TextBox AvailableTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox BorrowedTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox OverdueTextBox;
        public System.Windows.Forms.Label Overdue;
        public System.Windows.Forms.TextBox PenaltyTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
    }
}