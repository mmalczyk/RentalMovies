using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Mapper
{
    public class RentingMapper : AbstractMapper<Renting>
    {
        public override DataRow mapObjToRow(Renting obj)
        {
            throw new NotImplementedException();
        }

        public override Renting mapRowToObj(DataRow row)
        {
            Renting obj = new Renting();
            obj.Id = MapperUtils.GetValue(row, 0);
            obj.CustomerId = MapperUtils.GetValue(row, 1);
            obj.DVDId = MapperUtils.GetValue(row, 2);
            obj.Date = MapperUtils.GetValue(row, 3);
            return obj;
        }

        protected override void initColumnNames()
        {
            columnNames.Add("id");
            columnNames.Add("customerid");
            columnNames.Add("dvdid");
            columnNames.Add("date");
        }

        protected override void initTableName()
        {
            tableName = "RentingRecord";
        }

        protected override void initDataType()
        {
            dataType = DataObjectType.Renting;
        }
    }
}
