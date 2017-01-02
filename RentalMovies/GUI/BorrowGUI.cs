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
    public partial class Borrow : Base
    {
        private string CustomerId;

        public Borrow(string customerId)
        {
            this.CustomerId = customerId;
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            MoviesListView.View = View.Details;
            MoviesListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            MoviesListView.Columns.Add("Tytuł", -2, HorizontalAlignment.Left);
            MoviesListView.Columns.Add("Premiera", -2, HorizontalAlignment.Left);
            MoviesListView.Columns.Add("Cena", -2, HorizontalAlignment.Left);
            this.FillMoviesList(Properties.Settings.Default.SelectAllFromMovies);

            BorrowedListView.View = View.Details;
            BorrowedListView.Columns.Add("Tytuł", -2, HorizontalAlignment.Left);
            BorrowedListView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            BorrowedListView.Columns.Add("Status", -2, HorizontalAlignment.Left);
            FillBorrowedList();
        }

        private void FillMoviesList(String c)
        {
            try
            {
                this.objConnect.Sql = c + " ORDER by title ASC ";
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var MoviesList = dataSet.Tables[0].Rows;

                MoviesListView.Items.Clear();
                foreach (DataRow row in MoviesList) this.MoviesListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 0), objConnect.GetValue(row, 1), objConnect.GetValue(row, 2), objConnect.GetValue(row, 4) }));
                ResizeMoviesListViews();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillMoviesList");
            }
        }

        private void FillBorrowedList()
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.GetRentingRecordByCustomerId.Replace("[id]", this.CustomerId);
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var List = dataSet.Tables[0].Rows;

                BorrowedListView.Items.Clear();
                int overdue = 0;
                int penalty = 0;
                foreach (DataRow row in List)
                {
                    string dvdid = objConnect.GetValue(row, 2);
                    this.objConnect.Sql = Properties.Settings.Default.GetMovieTitle.Replace("[id]", dvdid);
                    System.Data.DataSet dataSet2 = objConnect.GetDataSet();
                    string title = objConnect.GetValue(dataSet2.Tables[0].Rows[0], 1);

                    string date = objConnect.GetValue(row, 3);
                    string status;
                    DateTime borrowdate = Convert.ToDateTime(date);
                    DateTime limit = DateTime.Now.AddDays(Convert.ToDouble(Limits.TimeLimit));
                    if (borrowdate > limit)
                    {
                        status = "Przetrzymany";
                        overdue++;
                        penalty += (borrowdate - limit).Days * Convert.ToInt32(Limits.OverdueLimit);
                    }
                    else
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectDVDsById.Replace("[id]", dvdid);
                        System.Data.DataSet dataSet3 = objConnect.GetDataSet();
                        status = objConnect.GetValue(dataSet3.Tables[0].Rows[0], 2);
                    }

                    this.BorrowedListView.Items.Add(new ListViewItem(new[] { title, date, status, objConnect.GetValue(row, 0)}));
                }
                OverdueTextBox.Text = overdue.ToString();
                PenaltyTextBox.Text = GetPrice(Convert.ToDouble(penalty));
                ResizeBorrowedListViews();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillBorrowedList");
            }
        }

        private void ResizeMoviesListViews()
        {
            MoviesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            MoviesListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            MoviesListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            MoviesListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ResizeBorrowedListViews()
        {
            BorrowedListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            BorrowedListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            BorrowedListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MoviesListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano rekordu");
            else
            {
                try
                {
                    string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text.Trim();
                    string dvdid = GetAvailableDVDs(movieid);
                    if (dvdid.Trim().CompareTo("") != 0)
                    {
                        this.objConnect.Sql = Properties.Settings.Default.GetAllRentingRecord;
                        System.Data.DataSet dataSet = objConnect.GetDataSet();
                        var dataTable = dataSet.Tables[0];
                        var row = dataTable.NewRow();
                        row[0] = objConnect.GetNewID();
                        row[1] = this.CustomerId.Trim();
                        row[2] = dvdid;
                        row[3] = DateTime.Now;
                        dataTable.Rows.Add(row);
                        this.objConnect.UpdateDatabase(dataSet);

                        this.objConnect.Sql = Properties.Settings.Default.SelectDVDsById.Replace("[id]", dvdid);
                        dataSet = objConnect.GetDataSet();
                        row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[2] = "Pozyczony";
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);

                        this.FillBorrowedList();
                        BorrowedTextBox.Text = GetDVDCount("Pozyczony", movieid);
                        AvailableTextBox.Text = GetDVDCount("Dostepny", movieid);
                    }
                    else MessageBox.Show("Nie ma dostępnego egzemplarza");
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddButton_Click");
                }
            }
        }

        private string GetPrice (double price)
        {
            return (price/100.0).ToString("f2");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (BorrowedListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano rekordu");
            else
            {
                try
                {
                    string transactionid = BorrowedListView.SelectedItems[0].SubItems[3].Text.Trim();
                    this.objConnect.Sql = Properties.Settings.Default.GetTransactionById.Replace("[id]", transactionid);
                    System.Data.DataSet dataSet = objConnect.GetDataSet();
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.Rows[0];
                    string dvdid = objConnect.GetValue(row, 2);
                    string date = objConnect.GetValue(row, 3);

                    DateTime borrowdate = Convert.ToDateTime(date);
                    DateTime limit = DateTime.Now.AddDays(Convert.ToDouble(Limits.TimeLimit));
                    if (borrowdate > limit)
                    {
                        OverdueTextBox.Text = (Convert.ToInt32(OverdueTextBox.Text) - 1).ToString();
                        double value = Convert.ToDouble(Convert.ToInt32(PenaltyTextBox.Text) - (borrowdate - limit).Days * Convert.ToInt32(Limits.OverdueLimit));
                        PenaltyTextBox.Text = GetPrice(value);
                    }
                    row.Delete();
                    objConnect.UpdateDatabase(dataSet);

                    this.objConnect.Sql = Properties.Settings.Default.SelectDVDsById.Replace("[id]", dvdid);
                    dataSet = objConnect.GetDataSet();
                    row = dataSet.Tables[0].Rows[0];
                    string movieid = objConnect.GetValue(row, 1);
                    row.BeginEdit();
                    row[2] = "Dostepny";
                    row.EndEdit();
                    objConnect.UpdateDatabase(dataSet);


                    BorrowedTextBox.Text = GetDVDCount("Pozyczony", movieid);
                    AvailableTextBox.Text = GetDVDCount("Dostepny", movieid);


                    this.FillBorrowedList();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: DeleteButton_Click");
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

        private string GetAvailableDVDs (string movieid)
        {
            this.objConnect.Sql = Properties.Settings.Default.GetAvailableDVDByMovieId.Replace("[id]", movieid);
            System.Data.DataSet dataSet = objConnect.GetDataSet();
            if (dataSet.Tables[0].Rows.Count == 0) return "";
            return objConnect.GetValue(dataSet.Tables[0].Rows[0], 0);
        }

        private string GetDVDCount(string status, string movieid)
        {
            this.objConnect.Sql = Properties.Settings.Default.CountDVDsByStatus.Replace("[id]", movieid).Replace("[status]", status);
            System.Data.DataSet dataSet = objConnect.GetDataSet();
            return objConnect.GetValue(dataSet.Tables[0].Rows[0], 0);
        }

        private void MoviesListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (MoviesListView.SelectedItems.Count > 0)
            {
                string movieid = MoviesListView.SelectedItems[0].SubItems[0].Text; ;
                BorrowedTextBox.Text = GetDVDCount("Pozyczony", movieid);
                AvailableTextBox.Text = GetDVDCount("Dostepny", movieid);
            }
            else
            {
                BorrowedTextBox.Text = "";
                AvailableTextBox.Text = "";
            }
        }
    }
}
