﻿using RentalMovies.Domain.Mapper;
using RentalMovies.Domain.Records;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class UsersTable : DataTableObject<User>
    {
        UserMapper UserTableGateway;

        public UsersTable()
        {
            UserTableGateway = DataGatewayRegistry.SoleInstance.UserTableGateway;

            selectByIdSql = Properties.Resources.SelectUserById;
            selectAll = Properties.Resources.SelectAllFromUsers;
            idParameter = "@id";
        }

        private const string basicSort = " id ASC ";
        private const string sortUserByNameAsc = " name ASC ";
        private const string sortUserByNameDesc = " name DESC ";
        private const string sortUserBySurnameAsc = " surname ASC ";
        private const string sortUserBySurnameDesc = " surname DESC ";
        private const string sortUserByJobAsc = " job ASC ";
        private const string sortUserByJobDesc = " job DESC ";

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

        override public User Select(string id)
        {
            UserTableGateway.setColumnNames(new string[] { "id" });
            UserTableGateway.FindParameters.Add("@1", id);
            return UserTableGateway.Find();
        }

        public User FindUser(string login, string password)
        {
            UserTableGateway.setColumnNames(new string[] { "login", "password" });
            UserTableGateway.FindParameters.Add("@1", login);
            UserTableGateway.FindParameters.Add("@2", password);
            return UserTableGateway.Find();
        }

        override public void Add(User obj)
        {
            UserTableGateway.Insert(obj);
        }

        override public void Delete(User obj)
        {
            UserTableGateway.Delete(obj);
        }

        public DataRowCollection SelectSorted(string order)
        {
            string sql = Properties.Resources.SelectAllFromUsers;
            if (order != null)
                sql += Properties.Settings.Default.OrderBy + order;
            objConnect.Sql = sql;
            DataSet dataSet = objConnect.GetDataSet();
            return dataSet.Tables[0].Rows;
        }

        override public void PopulateRow(User user, ref DataRow row, bool isNew)
        {
            if (isNew)
                row[0] = objConnect.GetNewID();
            row[1] = user.Name;
            row[2] = user.Surname;
            row[3] = user.Login;
            row[4] = user.Password;
            row[5] = user.Job;
        }

        override public User RowToDataObject(DataRow row)
        {
            return new User(row);
        }

    }


}