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
            ResetUser();

            UsersListView.View = View.Details;
            UsersListView.Columns.Add(Resources.Strings.userIdText, -2, HorizontalAlignment.Left);

            UsersListView.Columns.Add(Resources.Strings.userNameText, -2, HorizontalAlignment.Left);
            UsersListView.Columns.Add(Resources.Strings.userSurnameText, -2, HorizontalAlignment.Left);
            UsersListView.Columns.Add(Resources.Strings.userLoginText, -2, HorizontalAlignment.Left);
            UsersListView.Columns.Add(Resources.Strings.userRoleText, -2, HorizontalAlignment.Left);

            FillUserList();

            ResizeUserListView();

            GUITools.LoadRoles(ref UserJobTextBox2, Role.getRoles());
        }


        private void FillUserList()
        {
            GUITools.FillList(ref UsersListView, usersTable.SelectSorted(GetCheckedOrder()), new User(), Resources.Strings.errorMessage+"FillUserList");
        }

        private User GetUserById()
        {
            var listItems = UsersListView.SelectedItems;
            if (listItems != null && listItems.Count > 0)
                return usersTable.SelectById(listItems[0].Text);
            return null;
        }

        private string GetCheckedOrder()
        {
            if (SortUserByNameAsc.Checked == true) return usersTable.SortUserByNameAsc;
            if (SortUserByNameDesc.Checked == true) return usersTable.SortUserByNameDesc;
            if (SortUserBySurnameAsc.Checked == true) return usersTable.SortUserBySurnameAsc;
            if (SortUserBySurnameDesc.Checked == true) return usersTable.SortUserBySurnameDesc;
            if (SortUserByJobAsc.Checked == true) return usersTable.SortUserByJobAsc;
            if (SortUserByJobDesc.Checked == true) return usersTable.SortUserByJobDesc;
            return usersTable.BasicSort;
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
            FillUserTextBoxes(GetUserById());
        }

        private void FillUserTextBoxes(User user)
        {
            if (user != null)
            {
                UserIDTextBox2.Text = user.Id;
                UserNameTextBox2.Text = user.Forename;
                UserSurnameTextBox2.Text = user.Surname;
                UserLoginTextBox2.Text = user.Login;
                UserPasswordTextBox2.Text = user.Password;
                UserJobTextBox2.Text = user.Job;
            }
        }

        private void UserResetButton_Click(object sender, EventArgs e)
        {
            ResetUser();
        }

        private void SortUserByNameAsc_CheckedChanged(object sender, EventArgs e)
        {
            FillUserList();
        }

        private void SortUserByNameDesc_CheckedChanged(object sender, EventArgs e)
        {
            FillUserList();
        }

        private void SortUserBySurnameAsc_CheckedChanged(object sender, EventArgs e)
        {
            FillUserList();
        }

        private void SortUserBySurnameDesc_CheckedChanged(object sender, EventArgs e)
        {
            FillUserList();
        }

        private void SortUserByJobAsc_CheckedChanged(object sender, EventArgs e)
        {
            FillUserList();
        }

        private void SortUserByJobDesc_CheckedChanged(object sender, EventArgs e)
        {
            FillUserList();
        }

        private User CollectUser()
        {
            User user = new User(
                UserNameTextBox2.Text.Trim(),
                UserSurnameTextBox2.Text.Trim(),
                UserLoginTextBox2.Text.Trim(),
                UserPasswordTextBox2.Text.Trim(),
                UserJobTextBox2.Text.Trim());
            user.Id = UserIDTextBox2.Text.Trim();
            return user;
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            User user = CollectUser();
            if (user.ErrorMessage > 0)
                MessageBox.Show(Resources.Strings.badRecordMessage);
            else
                usersTable.Add(user);
            FillUserList();
            ResizeUserListView();
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
            if (UsersListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.noUserPickedMessage);
            {
                if (MessageBox.Show(Resources.Strings.confirmDeleteMessage, Resources.Strings.confirmButtonMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    usersTable.Delete(UserIDTextBox2.Text.Trim());
                    ResetUser();
                    FillUserList();
                    ResizeUserListView();
                }
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (UsersListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.noUserPickedMessage);
            else
            {
                User user = CollectUser();
                if (user.ErrorMessage > 0)
                    MessageBox.Show(Resources.Strings.badRecordMessage);
                else
                {
                    usersTable.Update(user);
                    FillUserList();
                    this.ResizeUserListView();
                }
            }
        }
    }
}
