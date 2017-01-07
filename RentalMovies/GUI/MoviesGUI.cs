using RentalMovies.Domain.Records;
using System;
using System.Data;
using System.Windows.Forms;

namespace RentalMovies
{
    public partial class Movies : Base
    {
        private string currentSql;

        public Movies(User user)
        {
            InitializeComponent();
            if (user.Job.CompareTo("Manager") == 0 || user.Job.CompareTo("Edytor") == 0)
            {
                FindButton.Enabled = true;
                DirectorTextBox.Enabled = false;

                TitleTextBox.Enabled = true;
                ReleaseYearTextBox.Enabled = true;
                CountrylTextBox.Enabled = true;
                DescriptionTextBox.Enabled = true;
                ChooseDirectorButton.Enabled = true;
                ResetButton.Enabled = true;
                AddButton.Enabled = true;
                EditButton.Enabled = true;
                DeleteButton.Enabled = true;
                GenreButton.Enabled = true;
                ActorsButton.Enabled = true;
                DVDButton.Enabled = true;
            }
            else
            {
                FindButton.Enabled = true;
                DirectorTextBox.Enabled = false;

                TitleTextBox.Enabled = false;
                ReleaseYearTextBox.Enabled = false;
                CountrylTextBox.Enabled = false;
                DescriptionTextBox.Enabled = false;
                ChooseDirectorButton.Enabled = false;
                ResetButton.Enabled = false;
                AddButton.Enabled = false;
                EditButton.Enabled = false;
                DeleteButton.Enabled = false;
                GenreButton.Enabled = false;
                ActorsButton.Enabled = false;
                DVDButton.Enabled = false;
            }
        }

        private void Correction()
        {
            this.objConnect.Sql = Properties.Settings.Default.SelectAllFromMovies;
            System.Data.DataSet dataSet = objConnect.GetDataSet();
            var rows = dataSet.Tables[0].Rows;
            foreach (DataRow row in rows)
            {
                row.BeginEdit();
                row[4] = "";
                row.EndEdit();
            }
            objConnect.UpdateDatabase(dataSet);
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            //this.Correction();

            this.currentSql = Properties.Settings.Default.SelectAllFromMovies;

            MoviesListView.View = View.Details;
            MoviesListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            MoviesListView.Columns.Add("Tytuł", -2, HorizontalAlignment.Left);
            MoviesListView.Columns.Add("Premiera", -2, HorizontalAlignment.Left);
            MoviesListView.Columns.Add("Reżyser", -2, HorizontalAlignment.Left);
            this.FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);

            GenreListView.View = View.Details;
            GenreListView.Columns.Add("Genre", -2, HorizontalAlignment.Center);

            ActorsListView.View = View.Details;
            ActorsListView.Columns.Add("Actors", -2, HorizontalAlignment.Left);

            DVDListView.View = View.Details;
            DVDListView.Columns.Add("Id", -2, HorizontalAlignment.Center);
            DVDListView.Columns.Add("Status", -2, HorizontalAlignment.Center);
            DVDListView.Columns[0].Width = 80;
            DVDListView.Columns[1].Width = 120;

            this.ResizeListViews();
        }

        private string GetTagName(string movieid)
        {
            this.objConnect.Sql = Properties.Settings.Default.SelectTagsByMovieId.Replace("[id]", movieid).Replace("[category]", "Writer");
            System.Data.DataSet dataSet = objConnect.GetDataSet();
            var rows = dataSet.Tables[0].Rows;
            if (rows.Count == 0) return "";
            else return this.objConnect.GetValue(dataSet.Tables[0].Rows[0], 1);
        }

