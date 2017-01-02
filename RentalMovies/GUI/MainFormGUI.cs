using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using RentalMovies.Domain.Records;

namespace RentalMovies
{
    public partial class MainForm : Base
    {
        private User user;

        private void CorrectTables()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
            SqlCommand command;
/*
            command = new SqlCommand("CREATE TABLE Movies (moviesid int NOT NULL PRIMARY KEY, title nvarchar(MAX), releaseYear int, country nvarchar(MAX), cost int, description nvarchar(MAX));", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
 */
            /*
            command = new SqlCommand("CREATE TABLE Limits (it int NOT NULL PRIMARY KEY, overdue int NOT NULL, timelimit int NOT NULL)", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
             */
            /*
            command = new SqlCommand("INSERT INTO Limits Values (1, 0, 2)", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
             */
            command = new SqlCommand("Drop table RentingRecord", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command = new SqlCommand("CREATE TABLE RentingRecord (id int NOT NULL PRIMARY KEY, customerId int NOT NULL, dvdid int NOT NULL, date datetime NOT NULL)", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ResetForm();

            passwordTextBox.PasswordChar = '*';
            passwordTextBox.MaxLength = 10;
        }


        private void ResetForm()
        {
            MoviesButton.Enabled = false;
            CustomersButton.Enabled = false;
            TagsButton.Enabled = false;
            UsersButton.Enabled = false;
            AdministrationButton.Enabled = false;
            MyAccountButton.Enabled = false;

            loginTextBox.Enabled = true;
            passwordTextBox.Enabled = true;
            loginButton.Enabled = true;
            logoutButton.Enabled = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.objConnect.Sql = Properties.Settings.Default.SelectUser.Replace("[login]", loginTextBox.Text).Replace("[password]", passwordTextBox.Text);
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    //Próba zalogowania odrzucona
                    loginErrorLabel.Text = "Błędny login lub hasło";
                }
                else
                {
                    loginErrorLabel.Text = "";
                    loginTextBox.Text = "";
                    passwordTextBox.Text = "";
                    loginTextBox.Enabled = false;
                    passwordTextBox.Enabled = false;
                    loginButton.Enabled = false;
                    logoutButton.Enabled = true;

                    //Zalogowany; przydzielanie uprawnień
                    User user = new User(dataSet.Tables[0].Rows[0]);
                    this.user = user;
                    if (user.Job.CompareTo("Edytor") == 0)
                    {
                        MoviesButton.Enabled = true;
                        CustomersButton.Enabled = false;
                        TagsButton.Enabled = true;
                        UsersButton.Enabled = false;
                        AdministrationButton.Enabled = false;
                        MyAccountButton.Enabled = true;
                    }
                    if (user.Job.CompareTo("Kasjer") == 0)
                    {
                        MoviesButton.Enabled = true;
                        CustomersButton.Enabled = true;
                        TagsButton.Enabled = false;
                        UsersButton.Enabled = false;
                        AdministrationButton.Enabled = false;
                        MyAccountButton.Enabled = true;

                    }
                    if (user.Job.CompareTo("Manager") == 0)
                    {
                        MoviesButton.Enabled = true;
                        CustomersButton.Enabled = true;
                        TagsButton.Enabled = true;
                        UsersButton.Enabled = false;
                        AdministrationButton.Enabled = true;
                        MyAccountButton.Enabled = true;

                    }
                    if (user.Job.CompareTo("Admin") == 0)
                    {
                        MoviesButton.Enabled = false;
                        CustomersButton.Enabled = false;
                        TagsButton.Enabled = false;
                        UsersButton.Enabled = true;
                        AdministrationButton.Enabled = false;
                        MyAccountButton.Enabled = true;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: loginButton_Click");
            }
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            Movies form = new Movies(this.user);
            form.Show();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Customers form = new Customers();
            form.Show();
        }

        private void TagsButton_Click(object sender, EventArgs e)
        {
            Tags form = new Tags();
            form.Show();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            Users form = new Users();
            form.Show();
        }

        private void AdministrationButton_Click(object sender, EventArgs e)
        {
            Administration form = new Administration();
            form.Show();
        }

        private void MyAccountButton_Click(object sender, EventArgs e)
        {
            MyAccount form = new MyAccount(this.user);
            form.Show();
        }

    }
}
