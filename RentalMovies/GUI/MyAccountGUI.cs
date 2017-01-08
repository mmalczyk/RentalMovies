using RentalMovies.Domain.Records;
using RentalMovies.Domain.Tables;
using System;
using System.Windows.Forms;

namespace RentalMovies
{
    public partial class MyAccount : Base
    {
        private User user;
        private UsersTable usersTable;

        public MyAccount(User user)
        {
            this.user = user;
            UsersTable usersTable = new UsersTable();
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            CurrentPasswordTextBox.PasswordChar = '*';
            CurrentPasswordTextBox.MaxLength = 10;
            NewPasswordTextBox.PasswordChar = '*';
            NewPasswordTextBox.MaxLength = 10;
            RepeatedPasswordTextBox.PasswordChar = '*';
            RepeatedPasswordTextBox.MaxLength = 10;

            FillUserBoxes();
        }

        private void FillUserBoxes()
        {
            UserIDTextBox.Text = user.Id;
            UserNameTextBox.Text = user.Name;
            UserSurnameTextBox.Text = user.Surname;
            UserLoginTextBox.Text = user.Login;
            UserJobTextBox.Text = user.Job;
        }

        private void SavePasswordButton_Click(object sender, EventArgs e)
        {
            if (NewPasswordTextBox.Text.CompareTo(RepeatedPasswordTextBox.Text) != 0) PasswordChangeLabel.Text = "Błędnie powtórzone hasło";
            else
            {
                try
                {
                    user = usersTable.FindUser(user.Login, CurrentPasswordTextBox.Text);

                    /*
                    objConnect.Sql = Properties.Settings.Default.SelectUser.Replace("[password]", CurrentPasswordTextBox.Text).Replace("[login]", user.Login);
                    System.Data.DataSet dataSet = objConnect.GetDataSet();
                    if (dataSet.Tables[0].Rows.Count == 0) PasswordChangeLabel.Text = "Błędne stare hasło";
                    */
                    if (user == null)
                        PasswordChangeLabel.Text = "Błędne stare hasło";
                    else
                    {
                        user.Password = NewPasswordTextBox.Text;
                        usersTable.Update(user);
                        /*
                        var dataRow = dataSet.Tables[0].Rows[0];
                        dataRow.BeginEdit();
                        dataRow[4] = NewPasswordTextBox.Text;
                        dataRow.EndEdit();
                        objConnect.UpdateDatabase(dataSet);
                        */
                        PasswordChangeLabel.Text = "";
                        CurrentPasswordTextBox.Text = "";
                        NewPasswordTextBox.Text = "";
                        MessageBox.Show("Hasło zostało zmienione.");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\nError: SavePasswordButton_Click");
                }
            }
        }
    }
}
