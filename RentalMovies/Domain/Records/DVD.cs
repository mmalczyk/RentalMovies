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


        public override void init(DataRow row)
        {
            id = row.ItemArray.GetValue(0).ToString().Trim();
            movieId = row.ItemArray.GetValue(1).ToString().Trim();
            status = row.ItemArray.GetValue(2).ToString().Trim();
        }

        public override string[] toArray()
        {
            return new string[] { id, movieId, status };
        }
    }
}
