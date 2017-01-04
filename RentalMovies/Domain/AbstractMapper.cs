using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain
{
    public abstract class AbstractMapper<T> where T: AbstractActiveRecord
    {
        protected string findSQL;
        protected string findAllSQL;
        protected string updateSQL;
        protected string deleteSQL;
        protected string insertSQL;
        public virtual T Find(string id)
        {
            /*
            objConnect.Sql = selectByIdSql;
            objConnect.AddParameter(idParameter, id);
            DataSet dataSet = objConnect.GetDataSet();
            return dataSet.Tables[0].Rows[0];
            */
            throw new NotImplementedException();
        }
        public virtual void FindAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }

        public virtual void Delete()
        {
            throw new NotImplementedException();
        }

        public virtual void Insert()
        {
            throw new NotImplementedException();
        }


    }
}
