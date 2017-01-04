using System.Data;

namespace RentalMovies.Domain
{
    public abstract class AbstractActiveRecord
    {
        protected string id;
        private DataObjectType objectType;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DataObjectType DataObjectType
        {
            get
            {
                return objectType;
            }
            set
            {
                objectType = value;
            }
        }


        public abstract string[] toArray();
        public abstract void init(DataRow dataRow);
    }
}
