using RentalMovies.Domain.Records;
using RentalMovies.Domain.Tables;
using RentalMovies.GUI;
using RentalMovies.HelperClasses;
using System;
using System.Windows.Forms;

namespace RentalMovies
{
    public partial class Users : Base
    {
        private UsersTable usersTable;

        public Users()
        {
            InitializeComponent();
            usersTable = new UsersTable();
            usersTable.SetObjConnect(ref objConnect);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.ResetUser();

            UsersListView.View = View.Details;
            UsersListView.Columns.Add("Id", -2, HorizontalAlignment.Left);

            UsersListView.Columns.Add("Imię", -2, HorizontalAlignment.Left);
            UsersListView.Columns.Add("Nazwisko", -2, HorizontalAlignment.Left);
            UsersListView.Columns.Add("Login", -2, HorizontalAlignment.Left);
            UsersListView.Columns.Add("Rola", -2, HorizontalAlignment.Left);

            GUITools.FillList(ref UsersListView, usersTable.GetSortedUserList(this.FindCheckedUserRadioButton(), null), new User(), "Error: FillUserList");

            this.ResizeUserListView();

            GUITools.LoadRoles(ref UserJobTextBox2, Role.getRoles());
        }


        private void FillUserList(String c)
        {
           //database
           this.objConnect.Sql = c + Properties.Settings.Default.OrderBy + this.FindCheckedUserRadioButton();
           System.Data.DataSet dataSet = objConnect.GetConnection;
           var userList = dataSet.Tables[0].Rows;

            GUITools.FillList(ref UsersListView, userList, new User(), "Error: FillUserList");
        }

        private string FindCheckedUserRadioButton()
        {
            if (SortUserByNameAsc.Checked == true) return "forename ASC";
            if (SortUserByNameDesc.Checked == true) return "forename DESC";
            if (SortUserBySurnameAsc.Checked == true) return "surname ASC";
            if (SortUserBySurnameDesc.Checked == true) return "surname DESC";
            if (SortUserByJobAsc.Checked == true) return "job ASC";
            if (SortUserByJobDesc.Checked == true) return "job DESC";
            return "userId ASC";
        }

        private bool UserIsCorrect()
        {
            if (UserNameTextBox2.Text == null) return false;
            if (UserSurnameTextBox2.Text == null) return false;
            if (UserLoginTextBox2.Text == null) return false;
            if (UserPasswordTextBox2.Text == null) return false;
            if (UserJobTextBox2.Text == null) return false;
            if (UserNameTextBox2.Text.Trim().CompareTo("") == 0) return false;
            if (UserSurnameTextBox2.Text.Trim().CompareTo("") == 0) return false;
            if (UserLoginTextBox2.Text.Trim().CompareTo("") == 0) return false;
            if (UserPasswordTextBox2.Text.Trim().CompareTo("") == 0) return false;
            if (UserJobTextBox2.SelectedIndices.Count == 0) return false;
            return true;
        }

        private void ResetUser()
        {
            UserIDTextBox2.Clear();
            UserNameTextBox2.Clear();
            UserSurnameTextBox2.Clear();
            UserLoginTextBox2.Clear();
            UserPasswordTextBox2.Clear();
            UserJobTextBox2.SelectedIndices.Clear();

            SortUserByNameAsc.Checked = false;
            SortUserByNameDesc.Checked = false;
            SortUserBySurnameAsc.Checked = false;
            SortUserBySurnameDesc.Checked = false;
            SortUserByJobAsc.Checked = false;
            SortUserByJobDesc.Checked = false;
        }