        private void FillMoviesList(String c)
        {
            try
            {
                this.currentSql = c;
                this.objConnect.Sql = c + Properties.Settings.Default.OrderBy + this.FindCheckedRadioButton();
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var MoviesList = dataSet.Tables[0].Rows;

                MoviesListView.Items.Clear();
                if (MoviesList.Count>0)foreach (DataRow row in MoviesList) this.MoviesListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 0), objConnect.GetValue(row, 1), objConnect.GetValue(row, 2), GetTagName(objConnect.GetValue(row, 0))}));
                ResizeListViews();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillMoviesList");
            }
        }

        private void FillGenreList(String movieid)
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectTagsByMovieId.Replace("[id]", movieid).Replace("[category]", "Genre");
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var GenreList = dataSet.Tables[0].Rows;
                GenreListView.Items.Clear();
                foreach (DataRow row in GenreList) this.GenreListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 1), objConnect.GetValue(row, 0) }));
                ResizeListViews();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillGenreList");
            }
        }

        private void FillActorList(String movieid)
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectTagsByMovieId.Replace("[id]", movieid).Replace("[category]", "Actor");
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var ActorsList = dataSet.Tables[0].Rows;
                ActorsListView.Items.Clear();
                foreach (DataRow row in ActorsList) this.ActorsListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 1), objConnect.GetValue(row, 0) }));
                ResizeListViews();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillActorList");
            }
        }

        private void FillDVDList(String movieid)
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectDVDByMovieId.Replace("[id]", movieid);
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var DVDList = dataSet.Tables[0].Rows;
                DVDListView.Items.Clear();
                foreach (DataRow row in DVDList) this.DVDListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 0), objConnect.GetValue(row, 2) }));
                ResizeListViews();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillDVDList");
            }
        }


        private string FindCheckedRadioButton()
        {
            if (SortByTitleAsc.Checked == true) return "title ASC";
            if (SortByTitleDesc.Checked == true) return "title DESC";
            if (SortByReleaseYerAsc.Checked == true) return "releaseYear ASC";
            if (SortByReleaseYearDesc.Checked == true) return "releaseYear DESC";
            return "title ASC";
        }

        private bool MoviesIsCorrect()
        {
            if (TitleTextBox.Text == null) return false;
            if (TitleTextBox.Text.Trim().CompareTo("") == 0) return false;
            if (CostTextBox.Text == null) return false;
            if (CostTextBox.Text.Trim().CompareTo("") == 0) return false;
            return true;
        }

        private void ResetMovies()
        {
            TitleTextBox.Clear();
            ReleaseYearTextBox.Clear();
            CountrylTextBox.Clear();
            DirectorTextBox.Clear();
            DescriptionTextBox.Clear();
            CostTextBox.Clear();

            SortByTitleAsc.Checked = false;
            SortByTitleDesc.Checked = false;
            SortByReleaseYerAsc.Checked = false;
            SortByReleaseYearDesc.Checked = false;

            BorrowedTextBox.Clear();
            AvailableTextBox.Clear();

            FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);
        }

        private void MoviesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.MoviesListView.SelectedItems;
                if (listItem != null && listItem.Count > 0)
                {
                    FillTextBoxes(listItem[0].Text);
                    FillGenreList(listItem[0].Text);
                    FillActorList(listItem[0].Text);
                    FillDVDList(listItem[0].Text);
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: MoviesListView_ItemSelectionChanged");
            }
        }

        private void FillTextBoxes(String movieid)
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectMovieByID.Replace("[id]", movieid);
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                DataRow row = dataSet.Tables[0].Rows[0];
                TitleTextBox.Text = objConnect.GetValue(row, 1);
                ReleaseYearTextBox.Text = objConnect.GetValue(row, 2);
                CountrylTextBox.Text = objConnect.GetValue(row, 3);
                DirectorTextBox.Text = GetTagName(objConnect.GetValue(row, 0));
                DescriptionTextBox.Text = objConnect.GetValue(row, 5);
                CostTextBox.Text = objConnect.GetValue(row, 4);
                BorrowedTextBox.Text = GetDVDCount("Pozyczony", movieid);
                AvailableTextBox.Text = GetDVDCount("Dostepny", movieid); 
                this.ResizeListViews();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: FillTextBoxes");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ResetMovies();
        }

        private void SortByNameAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillMoviesList(currentSql);
        }

        private void SortByNameDesc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillMoviesList(currentSql);
        }

        private void SortBySurnameAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillMoviesList(currentSql);
        }

        private void SortBySurnameDesc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillMoviesList(currentSql);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.MoviesIsCorrect() == false) MessageBox.Show("Błędnie wypełniony rekord");
            else
            {
                try
                {
                    this.objConnect.Sql = Properties.Settings.Default.SelectAllFromMovies;
                    System.Data.DataSet dataSet = objConnect.GetDataSet();
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.NewRow();
                    row[0] = objConnect.GetNewID();
                    row[1] = TitleTextBox.Text.Trim();
                    row[2] = ReleaseYearTextBox.Text.Trim();
                    row[3] = CountrylTextBox.Text.Trim();
                    row[4] = CostTextBox.Text.Trim();
                    row[5] = DescriptionTextBox.Text;
                    dataTable.Rows.Add(row);
                    objConnect.UpdateDatabase(dataSet);
                    this.ResizeListViews();
                    this.FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);
                    this.ResizeListViews();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddButton_Click");
                }
            }
        }

        private void ResizeListViews()
        {
            MoviesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            MoviesListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            MoviesListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            MoviesListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano filmu");
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectMoviesTagsByTagID.Replace("[id]", MoviesListView.SelectedItems[0].SubItems[0].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetDataSet();
                        var rows = dataSet.Tables[0].Rows;
                        foreach (DataRow row in rows) row.Delete();
                        objConnect.UpdateDatabase(dataSet);

                        this.objConnect.Sql = Properties.Settings.Default.SelectMovieByID.Replace("[id]", MoviesListView.SelectedItems[0].SubItems[0].Text);
                        dataSet = objConnect.GetDataSet();
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.ResetMovies();
                        this.ResizeListViews();
                        this.FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: DeleteButton_Click");
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano filmu");
            else
            {
                if (this.MoviesIsCorrect() == false) MessageBox.Show("Błędnie wypełniony rekord");
                else
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectMovieByID.Replace("[id]", MoviesListView.SelectedItems[0].SubItems[0].Text);
                        System.Data.DataSet dataSet = objConnect.GetDataSet();
                        var dataTable = dataSet.Tables[0];
                        var row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[1] = TitleTextBox.Text.Trim();
                        row[2] = ReleaseYearTextBox.Text.Trim();
                        row[3] = CountrylTextBox.Text.Trim();
                        row[4] = CostTextBox.Text.Trim();
                        row[5] = DescriptionTextBox.Text.Trim();
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        this.ResizeListViews();
                        this.FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: EditButton_Click");
                    }
                }
            }
        }

        private void ChooseDirectorButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano filmu");
            else
            {
                using (var form = new Tag("Writer"))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string tagid = form.Id;
                        string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text;
                        if (tagid != null)
                        {
                            this.objConnect.Sql = Properties.Settings.Default.SelectTagsByMovieId.Replace("[id]", movieid).Replace("[category]", "Writer");
                            System.Data.DataSet dataSet = objConnect.GetDataSet();
                            var rows = dataSet.Tables[0].Rows;
                            string directorid = "";
                            if (rows.Count > 0) directorid = objConnect.GetValue(rows[0], 0);

                            this.objConnect.Sql = Properties.Settings.Default.SelectMoviesTagsByTagAndMovieId.Replace("[movieid]", movieid).Replace("[tagid]", directorid);
                            dataSet = objConnect.GetDataSet();
                            if (dataSet.Tables[0].Rows.Count > 0)
                            {
                                dataSet.Tables[0].Rows[0].Delete();
                                objConnect.UpdateDatabase(dataSet);
                            }

                            this.objConnect.Sql = Properties.Settings.Default.SelectAllMoviesTags;
                            dataSet = objConnect.GetDataSet();
                            var dataTable = dataSet.Tables[0];
                            var row = dataTable.NewRow();
                            row[0] = objConnect.GetNewID();
                            row[1] = movieid.Trim();
                            row[2] = tagid.Trim();
                            dataTable.Rows.Add(row);
                            objConnect.UpdateDatabase(dataSet);

                            FillTextBoxes(movieid);
                            FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);
                        }
                    }
                }
            }
        }

        private void GenreButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano filmu");
            else
            {
                using (var form = new Tag("Genre"))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string tagid = form.Id;
                        string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text;
                        if (tagid != null)
                        {
                            this.objConnect.Sql = Properties.Settings.Default.SelectAllMoviesTags;
                            System.Data.DataSet dataSet = objConnect.GetDataSet();
                            var dataTable = dataSet.Tables[0];
                            var row = dataTable.NewRow();
                            row[0] = objConnect.GetNewID();
                            row[1] = movieid.Trim();
                            row[2] = tagid.Trim();
                            dataTable.Rows.Add(row);
                            objConnect.UpdateDatabase(dataSet);
                            this.FillGenreList(movieid);
                        }
                    }
                }
            }
        }

        private void ActorsButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano filmu");
            else
            {
                using (var form = new Tag("Actor"))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string tagid = form.Id;
                        string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text;
                        if (tagid != null)
                        {
                            this.objConnect.Sql = Properties.Settings.Default.SelectAllMoviesTags;
                            System.Data.DataSet dataSet = objConnect.GetDataSet();
                            var dataTable = dataSet.Tables[0];
                            var row = dataTable.NewRow();
                            row[0] = objConnect.GetNewID();
                            row[1] = movieid.Trim();
                            row[2] = tagid.Trim();
                            dataTable.Rows.Add(row);
                            objConnect.UpdateDatabase(dataSet);
                            this.FillActorList(movieid);
                        }
                    }
                }
            }
        }

        private void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            if (GenreListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano tagu");
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectMoviesTagsByTagID.Replace("[id]", GenreListView.SelectedItems[0].SubItems[1].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetDataSet();
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillGenreList(MoviesListView.SelectedItems[0].SubItems[0].Text.Trim());
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error:DeleteGenreButton_Click");
                    }
                }
            }
        }

        private void DeleteActorButton_Click(object sender, EventArgs e)
        {
            if (ActorsListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano tagu");
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectMoviesTagsByTagID.Replace("[id]", ActorsListView.SelectedItems[0].SubItems[1].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetDataSet();
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillActorList(MoviesListView.SelectedItems[0].SubItems[0].Text.Trim());
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error:DeleteActorsButton_Click");
                    }
                }
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            using (var form = new MovieSearch())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) if (form.command != null) this.FillMoviesList(form.command);
            }
        }

        private void DVDButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano filmu");
            else
            {
                string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text;
                this.objConnect.Sql = Properties.Settings.Default.SelectAllDVDs;
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var dataTable = dataSet.Tables[0];
                var row = dataTable.NewRow();
                string DVDId = objConnect.GetNewID();
                row[0] = DVDId;
                row[1] = movieid;
                row[2] = "Dostepny";
                dataTable.Rows.Add(row);
                objConnect.UpdateDatabase(dataSet);

                this.FillDVDList(movieid);
                this.FillTextBoxes(movieid);
             }
        }

        private void DeleteDVDButton_Click (object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0 || DVDListView.SelectedItems.Count == 0) MessageBox.Show("Nie zaznaczono rekordu");
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string dvdid = DVDListView.SelectedItems[0].SubItems[0].Text.Trim();
                        string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text.Trim();
                        this.objConnect.Sql = Properties.Settings.Default.SelectDVDsById.Replace("[id]", dvdid);
                        System.Data.DataSet dataSet = objConnect.GetDataSet();
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillDVDList(MoviesListView.SelectedItems[0].SubItems[0].Text.Trim());
                        this.FillTextBoxes(movieid);

                        this.objConnect.Sql = Properties.Settings.Default.GetTransactionsByDVDId.Replace("[id]", dvdid);
                        dataSet = objConnect.GetDataSet();
                        var rows = dataSet.Tables[0].Rows;
                        foreach (DataRow row in rows) row.Delete();
                        objConnect.UpdateDatabase(dataSet);

                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error:DeleteMoviesButton_Click");
                    }
                }
            }
        }

        private string GetDVDCount(string status, string movieid)
        {
            this.objConnect.Sql = Properties.Settings.Default.CountDVDsByStatus.Replace("[id]", movieid).Replace("[status]", status);
            System.Data.DataSet dataSet = objConnect.GetDataSet();
            return objConnect.GetValue(dataSet.Tables[0].Rows[0], 0);
        }

    }
}
