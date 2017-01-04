using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RentalMovies
{
    public class DatabaseConnection //+Singleton
    {
        private static DatabaseConnection soleInstance;

        private string sql;
        private string strCon;
        private SqlDataAdapter daUsers;
        private Dictionary<string, object> parameters;

        private DatabaseConnection() { }


        public string Sql
        {
            set { sql = value; }
        }

        public string ConnectionString
        {

            set { strCon = value; }
        }

        public static DatabaseConnection SoleInstance
        {
            get
            {
                if (soleInstance == null)
                    soleInstance = new DatabaseConnection();
                return soleInstance;
            }
        }

        public void AddParameter(string name, object value)
        {
            if (parameters == null) parameters = new Dictionary<string, object>();
            parameters.Add(name, value);
        }

        public DataSet GetDataSet()
        {
            
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            if (parameters == null)
                daUsers = new SqlDataAdapter(sql, con);
            else
            {
                SqlCommand command = new SqlCommand(sql, con);
                command.Connection = con;
                command.CommandText = sql;
                foreach (var pair in parameters)
                    command.Parameters.AddWithValue(pair.Key, pair.Value);
                command.CommandType = CommandType.Text;

                daUsers = new SqlDataAdapter(command);

                //wipe parameters after you're done
                parameters = null;
            }

            DataSet dataSet = new DataSet();
            daUsers.Fill(dataSet, "dataSet");
            con.Close();
            return dataSet;
        }

        public void UpdateDatabase(DataSet dataSet)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(daUsers);
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
