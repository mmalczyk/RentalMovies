using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Tables
{
    public class RentingTable : DataTableObject<Renting>
    {
        public override void PopulateRow(Renting obj, ref DataRow row, bool isNew)
        {
            throw new NotImplementedException();
        }

        public override Renting RowToDataObject(DataRow row)
        {
            throw new NotImplementedException();
        }

        public override Renting Select(string id)
        {
            throw new NotImplementedException();
        }
    }
}
