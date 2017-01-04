using System;
using System.Data;

namespace RentalMovies.Domain.Records
{
    public class User : AbstractActiveRecord
    {
        private string job;
        private string forename;
        private string login;
        private string password;
        private string surname;

        private byte[] _password;
        private int _errorCode;
        private bool _blocked;
        private DateTime _expiryDate;


        public User() { DataObjectType = DataObjectType.User; }
        public User(DataRow user)
        {
            DataObjectType = DataObjectType.User;
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

        public bool Blocked
        {
            get { return this._blocked; }
            private set { this._blocked = value; }
        }

        public void Block()
        {
            this.Blocked = true;
        }

        public void Unblock()
        {
            this.Blocked = false;
        }


        //brak id jest jednoznaczny z tym, że odpowiednik obiektu nie istnieje w bazie
        //posiadanie id niekoniecznie oznacza, że obiekt jest w bazie - mogło zostać użyte DELETE
        public override void init(DataRow user)
        {
            this.Id = user.ItemArray.GetValue(0).ToString().Trim();
            this.Forename = user.ItemArray.GetValue(1).ToString().Trim();
            this.Surname = user.ItemArray.GetValue(2).ToString().Trim();
            this.Login = user.ItemArray.GetValue(3).ToString().Trim();
            this.Password = user.ItemArray.GetValue(4).ToString().Trim();
            //this.Password = (byte[])user.ItemArray.GetValue(4);
            this.Job = user.ItemArray.GetValue(5).ToString().Trim();

            //this.ExpiryDate = (DateTime)user.ItemArray.GetValue(7);
            //this.Blocked = BitConverter.ToBoolean((byte[])user.ItemArray.GetValue(8), 0);
            this.ErrorMessage = 0;

        }

        public override string[] toArray()
        {
            return new string[] { Id.Trim(), Forename, Surname, Login, Job };
        }

        public DateTime ExpiryDate
        {
            get { return this._expiryDate; }
            private set { this._expiryDate = value; }
        }

        public bool IsExpired
        {
            get { return (this.ExpiryDate.CompareTo(DateTime.Now) < 0) ? true : false; }
        }


        //ErrorMessage !=0 informuje o błędnych polach obiektu User
        public int ErrorMessage
        {
            get { return this._errorCode; }
            private set { this._errorCode = value; }
        }

        //w wypadku błędów wszystkie pola null
        //komunikat błędu dostępny w this.ErrorMessage
        //na tym etapie nie powstaje id, bo obiekt User tworzony tym konstruktorem nie ma odpowiednika w bazie
        //konto jest z założenia expired
        public User(string forename, string surname, string login, string password, string role)
        {
            this.Unblock();
            this.ChangePassword(password);
            this.ExpiryDate = DateTime.Now;
            this.Update(forename, surname, login, role);
        }

        //sprawdza poprawność przed update, w wypadku błędów nie dokonuje aktualizacji
        //komunikat błędu dostępny w this.ErrorMessage        
        public User Update(string forename, string surname, string login, string role)
        {
            this.Forename = forename.Trim();
            this.Surname = surname.Trim();
            this.Login = login.Trim();
            this.Job = role.Trim();
            this.SetErrorCode();
            return this;
        }

        //sprawdza poprawność przed update, w wypadku błędów nie dokonuje aktualizacji
        //komunikat błędu dostępny w this.ErrorMessage
        public User ChangePassword(string password)
        {
            this.CheckPassword(password);
            //this.Password = System.Text.Encoding.Unicode.GetBytes(password.Trim());
            this.Password = password;
            return this;
        }

        //sprawdza poprawność i wyznacza odpowiednie error code
        //kod błędu powyżej 4 oznacza błąd hasła
        private void SetErrorCode()
        {
            if (this.ErrorMessage < 5)
            {
                if (Id == null && this.IsUnique() == false) this.ErrorMessage = 4;
                if (Forename == null || Surname == null || Login == null || Job == null) this.ErrorMessage = 1;
                if (Empty(Forename) || Empty(Surname) || Empty(Login) || Empty(Job)) this.ErrorMessage = 2;
                if (Login.Trim().Length < 3) this.ErrorMessage = 3;
            }
            else this.ErrorMessage = 0;
        }

        //sprawdzanie hasła nie może się odbywać na bieżąco, gdyż są haszowane
        private void CheckPassword(string password)
        {
            if (this.ErrorMessage >= 5) this.SetErrorCode();
            if (password == null) this.ErrorMessage = 5;
            if (Empty(password)) this.ErrorMessage = 6;
            //if ((this.HasUpperCase(password) && this.HasLowerCase(password) && this.HasDigit(password)) == false) this.ErrorMessage = 8;
            //if (password.Length < 7) this.ErrorMessage = 7;
        }

        private bool HasUpperCase(string password)
        {
            foreach (char c in password) if (char.IsUpper(c)) return true;
            return false;
        }

        private bool HasLowerCase(string password)
        {
            foreach (char c in password) if (char.IsLower(c)) return true;
            return false;
        }

        private bool HasDigit(string password)
        {
            foreach (char c in password) if (char.IsDigit(c)) return true;
            return false;
        }

        private static bool Empty(string s)
        {
            return s.Trim().CompareTo("") == 0;
        }


        private bool IsUnique()
        {
            /*
            var usersTable = new TheHotelApp.DataAccessObject.UsersDAO(new DatabaseConnection());
            if (usersTable.SelectByLogin(this) != null) return false;
            else return true;
            */
            return true;
        }


    }
}
