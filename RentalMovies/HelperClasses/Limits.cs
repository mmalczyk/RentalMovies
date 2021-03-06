﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies
{
    public static class Limits
    {
        public static string OverdueLimit
        {
            get
            {
                var objConnect = DatabaseConnection.SoleInstance;
                objConnect.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
                objConnect.Sql = Properties.Settings.Default.GetLimits;
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var dataTable = dataSet.Tables[0];
                var row = dataSet.Tables[0].Rows[0];
                return objConnect.GetValue(row, 1);
            }
        }

        public static string TimeLimit
        {
            get
            {
                var objConnect = DatabaseConnection.SoleInstance;
                objConnect.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;
                objConnect.Sql = Properties.Settings.Default.GetLimits;
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var dataTable = dataSet.Tables[0];
                var row = dataSet.Tables[0].Rows[0];
                return objConnect.GetValue(row, 2);
            }
        }
    }
}
