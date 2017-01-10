using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Records
{
    public class DVD : AbstractActiveRecord
    {
        private string movieId;
        private string status;

        public DVD()
        {
            DataObjectType = DataObjectType.DVD;
        }

        public string MovieId
        {
            get
            {
                return movieId;
            }

            set
            {
                movieId = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public override void init(DataRow row)
        {
            id = row.ItemArray.GetValue(0).ToString().Trim();
            MovieId = row.ItemArray.GetValue(1).ToString().Trim();
            Status = row.ItemArray.GetValue(2).ToString().Trim();
        }

        public override string[] toArray()
        {
            return new string[] { id, MovieId, Status };
        }
    }
}
