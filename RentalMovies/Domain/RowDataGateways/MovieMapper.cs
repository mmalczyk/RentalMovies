using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Mapper
{
    public class MovieMapper : AbstractMapper<Movie>
    {
        public override DataRow mapObjToRow(Movie obj)
        {
            throw new NotImplementedException();
        }

        public override Movie mapRowToObj(DataRow row)
        {
            Movie obj = new Movie();
            obj.Id = MapperUtils.GetValue(row, 0);
            obj.Title = MapperUtils.GetValue(row, 1);
            obj.ReleaseYear = MapperUtils.GetValue(row, 2);
            obj.Country = MapperUtils.GetValue(row, 3);
            obj.Cost = MapperUtils.GetValue(row, 4);
            obj.Description = MapperUtils.GetValue(row, 5);
            return obj;
        }

        protected override void initColumnNames()
        {
            columnNames.Add("id");
            columnNames.Add("title");
            columnNames.Add("releaseYear");
            columnNames.Add("country");
            columnNames.Add("cost");
            columnNames.Add("description");
        }

        protected override void initTableName()
        {
            tableName = "Movies";
        }

        protected override void initDataType()
        {
            dataType = DataObjectType.Movie;
        }
    }
}
