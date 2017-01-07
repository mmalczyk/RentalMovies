using RentalMovies.Domain.Records;
using System;
using System.Data;

namespace RentalMovies.Domain.Mapper
{
    public class TagMapper : AbstractMapper<DVDTag>
    {
        public override DataRow mapObjToRow(DVDTag obj)
        {
            throw new NotImplementedException();
        }

        public override DVDTag mapRowToObj(DataRow row)
        {
            DVDTag obj = new DVDTag();
            obj.Id = MapperUtils.GetValue(row, 0);
            obj.Name = MapperUtils.GetValue(row, 1);
            obj.Category = MapperUtils.GetValue(row, 2);
            return obj;
        }

        protected override void initColumnNames()
        {
            columnNames.Add("id");
            columnNames.Add("name");
            columnNames.Add("category");
        }

        protected override void initTableName()
        {
            tableName = "Tags";
        }

        protected override void initDataType()
        {
            dataType = DataObjectType.DVDTag;
        }
    }
}
