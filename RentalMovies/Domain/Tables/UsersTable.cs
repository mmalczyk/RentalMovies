using RentalMovies.HelperClasses;
using System;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class UsersTable : DataTableObject
    {
        public DataRowCollection GetSortedUserList(String baseSQL, Role role)
        {
            string sql = Properties.Resources.SelectAllFromUsers;
            if (role != null)
                sql += Properties.Settings.Default.OrderBy + role.ToString();
            this.objConnect.Sql = sql;
            DataSet dataSet = objConnect.GetConnection;
            return dataSet.Tables[0].Rows;
        }
    }
}
