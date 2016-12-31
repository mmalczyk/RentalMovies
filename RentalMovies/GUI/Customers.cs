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
    public partial class Customers : Base
    {
        private string currentSql;

        public Customers()
        {
            InitializeComponent();
        }

        private void CustomerAddressTextBox_Load(object sender, EventArgs e)
        {
            this.currentSql = Properties.Settings.Default.SelectAllFromCustomers;

            CustomersListView.View = View.Details;
            CustomersListView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            CustomersListView.Columns.Add("Imię", -2, HorizontalAlignment.Left);
            CustomersListView.Columns.Add("Nazwisko", -2, HorizontalAlignment.Left);
            CustomersListView.Columns.Add("PESEL", -2, HorizontalAlignment.Left);
            CustomersListView.Columns.Add("Nr tel", -2, HorizontalAlignment.Left);
            CustomersListView.Columns.Add("Adres", -2, HorizontalAlignment.Left);
            this.FillCustomerList(Properties.Settings.Default.SelectAllFromCustomers);
            this.ResizeCustomerListView();
        }

        private void FillCustomerList(String c)
        {
            try
            {
                this.currentSql = c;
                this.objConnect.Sql = c + Properties.Settings.Default.OrderBy + this.FindCheckedRadioButton();
                System.Data.DataSet dataSet = objConnect.GetConnection;
                var CustomerList = dataSet.Tables[0].Rows;

                CustomersListView.Items.Clear();
                foreach (DataRow row in CustomerList) this.CustomersListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 0), objConnect.GetValue(row, 1), objConnect.GetValue(row, 2), objConnect.GetValue(row, 3), objConnect.GetValue(row, 4), objConnect.GetValue(row, 5) }));
                this.ResizeCustomerListView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillCustomerList");
            }
        }

        private string FindCheckedRadioButton()
        {
            if (SortByNameAsc.Checked == true) return "forename ASC";
            if (SortByNameDesc.Checked == true) return "forename DESC";
            if (SortBySurnameAsc.Checked == true) return "surname ASC";
            if (SortBySurnameDesc.Checked == true) return "surname DESC";
            return "surname ASC";
        }

        private bool CustomerIsCorrect()
        {
            if (NameTextBox.Text == null) return false;
            if (SurnameTextBox.Text == null) return false;
            if (NameTextBox.Text.Trim().CompareTo("") == 0) return false;
            if (SurnameTextBox.Text.Trim().CompareTo("") == 0) return false;
            return true;
        }

        private void ResetCustomer()
        {
            CustomersListView.SelectedIndices.Clear();

            NameTextBox.Clear();
            SurnameTextBox.Clear();
            PeselTextBox.Clear();
            PhoneTextBox.Clear();
            AddressTextBox.Clear();

            SortByNameAsc.Checked = false;
            SortByNameDesc.Checked = false;
            SortBySurnameAsc.Checked = false;
            SortBySurnameDesc.Checked = false;

            FillTextBoxes(Properties.Settings.Default.SelectAllFromCustomers);
        }

        private void CustomersListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.CustomersListView.SelectedItems;
                if (listItem != null && listItem.Count > 0) FillTextBoxes(Properties.Settings.Default.SelectCustomerByID.Replace("[id]", listItem[0].Text));
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: CustomersListView_ItemSelectionChanged");
            }
        }

        private void FillTextBoxes(String c)
        {
            try
            {
                this.objConnect.Sql = c;
                System.Data.DataSet dataSet = objConnect.GetConnection;
                DataRow row = dataSet.Tables[0].Rows[0];
                NameTextBox.Text = objConnect.GetValue(row, 1);
                SurnameTextBox.Text = objConnect.GetValue(row, 2);
                PeselTextBox.Text = objConnect.GetValue(row, 3);
                PhoneTextBox.Text = objConnect.GetValue(row, 4);
                AddressTextBox.Text = objConnect.GetValue(row, 5);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: FillTextBoxes");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.ResetCustomer();
        }

        private void SortByNameAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillCustomerList(currentSql);
        }

        private void SortByNameDesc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillCustomerList(currentSql);
        }

        private void SortBySurnameAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillCustomerList(currentSql);
        }

        private void SortBySurnameDesc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillCustomerList(currentSql);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.CustomerIsCorrect() == false) MessageBox.Show("Błędnie wypełniony rekord");
            else
            {
                try
                {
                    this.objConnect.Sql = Properties.Settings.Default.SelectAllFromCustomers;
                    System.Data.DataSet dataSet = objConnect.GetConnection;
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.NewRow();
                    row[0] = objConnect.GetNewID();
                    row[1] = NameTextBox.Text.Trim();
                    row[2] = SurnameTextBox.Text.Trim();
                    row[3] = PeselTextBox.Text.Trim();
                    row[4] = PhoneTextBox.Text.Trim();
                    row[5] = AddressTextBox.Text.Trim();
                    dataTable.Rows.Add(row);
                    objConnect.UpdateDatabase(dataSet);
                    this.ResizeCustomerListView();
                    this.FillCustomerList(Properties.Settings.Default.SelectAllFromCustomers);
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddButton_Click");
                }
            }
        }

        private void ResizeCustomerListView()
        {
            CustomersListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            CustomersListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            CustomersListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            CustomersListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            CustomersListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
            CustomersListView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CustomersListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano klienta");
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string customerid = CustomersListView.SelectedItems[0].SubItems[0].Text;
                        this.objConnect.Sql = Properties.Settings.Default.SelectCustomerByID.Replace("[id]", customerid);
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.ResetCustomer();
                        this.ResizeCustomerListView();
                        this.FillCustomerList(Properties.Settings.Default.SelectAllFromCustomers);

                        this.objConnect.Sql = Properties.Settings.Default.GetRentingRecordByCustomerId.Replace("[id]", customerid);
                        dataSet = objConnect.GetConnection;
                        var rows = dataSet.Tables[0].Rows;
                        List<string> dvdids = new List<string>();
                        foreach (DataRow row in rows)
                        {
                            dvdids.Add(objConnect.GetValue(row, 2));
                            row.Delete();
                        }
                        objConnect.UpdateDatabase(dataSet);

                        foreach (var dvd in dvdids)
                        {
                            this.objConnect.Sql = Properties.Settings.Default.SelectDVDsById.Replace("[id]", dvd);
                            dataSet = objConnect.GetConnection;
                            rows = dataSet.Tables[0].Rows;
                            foreach (DataRow row in rows)
                            {
                                row.BeginEdit();
                                row[2] = "Dostepny";
                                row.EndEdit();
                            }
                            objConnect.UpdateDatabase(dataSet);
                        }
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
            if (CustomersListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano klienta");
            else
            {
                if (this.CustomerIsCorrect() == false) MessageBox.Show("Błędnie wypełniony rekord");
                else
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectCustomerByID.Replace("[id]", CustomersListView.SelectedItems[0].SubItems[0].Text);
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var dataTable = dataSet.Tables[0];
                        var row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[1] = NameTextBox.Text.Trim();
                        row[2] = SurnameTextBox.Text.Trim();
                        row[3] = PeselTextBox.Text.Trim();
                        row[4] = PhoneTextBox.Text.Trim();
                        row[5] = AddressTextBox.Text.Trim();
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        this.ResizeCustomerListView();
                        this.FillCustomerList(Properties.Settings.Default.SelectAllFromCustomers);
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: EditButton_Click");
                    }
                }
            }
        }

        private void FindCustomersButton_Click(object sender, EventArgs e)
        {
            string command = Properties.Settings.Default.SearchCustomers
                .Replace("[name]", NameTextBox.Text.Trim())
                .Replace("[surname]", SurnameTextBox.Text.Trim())
                .Replace("[pesel]", PeselTextBox.Text.Trim())
                .Replace("[phone]", PhoneTextBox.Text.Trim())
                .Replace("[address]", AddressTextBox.Text.Trim());
            FillCustomerList(command);
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {

            if (CustomersListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano klienta");
            else
            {
                Borrow form = new Borrow(CustomersListView.SelectedItems[0].SubItems[0].Text);
                form.Show();
            }
        }
    }
}
