using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Mapper
{
    public class DVDMapper : AbstractMapper<DVD>
    {
        public override DataRow mapObjToRow(DVD obj)
        {
            throw new NotImplementedException();
        }

        public override DVD mapRowToObj(DataRow row)
        {
            DVD obj = new DVD();
            obj.Id = MapperUtils.GetValue(row, 0);
            obj.MovieId = MapperUtils.GetValue(row, 1);
            obj.Status = MapperUtils.GetValue(row, 2);
            return obj;
        }

        protected override void initColumnNames()
        {
            columnNames.Add("id");
            columnNames.Add("movieId");
            columnNames.Add("status");
        }

        protected override void initTableName()
        {
            tableName = "Tags";
        }

        protected override void initDataType()
        {
            dataType = DataObjectType.DVD;
        }
    }
}
