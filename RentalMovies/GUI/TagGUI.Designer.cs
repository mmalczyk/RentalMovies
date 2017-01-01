namespace RentalMovies
{
    partial class Tag
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
            this.OKButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ChooseButton = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.OKButton.Location = new System.Drawing.Point(359, 116);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(113, 48);
            this.OKButton.TabIndex = 168;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SearchTextBox.Location = new System.Drawing.Point(26, 332);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(299, 26);
            this.SearchTextBox.TabIndex = 167;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(33, 297);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 166;
            this.label14.Text = "Wyszukaj:";
            // 
            // ChooseButton
            // 
            this.ChooseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChooseButton.Location = new System.Drawing.Point(359, 42);
            this.ChooseButton.Name = "ChooseButton";
            this.ChooseButton.Size = new System.Drawing.Size(113, 48);
            this.ChooseButton.TabIndex = 165;
            this.ChooseButton.Text = "Wybierz";
            this.ChooseButton.UseVisualStyleBackColor = true;
            this.ChooseButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // ListView
            // 
            this.ListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ListView.FullRowSelect = true;
            this.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListView.HideSelection = false;
            this.ListView.Location = new System.Drawing.Point(26, 33);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(299, 238);
            this.ListView.TabIndex = 163;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            // 
            // ChooseTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 390);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ChooseButton);
            this.Controls.Add(this.ListView);
            this.Name = "ChooseTag";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ChoseTag_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.TextBox SearchTextBox;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Button ChooseButton;
        public System.Windows.Forms.ListView ListView;

    }
}