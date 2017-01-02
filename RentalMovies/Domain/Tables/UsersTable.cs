using RentalMovies.Domain.Records;
using RentalMovies.HelperClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class UsersTable : DataTableObject
    {
        string idParameter = "@userId";
        private string basicSort = " userId ASC ";
        private string sortUserByNameAsc = " forename ASC ";
        private string sortUserByNameDesc = " forename DESC ";
        private string sortUserBySurnameAsc = " surname ASC ";
        private string sortUserBySurnameDesc = " surname DESC ";
        private string sortUserByJobAsc = " job ASC ";
        private string sortUserByJobDesc = " job DESC ";

        public string BasicSort
        {
            get
            {
                return basicSort;
            }
        }

        public string SortUserByNameAsc
        {
            get
            {
                return sortUserByNameAsc;
            }
        }

        public string SortUserByNameDesc
        {
            get
            {
                return sortUserByNameDesc;
            }
        }

        public string SortUserBySurnameAsc
        {
            get
            {
                return sortUserBySurnameAsc;
            }
        }

        public string SortUserBySurnameDesc
        {
            get
            {
                return sortUserBySurnameDesc;
            }
        }

        public string SortUserByJobAsc
        {
            get
            {
                return sortUserByJobAsc;
            }
        }

        public string SortUserByJobDesc
        {
            get
            {
                return sortUserByJobDesc;
            }
        }

        public DataRowCollection GetSortedUserList(string order)
        {
            string sql = Properties.Resources.SelectAllFromUsers;
            if (order != null)
                sql += Properties.Settings.Default.OrderBy + order;
            objConnect.Sql = sql;
            DataSet dataSet = objConnect.GetConnection;
            return dataSet.Tables[0].Rows;
        }

        public User SelectUserById(string id)
        {
            objConnect.Sql = Properties.Resources.SelectUserById;
            objConnect.AddParameter(idParameter, id);
            DataSet dataSet = objConnect.GetConnection;
            return new User(dataSet.Tables[0].Rows[0]);
        }

        public void DeleteUser(string id)
        {
            objConnect.Sql = Properties.Resources.SelectUserById;
            objConnect.AddParameter(idParameter, id);
            DataSet dataSet = objConnect.GetConnection;
            dataSet.Tables[0].Rows[0].Delete();
            objConnect.UpdateDatabase(dataSet);
        }

        public void AddUser(User user)
        {
            objConnect.Sql = Properties.Resources.SelectAllFromUsers;
            DataSet dataSet = objConnect.GetConnection;
            var dataTable = dataSet.Tables[0];
            var row = dataTable.NewRow();
            row[0] = objConnect.GetNewID();
            row[1] = user.Forename;
            row[2] = user.Surname;
            row[3] = user.Login;
            row[4] = user.Password;
            row[5] = user.Job;
            dataTable.Rows.Add(row);
            objConnect.UpdateDatabase(dataSet);
        }

        public void UpdateUser(User user)
        {
            objConnect.Sql = Properties.Resources.SelectUserById;
            objConnect.AddParameter(idParameter, user.UserID);
            DataSet dataSet = objConnect.GetConnection;
            var dataTable = dataSet.Tables[0];
            var row = dataSet.Tables[0].Rows[0];
            row.BeginEdit();
            row[1] = user.Forename;
            row[2] = user.Surname;
            row[3] = user.Login;
            row[4] = user.Password;
            row[5] = user.Job;
            row.EndEdit();
            objConnect.UpdateDatabase(dataSet);

        }
    }


}
