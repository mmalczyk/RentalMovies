using System.Data;

namespace RentalMovies.Domain.Records
{
    public abstract class ActiveRecord
    {
        protected string id;

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

        public abstract string[] toArray();
        public abstract void init(DataRow dataRow);
    }
}
