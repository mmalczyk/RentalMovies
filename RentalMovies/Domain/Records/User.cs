using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Records
{
    public class User : ActiveRecord
    {
        private string job;
        private string forename;
        private string login;
        private string password;
        private string surname;
        private string userID;

        public User() { }
        public User(DataRow user)
        {
            init(user);
        }

        public string Forename
        {
            get
            {
                return forename;
            }

            set
            {
                forename = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string Job
        {
            get
            {
                return job;
            }

            set
            {
                job = value;
            }
        }

        public override void init(DataRow user)
        {
            this.UserID = user.ItemArray.GetValue(0).ToString().Trim();
            this.Forename = user.ItemArray.GetValue(1).ToString().Trim();
            this.Surname = user.ItemArray.GetValue(2).ToString().Trim();
            this.Login = user.ItemArray.GetValue(3).ToString().Trim();
            this.Password = user.ItemArray.GetValue(4).ToString().Trim();
            this.Job = user.ItemArray.GetValue(5).ToString().Trim();
        }

        public override string[] toArray()
        {
            return new string[] { UserID.Trim(), Forename, Surname, Login, Job };
        }
    }
}
