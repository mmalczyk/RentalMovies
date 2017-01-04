using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Records
{
    public class Renting : AbstractActiveRecord
    {
        private string customerId;
        private string roomID;
        private string date;

        public Renting()
        {
            DataObjectType = DataObjectType.Renting;
        }

        public string CustomerId
        {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
        }

        public string RoomID
        {
            get
            {
                return roomID;
            }

            set
            {
                roomID = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public override string[] toArray()
        {
            throw new NotImplementedException();
        }

        public override void init(DataRow dataRow)
        {
            throw new NotImplementedException();
        }
    }
}
