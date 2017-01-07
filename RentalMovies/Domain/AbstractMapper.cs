using System.Collections.Generic;
using System.Data;

namespace RentalMovies.Domain
{
    public abstract class AbstractMapper<T> where T: AbstractActiveRecord //+LayerSupertype
    {
        protected static class MapperUtils
        {
            public static string GetValue(DataRow row, int i)
            {
                return row.ItemArray[i].ToString().Trim();
            }
        }

        protected DatabaseConnection objConnect;

        protected string findSQL;
        protected string findAllSQL;
        protected string updateSQL;
        protected string deleteSQL;
        protected string insertSQL;

        private Dictionary<string, string> findParameters;
        private Dictionary<string, string> findAllParameters;
        private Dictionary<string, string> updateParameters;
        private Dictionary<string, string> deleteParameters;
        private Dictionary<string, string> insertParameters;

        protected string idName;
        protected List<string> columnNames;
        protected string tableName;

        protected DataObjectType dataType;

        protected bool online;

        public Dictionary<string, string> FindParameters
        {
            get
            {
                return findParameters;
            }

            set
            {
                findParameters = value;
            }
        }

        public Dictionary<string, string> FindAllParameters
        {
            get
            {
                return findAllParameters;
            }

            set
            {
                findAllParameters = value;
            }
        }

        public Dictionary<string, string> UpdateParameters
        {
            get
            {
                return updateParameters;
            }

            set
            {
                updateParameters = value;
            }
        }

        public Dictionary<string, string> DeleteParameters
        {
            get
            {
                return deleteParameters;
            }

            set
            {
                deleteParameters = value;
            }
        }

        public Dictionary<string, string> InsertParameters
        {
            get
            {
                return insertParameters;
            }

            set
            {
                insertParameters = value;
            }
        }

        protected AbstractMapper()
        {
            online = false;

            objConnect = DatabaseConnection.SoleInstance;

            FindParameters = new Dictionary<string, string>();
            FindAllParameters = new Dictionary<string, string>();
            UpdateParameters = new Dictionary<string, string>();
            DeleteParameters = new Dictionary<string, string>();
            InsertParameters = new Dictionary<string, string>();

            columnNames = new List<string>();

            idName = "id";

            initDataType();
            initTableName();
            initColumnNames();

            initSQLStrings();
        }

        protected void setupConnection(string sql, Dictionary<string, string> parameters)
        {
            objConnect.Sql = sql;
            objConnect.Parameters = parameters;
        }

        public virtual T Find()
        {
            T dataObject = IdentityMap.SoleInstance.Get<T>(dataType, FindParameters["@1"]);
            if (dataObject == null)
            {
                initFindSQL(findParameters.Count);
                setupConnection(findSQL, FindParameters);
                var rows = objConnect.GetDataSet().Tables[0].Rows;
                if (rows.Count > 0)
                {
                    dataObject = mapRowToObj(rows[0]);
                    IdentityMap.SoleInstance.Add(dataObject);
                }
                initColumnNames();
            }
            FindParameters.Clear();
            return dataObject;
        }
        public virtual DataSet FindAll()
        {
            setupConnection(findAllSQL, FindAllParameters);
            FindAllParameters.Clear();
            return objConnect.GetDataSet();
        }

        public virtual void Update(T obj)
        {
            UpdateParameters.Clear();
            objConnect.Execute();
        }

        public virtual void Delete(T obj)
        {
            //TODO identityMap delete
            setupConnection(deleteSQL, DeleteParameters);
            DeleteParameters.Clear();
            objConnect.Execute();
        }

        public virtual void Insert(T obj)
        {
            IdentityMap.SoleInstance.Add(obj);
            setupConnection(insertSQL, InsertParameters);
            InsertParameters.Clear();
            objConnect.Execute();
        }

        private void initSQLStrings()
        {
            initFindSQL();
            initFindAllSQL();
            initUpdateSQL();
            initDeleteSQL();
            initInsert();
        }

        private void initFindSQL(int parameterCount = 0)
        {
            string sql = " SELECT * FROM " + tableName;
            if (parameterCount >= 1)
            {
                sql += " WHERE ";
                int i = 1;
                for (; i <= parameterCount; i++)
                    sql += columnNames[i-1] + " = @" + i + " AND ";
                sql = sql.Substring(0, sql.Length - 4);
            }
            findSQL = sql;
        }

        private void initFindAllSQL()
        {
            string sql = " SELECT * FROM " + tableName + " ORDER BY @1";
            findAllSQL = sql;
        }

        private void initUpdateSQL()
        {
            initColumnNames();
            string sql = " UPDATE " + tableName + " SET ";
            int i = 1;
            for (; i <= columnNames.Count; i++)
                sql += columnNames[i-1] + " = @" + i +  ", ";
            if (i>0)
                sql = sql.Substring(0, sql.Length - 2);
            sql += "WHERE " + idName + " = @" + i + " ";
            updateSQL = sql;
        }

        private void initDeleteSQL()
        {
            string sql = " DELETE FROM " + tableName + " WHERE " + idName + " = @1" + " ";
            deleteSQL = sql;
        }

        private void initInsert()
        {
            initColumnNames();
            string sql = " INSERT INTO" + tableName + " VALUES ( ";
            int i = 1;
            for (; i <= columnNames.Count; i++)
                sql += " @" + i + " , ";
            if (i > 0)
                sql = sql.Substring(0, sql.Length - 2);
            sql += " ) ";
            insertSQL = sql;
        }

        public abstract DataRow mapObjToRow(T obj);

        public abstract T mapRowToObj(DataRow row);

        protected abstract void initDataType();

        protected abstract void initTableName();

        protected abstract void initColumnNames();
        public void setColumnNames(string[] columns)
        {
            columnNames.Clear();
            columnNames.AddRange(columns);
        }


    }
}
