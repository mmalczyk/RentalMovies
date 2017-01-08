using System.Data;

namespace RentalMovies.Domain
{
    public abstract class DataTableObject<T> where T: AbstractActiveRecord
    {
        protected DatabaseConnection objConnect = DatabaseConnection.SoleInstance;
        protected string selectByIdSql;
        protected string selectAll;
        protected string idParameter;

        public abstract T Select(string id);

        public abstract void Add(T obj);

        public abstract void Delete(T id);

        public abstract void Update(T obj);

        public abstract void PopulateRow(T obj, ref DataRow row, bool isNew);

        public abstract T RowToDataObject(DataRow row);


    }
}
