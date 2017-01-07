using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class MoviesTable : DataTableObject<Movie>
    {
        public override void PopulateRow(Movie obj, ref DataRow row, bool isNew)
        {
            throw new NotImplementedException();
        }

        public override Movie RowToDataObject(DataRow row)
        {
            throw new NotImplementedException();
        }

        public override Movie Select(string id)
        {
            throw new NotImplementedException();
        }
    }
}