        private void UsersListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.UsersListView.SelectedItems;
                if (listItem != null && listItem.Count > 0) FillUserTextBoxes(Properties.Settings.Default.SelectUserByID.Replace("[id]", listItem[0].Text));
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: UsersListView_ItemSelectionChanged");
            }
        }

        private void FillUserTextBoxes(String c)
        {
            try
            {
                this.objConnect.Sql = c;
                System.Data.DataSet dataSet = objConnect.GetConnection;
                User user = new User(dataSet.Tables[0].Rows[0]);
                UserIDTextBox2.Text = user.UserID;
                UserNameTextBox2.Text = user.Forename;
                UserSurnameTextBox2.Text = user.Surname;
                UserLoginTextBox2.Text = user.Login;
                UserPasswordTextBox2.Text = user.Password;
                UserJobTextBox2.Text = user.Job;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: FillUserTextBoxes");
            }
        }

        private void UserResetButton_Click(object sender, EventArgs e)
        {
            this.ResetUser();
        }

        private void SortUserByNameAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillUserList(Properties.Resources.SelectAllFromUsers);
        }

        private void SortUserByNameDesc_CheckedChanged(object sender, EventArgs e)
        {
//            this.FillUserList(Properties.Resources.SelectAllFromUsers);
            this.FillUserList(Properties.Resources.SelectAllFromUsers);

        }

        private void SortUserBySurnameAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillUserList(Properties.Resources.SelectAllFromUsers);

        }

        private void SortUserBySurnameDesc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillUserList(Properties.Resources.SelectAllFromUsers);
        }

        private void SortUserByJobAsc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillUserList(Properties.Resources.SelectAllFromUsers);
        }

        private void SortUserByJobDesc_CheckedChanged(object sender, EventArgs e)
        {
            this.FillUserList(Properties.Resources.SelectAllFromUsers);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            if (this.UserIsCorrect() == false) MessageBox.Show("Błędnie wypełniony rekord");
            else
            {
                try
                {
                    this.objConnect.Sql = Properties.Resources.SelectAllFromUsers;
                    System.Data.DataSet dataSet = objConnect.GetConnection;
                    var dataTable = dataSet.Tables[0];
                    var row = dataTable.NewRow();
                    row[0] = objConnect.GetNewID();
                    row[1] = UserNameTextBox2.Text.Trim();
                    row[2] = UserSurnameTextBox2.Text.Trim();
                    row[3] = UserLoginTextBox2.Text.Trim();
                    row[4] = UserPasswordTextBox2.Text.Trim();
                    row[5] = UserJobTextBox2.Text.Trim();
                    dataTable.Rows.Add(row);
                    objConnect.UpdateDatabase(dataSet);
                    this.FillUserList(Properties.Resources.SelectAllFromUsers);
                    this.ResizeUserListView();
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message + "Error: AddUserButton_Click");
                }
            }
        }

        private void ResizeUserListView()
        {
            UsersListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            UsersListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            UsersListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent);
            UsersListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
            UsersListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (UsersListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano użytkownika");
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectUserByID.Replace("[id]", UserIDTextBox2.Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        dataSet.Tables[0].Rows[0].Delete();
                        objConnect.UpdateDatabase(dataSet);
                        this.ResetUser();
                        this.FillUserList(Properties.Resources.SelectAllFromUsers);
                        this.ResizeUserListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: AddUserButton_Click");
                    }
                }
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (UsersListView.SelectedItems.Count == 0) MessageBox.Show("Nie wybrano użytkownika");
            else
            {
                if (this.UserIsCorrect() == false) MessageBox.Show("Błędnie wypełniony rekord");
                else
                {
                    try
                    {
                        this.objConnect.Sql = Properties.Settings.Default.SelectUserByID.Replace("[id]", UserIDTextBox2.Text.Trim());
                        System.Data.DataSet dataSet = objConnect.GetConnection;
                        var dataTable = dataSet.Tables[0];
                        var row = dataSet.Tables[0].Rows[0];
                        row.BeginEdit();
                        row[1] = UserNameTextBox2.Text.Trim();
                        row[2] = UserSurnameTextBox2.Text.Trim();
                        row[3] = UserLoginTextBox2.Text.Trim();
                        row[4] = UserPasswordTextBox2.Text.Trim();
                        row[5] = UserJobTextBox2.Text.Trim();
                        row.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        this.FillUserList(Properties.Resources.SelectAllFromUsers);
                        this.ResizeUserListView();
                    }
                    catch (Exception f)
                    {
                        MessageBox.Show(f.Message + "Error: AddUserButton_Click");
                    }
                }
            }
        }
    }
}
