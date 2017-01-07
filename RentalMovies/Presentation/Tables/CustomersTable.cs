using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class CustomersTable : DataTableObject<Customer>
    {
        public override void PopulateRow(Customer obj, ref DataRow row, bool isNew)
        {
            throw new NotImplementedException();
        }

        public override Customer RowToDataObject(DataRow row)
        {
            throw new NotImplementedException();
        }

        public override Customer Select(string id)
        {
            throw new NotImplementedException();
        }
    }
}
