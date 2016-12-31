using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentalMovies
{
    public class DatabaseConnection
    {
        private string sql;
        private string strCon;
        System.Data.SqlClient.SqlDataAdapter daUsers;

        public string Sql
        {
            set { this.sql = value; }
        }

        public string ConnectionString
        {

            set { this.strCon = value; }
        }

        public System.Data.DataSet GetConnection
        {

            get { return DataSet(); }

        }

        private System.Data.DataSet DataSet()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            con.Open();
            daUsers = new System.Data.SqlClient.SqlDataAdapter(sql, con);
            System.Data.DataSet dataSet = new System.Data.DataSet();
            daUsers.Fill(dataSet, "dataSet");
            con.Close();
            return dataSet;
        }

        public void UpdateDatabase(System.Data.DataSet dataSet)
        {
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(daUsers);
            cb.DataAdapter.Update(dataSet.Tables[0]);
        }

        public string GetNewID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
                SqlCommand command = new SqlCommand(Properties.Settings.Default.NewId, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                string newID = reader.GetValue(0).ToString();
                reader.Close();
                connection.Close();
                return newID;
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: GetNewID");
                return "";
            }
        }

        public string GetValue(DataRow row, int i)
        {
            return row.ItemArray[i].ToString().Trim();
        }

    }
}
