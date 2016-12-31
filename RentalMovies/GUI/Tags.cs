using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMovies
{
    public partial class Tags : Base
    {
        public Tags()
        {
            InitializeComponent();
        }

        private void Tags_Load(object sender, EventArgs e)
        {
            GenreListView.View = View.Details;
            GenreListView.Columns.Add("Tagi", -2, HorizontalAlignment.Center);
            this.FillGenreList();

            ActorsListView.View = View.Details;
            ActorsListView.Columns.Add("Tagi", -2, HorizontalAlignment.Center);
            this.FillActorsList();

            DirectorListView.View = View.Details;
            DirectorListView.Columns.Add("Tagi", -2, HorizontalAlignment.Center);
            this.FillDirectorList();
        }

        private void FillGenreList()
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectAllTags.Replace("[category]", "Genre");
                System.Data.DataSet dataSet = objConnect.GetConnection;
                var tagList = dataSet.Tables[0].Rows;

                GenreListView.Items.Clear();
                foreach (DataRow row in tagList) this.GenreListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 1), objConnect.GetValue(row, 0) }));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "Error: FillGenreList");
            }
        }

        private void FillActorsList()
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectAllTags.Replace("[category]", "Actor");
                System.Data.DataSet dataSet = objConnect.GetConnection;
                var tagList = dataSet.Tables[0].Rows;

                ActorsListView.Items.Clear();
                foreach (DataRow row in tagList) this.ActorsListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 1), objConnect.GetValue(row, 0) }));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "Error: FillActorsList");
            }
        }

        private void FillDirectorList()
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectAllTags.Replace("[category]", "Writer");
                System.Data.DataSet dataSet = objConnect.GetConnection;
                var tagList = dataSet.Tables[0].Rows;

                DirectorListView.Items.Clear();
                foreach (DataRow row in tagList) this.DirectorListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 1), objConnect.GetValue(row, 0) }));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + "Error: FillDirectorList");
            }
        }

        private bool GenreIsCorrect()
        {
            if (GenreTextBox.Text == null) return false;
            if (GenreTextBox.Text.Trim().CompareTo("") == 0) return false;
            return true;
        }

        private bool ActorIsCorrect()
        {
            if (ActorTextBox.Text == null) return false;
            if (ActorTextBox.Text.Trim().CompareTo("") == 0) return false;
            return true;
        }

        private bool DirectorIsCorrect()
        {
            if (DirectorTextBox.Text == null) return false;
            if (DirectorTextBox.Text.Trim().CompareTo("") == 0) return false;
            return true;
        }

        private void ResizeTagListView()
        {
            GenreListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            ActorsListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            DirectorListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void GenreListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.GenreListView.SelectedItems;
                if (listItem != null && listItem.Count > 0) GenreTextBox.Text = listItem[0].Text;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: GenreListView_ItemSelectionChanged");
            }

        }

        private void ActorsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.ActorsListView.SelectedItems;
                if (listItem != null && listItem.Count > 0) ActorTextBox.Text = listItem[0].Text;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: ActorsListView_ItemSelectionChanged");
            }

        }

        private void DirectorListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.DirectorListView.SelectedItems;
                if (listItem != null && listItem.Count > 0) DirectorTextBox.Text = listItem[0].Text;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: DirectorListView_ItemSelectionChanged");
            }
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (this.GenreIsCorrect() == false) MessageBox.Show("Pusty tag");
            else
            {
                try
                {
                    this.objConnect.Sql = Properties.Settings.Default.SelectAllTags.Replace("[category]", "Genre");
                    System.Data.DataSet dataSet = objConnect.GetConnection;
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.NewRow();
                    row[0] = objConnect.GetNewID();
                    row[1] = GenreTextBox.Text.Trim();
                    row[2] = "Genre";
                    dataTable.Rows.Add(row);
                    objConnect.UpdateDatabase(dataSet);
                    this.FillGenreList();
                    this.ResizeTagListView();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddGenreButton_Click");
                }
            }
        }

        private void AddActorButton_Click(object sender, EventArgs e)
        {
            if (this.ActorIsCorrect() == false) MessageBox.Show("Pusty tag");
            else
            {
                try
                {
                    this.objConnect.Sql = Properties.Settings.Default.SelectAllTags.Replace("[category]", "Actor");
                    System.Data.DataSet dataSet = objConnect.GetConnection;
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.NewRow();
                    row[0] = objConnect.GetNewID();
                    row[1] = ActorTextBox.Text.Trim();
                    row[2] = "Actor";
                    dataTable.Rows.Add(row);
                    objConnect.UpdateDatabase(dataSet);
                    this.FillActorsList();
                    this.ResizeTagListView();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddActorButton_Click");
                }
            }
        }


        private void AddDirectorButton_Click(object sender, EventArgs e)
        {
            if (this.DirectorIsCorrect() == false) MessageBox.Show("Pusty tag");
            else
            {
                try
                {
                    this.objConnect.Sql = Properties.Settings.Default.SelectAllTags.Replace("[category]", "Writer");
                    System.Data.DataSet dataSet = objConnect.GetConnection;
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.NewRow();
                    row[0] = objConnect.GetNewID();
                    row[1] = DirectorTextBox.Text.Trim();
                    row[2] = "Writer";
                    dataTable.Rows.Add(row);
                    objConnect.UpdateDatabase(dataSet);
                    this.FillDirectorList();
                    this.ResizeTagListView();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddDirectorButton_Click");
                }
            }
        }

        private void EditGenreButton_Click(object sender, EventArgs e)
        {
            if (GenreListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano tagu");
            else
            {
                if (this.GenreIsCorrect() == false) MessageBox.Show("Pusty tag");
                else
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectTagByID.Replace("[id]", GenreListView.SelectedItems[0].SubItems[1].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var dataTable = dataSet.Tables[0];
                        var row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[1] = GenreTextBox.Text.Trim();
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillGenreList();
                        this.ResizeTagListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: EditGenreButton_Click");
                    }
                }
            }

        }

        private void EditActorButton_Click(object sender, EventArgs e)
        {
            if (ActorsListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano tagu");
            else
            {
                if (this.ActorIsCorrect() == false) MessageBox.Show("Pusty tag");
                else
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectTagByID.Replace("[id]", ActorsListView.SelectedItems[0].SubItems[1].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var dataTable = dataSet.Tables[0];
                        var row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[1] = ActorTextBox.Text.Trim();
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillActorsList();
                        this.ResizeTagListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: EditActorButton_Click");
                    }
                }
            }
        }
        
        private void EditDirectorButton_Click(object sender, EventArgs e)
        {
            if (DirectorListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano tagu");
            else
            {
                if (this.DirectorIsCorrect() == false) MessageBox.Show("Pusty tag");
                else
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectTagByID.Replace("[id]", DirectorListView.SelectedItems[0].SubItems[1].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var dataTable = dataSet.Tables[0];
                        var row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[1] = DirectorTextBox.Text.Trim();
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillDirectorList();
                        this.ResizeTagListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: EditDirectorButton_Click");
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
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var rows = dataSet.Tables[0].Rows;
                        foreach (DataRow row in rows) row.Delete();
                        objConnect.UpdateDatabase(dataSet);

                        this.objConnect.Sql = Properties.Settings.Default.SelectTagByID.Replace("[id]", GenreListView.SelectedItems[0].SubItems[1].Text.Trim());
                        dataSet = objConnect.GetConnection;
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillGenreList();
                        this.ResizeTagListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: DeleteGenreButton_Click");
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
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var rows = dataSet.Tables[0].Rows;
                        foreach (DataRow row in rows) row.Delete();
                        objConnect.UpdateDatabase(dataSet);

                        this.objConnect.Sql = Properties.Settings.Default.SelectTagByID.Replace("[id]", ActorsListView.SelectedItems[0].SubItems[1].Text.Trim());
                        dataSet = objConnect.GetConnection;
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillActorsList();
                        this.ResizeTagListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: DeleteActorButton_Click");
                    }
                }
            }
        }

        private void DeleteDirectorButton_Click(object sender, EventArgs e)
        {
            if (DirectorListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano tagu");
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectMoviesTagsByTagID.Replace("[id]", DirectorListView.SelectedItems[0].SubItems[1].Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var rows = dataSet.Tables[0].Rows;
                        foreach (DataRow row in rows) row.Delete();
                        objConnect.UpdateDatabase(dataSet);

                        this.objConnect.Sql = Properties.Settings.Default.SelectTagByID.Replace("[id]", DirectorListView.SelectedItems[0].SubItems[1].Text.Trim());
                        dataSet = objConnect.GetConnection;
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillDirectorList();
                        this.ResizeTagListView();

                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: DeleteDirectorButton_Click");
                    }
                }
            }
        }

    }
}
