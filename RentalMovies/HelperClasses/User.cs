using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies
{
    public class User
    {
        public string userID, forename, surname, login, password, job;

        public User(DataRow user)
        {
            this.userID = user.ItemArray.GetValue(0).ToString().Trim();
            this.forename = user.ItemArray.GetValue(1).ToString().Trim();
            this.surname = user.ItemArray.GetValue(2).ToString().Trim();
            this.login = user.ItemArray.GetValue(3).ToString().Trim();
            this.password = user.ItemArray.GetValue(4).ToString().Trim();
            this.job = user.ItemArray.GetValue(5).ToString().Trim();
        }
    }
}
