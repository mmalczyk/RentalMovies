using RentalMovies.Domain.Mapper;
using RentalMovies.Domain.Records;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class TagsTable : DataTableObject<DVDTag>
    {
        private TagMapper TagsTableGateway;

        private const string categoryParameter = "@category";

        public TagsTable()
        {
            TagsTableGateway = DataGatewayRegistry.SoleInstance.TagTableGateway;
        }

        public DataRowCollection FindAll(string category)
        {
            TagsTableGateway.FindAllParameters.Add("@1", category);
            return TagsTableGateway.FindAll();
        /*
        objConnect.Sql = Properties.Resources.SelectAllTagsOfGenre;
        objConnect.AddParameter(categoryParameter, category);
        DataSet dataSet = objConnect.GetDataSet();
        return dataSet.Tables[0].Rows;
        */
      }

        override public void PopulateRow(DVDTag tag, ref DataRow row, bool isNew)
        {
            if (isNew)
                row[0] = objConnect.GetNewID();
            row[1] = tag.Name;
            row[2] = tag.Category;
        }

        override public DVDTag RowToDataObject(DataRow row)
        {
            return new DVDTag(row);
        }

        public override DVDTag Select(string id)
        {
            TagsTableGateway.setColumnNames(new string[] { "id" });
            TagsTableGateway.FindParameters.Add("@1", id);
            return TagsTableGateway.Find();
        }

        public override void Add(DVDTag obj)
        {
            TagsTableGateway.Insert(obj);
        }

        public override void Delete(DVDTag obj)
        {
            TagsTableGateway.Delete(obj);
        }

        public override void Update(DVDTag obj)
        {
            TagsTableGateway.Update(obj);
        }
    }
}
