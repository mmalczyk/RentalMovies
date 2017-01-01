namespace RentalMovies
{
    partial class Movies
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
            this.GenreButton = new System.Windows.Forms.Button();
            this.ActorsListView = new System.Windows.Forms.ListView();
            this.GenreListView = new System.Windows.Forms.ListView();
            this.FindButton = new System.Windows.Forms.Button();
            this.AvailableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BorrowedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DirectorTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.CountrylTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SortByReleaseYearDesc = new System.Windows.Forms.RadioButton();
            this.SortByTitleDesc = new System.Windows.Forms.RadioButton();
            this.SortByReleaseYerAsc = new System.Windows.Forms.RadioButton();
            this.SortByTitleAsc = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.MoviesListView = new System.Windows.Forms.ListView();
            this.ChooseDirectorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ActorsButton = new System.Windows.Forms.Button();
            this.DVD = new System.Windows.Forms.Label();
            this.DVDListView = new System.Windows.Forms.ListView();
            this.DVDButton = new System.Windows.Forms.Button();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.DeleteGenreButton = new System.Windows.Forms.Button();
            this.DeleteActorButton = new System.Windows.Forms.Button();
            this.DeleteDVDButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenreButton
            // 
            this.GenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GenreButton.Location = new System.Drawing.Point(584, 669);
            this.GenreButton.Name = "GenreButton";
            this.GenreButton.Size = new System.Drawing.Size(113, 48);
            this.GenreButton.TabIndex = 149;
            this.GenreButton.Text = "Gatunki";
            this.GenreButton.UseVisualStyleBackColor = true;
            this.GenreButton.Click += new System.EventHandler(this.GenreButton_Click);
            // 
            // ActorsListView
            // 
            this.ActorsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActorsListView.FullRowSelect = true;
            this.ActorsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ActorsListView.HideSelection = false;
            this.ActorsListView.Location = new System.Drawing.Point(864, 503);
            this.ActorsListView.Name = "ActorsListView";
            this.ActorsListView.Size = new System.Drawing.Size(272, 146);
            this.ActorsListView.TabIndex = 148;
            this.ActorsListView.UseCompatibleStateImageBehavior = false;
            // 
            // GenreListView
            // 
            this.GenreListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.GenreListView.FullRowSelect = true;
            this.GenreListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.GenreListView.HideSelection = false;
            this.GenreListView.Location = new System.Drawing.Point(584, 503);
            this.GenreListView.Name = "GenreListView";
            this.GenreListView.Size = new System.Drawing.Size(216, 146);
            this.GenreListView.TabIndex = 147;
            this.GenreListView.UseCompatibleStateImageBehavior = false;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FindButton.Location = new System.Drawing.Point(948, 300);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(188, 93);
            this.FindButton.TabIndex = 146;
            this.FindButton.Text = "Znajdź";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // AvailableTextBox
            // 
            this.AvailableTextBox.Enabled = false;
            this.AvailableTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AvailableTextBox.Location = new System.Drawing.Point(1363, 683);
            this.AvailableTextBox.Name = "AvailableTextBox";
            this.AvailableTextBox.Size = new System.Drawing.Size(49, 26);
            this.AvailableTextBox.TabIndex = 145;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1237, 689);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 144;
            this.label3.Text = "Dostępne:";
            // 
            // BorrowedTextBox
            // 
            this.BorrowedTextBox.Enabled = false;
            this.BorrowedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BorrowedTextBox.Location = new System.Drawing.Point(1363, 737);
            this.BorrowedTextBox.Name = "BorrowedTextBox";
            this.BorrowedTextBox.Size = new System.Drawing.Size(49, 26);
            this.BorrowedTextBox.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(1237, 740);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 142;
            this.label2.Text = "Wypożyczone:";
            // 
            // DirectorTextBox
            // 
            this.DirectorTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.DirectorTextBox.Enabled = false;
            this.DirectorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DirectorTextBox.Location = new System.Drawing.Point(725, 200);
            this.DirectorTextBox.Name = "DirectorTextBox";
            this.DirectorTextBox.Size = new System.Drawing.Size(229, 26);
            this.DirectorTextBox.TabIndex = 139;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label13.Location = new System.Drawing.Point(593, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 138;
            this.label13.Text = "Reżyser:";
            // 
            // CountrylTextBox
            // 
            this.CountrylTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CountrylTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CountrylTextBox.Location = new System.Drawing.Point(725, 154);
            this.CountrylTextBox.Name = "CountrylTextBox";
            this.CountrylTextBox.Size = new System.Drawing.Size(229, 26);
            this.CountrylTextBox.TabIndex = 137;
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(725, 107);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(229, 26);
            this.ReleaseYearTextBox.TabIndex = 136;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TitleTextBox.Location = new System.Drawing.Point(725, 60);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(710, 26);
            this.TitleTextBox.TabIndex = 135;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.Location = new System.Drawing.Point(593, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 134;
            this.label14.Text = "Kraj:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.Location = new System.Drawing.Point(593, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 133;
            this.label15.Text = "Premiera:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(593, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 20);
            this.label16.TabIndex = 132;
            this.label16.Text = "Tytuł:";
            // 
            // SortByReleaseYearDesc
            // 
            this.SortByReleaseYearDesc.AutoSize = true;
            this.SortByReleaseYearDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortByReleaseYearDesc.Location = new System.Drawing.Point(762, 389);
            this.SortByReleaseYearDesc.Name = "SortByReleaseYearDesc";
            this.SortByReleaseYearDesc.Size = new System.Drawing.Size(164, 24);
            this.SortByReleaseYearDesc.TabIndex = 131;
            this.SortByReleaseYearDesc.TabStop = true;
            this.SortByReleaseYearDesc.Text = "> po dacie premiery";
            this.SortByReleaseYearDesc.UseVisualStyleBackColor = true;
            this.SortByReleaseYearDesc.Click += new System.EventHandler(this.SortBySurnameDesc_CheckedChanged);
            // 
            // SortByTitleDesc
            // 
            this.SortByTitleDesc.AutoSize = true;
            this.SortByTitleDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortByTitleDesc.Location = new System.Drawing.Point(762, 349);
            this.SortByTitleDesc.Name = "SortByTitleDesc";
            this.SortByTitleDesc.Size = new System.Drawing.Size(100, 24);
            this.SortByTitleDesc.TabIndex = 130;
            this.SortByTitleDesc.TabStop = true;
            this.SortByTitleDesc.Text = "> po tytule";
            this.SortByTitleDesc.UseVisualStyleBackColor = true;
            this.SortByTitleDesc.Click += new System.EventHandler(this.SortByNameDesc_CheckedChanged);
            // 
            // SortByReleaseYerAsc
            // 
            this.SortByReleaseYerAsc.AutoSize = true;
            this.SortByReleaseYerAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortByReleaseYerAsc.Location = new System.Drawing.Point(596, 389);
            this.SortByReleaseYerAsc.Name = "SortByReleaseYerAsc";
            this.SortByReleaseYerAsc.Size = new System.Drawing.Size(164, 24);
            this.SortByReleaseYerAsc.TabIndex = 129;
            this.SortByReleaseYerAsc.TabStop = true;
            this.SortByReleaseYerAsc.Text = "< po dacie premiery";
            this.SortByReleaseYerAsc.UseVisualStyleBackColor = true;
            this.SortByReleaseYerAsc.Click += new System.EventHandler(this.SortBySurnameAsc_CheckedChanged);
            // 
            // SortByTitleAsc
            // 
            this.SortByTitleAsc.AutoSize = true;
            this.SortByTitleAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SortByTitleAsc.Location = new System.Drawing.Point(596, 349);
            this.SortByTitleAsc.Name = "SortByTitleAsc";
            this.SortByTitleAsc.Size = new System.Drawing.Size(100, 24);
            this.SortByTitleAsc.TabIndex = 128;
            this.SortByTitleAsc.TabStop = true;
            this.SortByTitleAsc.Text = "< po tytule";
            this.SortByTitleAsc.UseVisualStyleBackColor = true;
            this.SortByTitleAsc.Click += new System.EventHandler(this.SortByNameAsc_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResetButton.Location = new System.Drawing.Point(1168, 300);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(113, 48);
            this.ResetButton.TabIndex = 127;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EditButton.Location = new System.Drawing.Point(1303, 382);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 48);
            this.EditButton.TabIndex = 126;
            this.EditButton.Text = "Zatwierdź";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteButton.Location = new System.Drawing.Point(1303, 300);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteButton.TabIndex = 125;
            this.DeleteButton.Text = "Usuń";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddButton.Location = new System.Drawing.Point(1168, 382);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 48);
            this.AddButton.TabIndex = 124;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MoviesListView
            // 
            this.MoviesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MoviesListView.FullRowSelect = true;
            this.MoviesListView.HideSelection = false;
            this.MoviesListView.Location = new System.Drawing.Point(34, 51);
            this.MoviesListView.Name = "MoviesListView";
            this.MoviesListView.Size = new System.Drawing.Size(486, 722);
            this.MoviesListView.TabIndex = 123;
            this.MoviesListView.UseCompatibleStateImageBehavior = false;
            this.MoviesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MoviesListView_ItemSelectionChanged);
            // 
            // ChooseDirectorButton
            // 
            this.ChooseDirectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ChooseDirectorButton.Location = new System.Drawing.Point(725, 253);
            this.ChooseDirectorButton.Name = "ChooseDirectorButton";
            this.ChooseDirectorButton.Size = new System.Drawing.Size(124, 50);
            this.ChooseDirectorButton.TabIndex = 150;
            this.ChooseDirectorButton.Text = "Reżyser";
            this.ChooseDirectorButton.UseVisualStyleBackColor = true;
            this.ChooseDirectorButton.Click += new System.EventHandler(this.ChooseDirectorButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(580, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 153;
            this.label1.Text = "Gatunki:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(860, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 154;
            this.label4.Text = "Aktorzy:";
            // 
            // ActorsButton
            // 
            this.ActorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ActorsButton.Location = new System.Drawing.Point(864, 669);
            this.ActorsButton.Name = "ActorsButton";
            this.ActorsButton.Size = new System.Drawing.Size(113, 48);
            this.ActorsButton.TabIndex = 155;
            this.ActorsButton.Text = "Aktorzy";
            this.ActorsButton.UseVisualStyleBackColor = true;
            this.ActorsButton.Click += new System.EventHandler(this.ActorsButton_Click);
            // 
            // DVD
            // 
            this.DVD.AutoSize = true;
            this.DVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DVD.Location = new System.Drawing.Point(1202, 471);
            this.DVD.Name = "DVD";
            this.DVD.Size = new System.Drawing.Size(48, 20);
            this.DVD.TabIndex = 157;
            this.DVD.Text = "DVD:";
            // 
            // DVDListView
            // 
            this.DVDListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DVDListView.FullRowSelect = true;
            this.DVDListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.DVDListView.HideSelection = false;
            this.DVDListView.Location = new System.Drawing.Point(1206, 503);
            this.DVDListView.Name = "DVDListView";
            this.DVDListView.Size = new System.Drawing.Size(216, 146);
            this.DVDListView.TabIndex = 156;
            this.DVDListView.UseCompatibleStateImageBehavior = false;
            // 
            // DVDButton
            // 
            this.DVDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DVDButton.Location = new System.Drawing.Point(1118, 669);
            this.DVDButton.Name = "DVDButton";
            this.DVDButton.Size = new System.Drawing.Size(113, 48);
            this.DVDButton.TabIndex = 158;
            this.DVDButton.Text = "DVD";
            this.DVDButton.UseVisualStyleBackColor = true;
            this.DVDButton.Click += new System.EventHandler(this.DVDButton_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(999, 107);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(436, 156);
            this.DescriptionTextBox.TabIndex = 160;
            this.DescriptionTextBox.Text = "";
            // 
            // DeleteGenreButton
            // 
            this.DeleteGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteGenreButton.Location = new System.Drawing.Point(703, 669);
            this.DeleteGenreButton.Name = "DeleteGenreButton";
            this.DeleteGenreButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteGenreButton.TabIndex = 161;
            this.DeleteGenreButton.Text = "Usuń";
            this.DeleteGenreButton.UseVisualStyleBackColor = true;
            this.DeleteGenreButton.Click += new System.EventHandler(this.DeleteGenreButton_Click);
            // 
            // DeleteActorButton
            // 
            this.DeleteActorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteActorButton.Location = new System.Drawing.Point(983, 669);
            this.DeleteActorButton.Name = "DeleteActorButton";
            this.DeleteActorButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteActorButton.TabIndex = 162;
            this.DeleteActorButton.Text = "Usuń";
            this.DeleteActorButton.UseVisualStyleBackColor = true;
            this.DeleteActorButton.Click += new System.EventHandler(this.DeleteActorButton_Click);
            // 
            // DeleteDVDButton
            // 
            this.DeleteDVDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteDVDButton.Location = new System.Drawing.Point(1118, 726);
            this.DeleteDVDButton.Name = "DeleteDVDButton";
            this.DeleteDVDButton.Size = new System.Drawing.Size(113, 48);
            this.DeleteDVDButton.TabIndex = 163;
            this.DeleteDVDButton.Text = "Usuń";
            this.DeleteDVDButton.UseVisualStyleBackColor = true;
            this.DeleteDVDButton.Click += new System.EventHandler(this.DeleteDVDButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(580, 754);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 164;
            this.label5.Text = "Cena:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CostTextBox.Location = new System.Drawing.Point(649, 754);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(48, 26);
            this.CostTextBox.TabIndex = 165;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(703, 760);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 166;
            this.label6.Text = "zł";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 817);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteDVDButton);
            this.Controls.Add(this.DeleteActorButton);
            this.Controls.Add(this.DeleteGenreButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DVDButton);
            this.Controls.Add(this.DVD);
            this.Controls.Add(this.DVDListView);
            this.Controls.Add(this.ActorsButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseDirectorButton);
            this.Controls.Add(this.GenreButton);
            this.Controls.Add(this.ActorsListView);
            this.Controls.Add(this.GenreListView);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.AvailableTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BorrowedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DirectorTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.CountrylTextBox);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SortByReleaseYearDesc);
            this.Controls.Add(this.SortByTitleDesc);
            this.Controls.Add(this.SortByReleaseYerAsc);
            this.Controls.Add(this.SortByTitleAsc);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MoviesListView);
            this.Name = "Movies";
            this.Text = "Filmy";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button GenreButton;
        public System.Windows.Forms.ListView ActorsListView;
        public System.Windows.Forms.ListView GenreListView;
        public System.Windows.Forms.Button FindButton;
        public System.Windows.Forms.TextBox AvailableTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox BorrowedTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DirectorTextBox;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox CountrylTextBox;
        public System.Windows.Forms.TextBox ReleaseYearTextBox;
        public System.Windows.Forms.TextBox TitleTextBox;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.RadioButton SortByReleaseYearDesc;
        public System.Windows.Forms.RadioButton SortByTitleDesc;
        public System.Windows.Forms.RadioButton SortByReleaseYerAsc;
        public System.Windows.Forms.RadioButton SortByTitleAsc;
        public System.Windows.Forms.Button ResetButton;
        public System.Windows.Forms.Button EditButton;
        public System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.ListView MoviesListView;
        public System.Windows.Forms.Button ChooseDirectorButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button ActorsButton;
        public System.Windows.Forms.Label DVD;
        public System.Windows.Forms.ListView DVDListView;
        public System.Windows.Forms.Button DVDButton;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        public System.Windows.Forms.Button DeleteGenreButton;
        public System.Windows.Forms.Button DeleteActorButton;
        public System.Windows.Forms.Button DeleteDVDButton;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox CostTextBox;
        public System.Windows.Forms.Label label6;
    }
}