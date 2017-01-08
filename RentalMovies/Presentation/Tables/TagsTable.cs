
using RentalMovies.Domain.Records;
using System;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class TagsTable : DataTableObject<DVDTag>
    {
        private const string categoryParameter = "@category";

        public TagsTable()
        {
            selectByIdSql = Properties.Resources.SelectTagByID;
            selectAll = Properties.Resources.SelectAllTags;
            idParameter = "@id";
        }

        public DataRowCollection SelectSorted(string category)
        {
            objConnect.Sql = Properties.Resources.SelectAllTagsOfGenre;
            objConnect.AddParameter(categoryParameter, category);
            DataSet dataSet = objConnect.GetDataSet();
            return dataSet.Tables[0].Rows;

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
            throw new NotImplementedException();
        }

        public override void Add(DVDTag obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(DVDTag id)
        {
            throw new NotImplementedException();
        }

        public override void Update(DVDTag obj)
        {
            throw new NotImplementedException();
        }
    }
}
