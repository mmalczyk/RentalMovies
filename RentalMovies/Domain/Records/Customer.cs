using System.Data;

namespace RentalMovies.Domain.Records
{
    public class Customer : AbstractActiveRecord
    {
        private string name;
        private string surname;
        private string pesel;
        private string phone;
        private string address;

        public Customer()
        {
            DataObjectType = DataObjectType.Customer;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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

        public string Pesel
        {
            get
            {
                return pesel;
            }

            set
            {
                pesel = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public override string[] toArray()
        {
            return new string[] { id, name, surname, pesel, phone, address };
        }

        public override void init(DataRow row)
        {
            id = row.ItemArray.GetValue(0).ToString().Trim();
            name = row.ItemArray.GetValue(1).ToString().Trim();
            surname = row.ItemArray.GetValue(2).ToString().Trim();
            pesel = row.ItemArray.GetValue(3).ToString().Trim();
            phone = row.ItemArray.GetValue(4).ToString().Trim();
            address = row.ItemArray.GetValue(5).ToString().Trim();
        }
    }
}
