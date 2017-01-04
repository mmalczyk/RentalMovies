using System.Data;

namespace RentalMovies.Domain
{
    public abstract class DataTableObject<T> where T: AbstractActiveRecord
    {
        protected DatabaseConnection objConnect = DatabaseConnection.SoleInstance;
        protected string selectByIdSql;
        protected string selectAll;
        protected string idParameter;

        public T SelectById(string id)
        {
            return RowToDataObject(Select(id));
        }

        public DataRow Select(string id)
        {
            objConnect.Sql = selectByIdSql;
            objConnect.AddParameter(idParameter, id);
            DataSet dataSet = objConnect.GetDataSet();
            return dataSet.Tables[0].Rows[0];
        }

        public void Add(T obj)
        {
            objConnect.Sql = selectAll;
            DataSet dataSet = objConnect.GetDataSet();
            var dataTable = dataSet.Tables[0];
            var row = dataTable.NewRow();
            PopulateRow(obj, ref row, true);
            dataTable.Rows.Add(row);
            objConnect.UpdateDatabase(dataSet);
        }

        public void Delete(string id)
        {
            objConnect.Sql = selectByIdSql;
            objConnect.AddParameter(idParameter, id);
            DataSet dataSet = objConnect.GetDataSet();
            dataSet.Tables[0].Rows[0].Delete();
            objConnect.UpdateDatabase(dataSet);
        }

        public void Update(T obj)
        {
            objConnect.Sql = selectByIdSql;
            string parameter = obj.Id;
            objConnect.AddParameter(idParameter, parameter);
            DataSet dataSet = objConnect.GetDataSet();
            var dataTable = dataSet.Tables[0];
            var row = dataSet.Tables[0].Rows[0];
            row.BeginEdit();
            PopulateRow(obj, ref row, false);
            row.EndEdit();
            objConnect.UpdateDatabase(dataSet);

        }

        public abstract void PopulateRow(T obj, ref DataRow row, bool isNew);

        public abstract T RowToDataObject(DataRow row);


    }
}
