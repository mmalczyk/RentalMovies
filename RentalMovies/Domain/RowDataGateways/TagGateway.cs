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

        public override void Insert(DVDTag obj)
        {
            string newId = objConnect.GetNewID();
            obj.Id = newId;
            InsertParameters.Add("@1", newId);
            InsertParameters.Add("@2", obj.Name);
            InsertParameters.Add("@3", obj.Category);
            base.Insert(obj);
        }

        public override void Update(DVDTag obj)
        {
            UpdateParameters.Add("@1", obj.Id);
            UpdateParameters.Add("@2", obj.Name);
            UpdateParameters.Add("@3", obj.Category);
            UpdateParameters.Add("@4", obj.Id);
            base.Update(obj);
        }

        override protected void initFindAllSQL()
        {
            findAllSQL = " SELECT * FROM Tags WHERE Category = @1 ORDER BY Name ";
        }


    }
}
