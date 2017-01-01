using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Records
{
    public abstract class ActiveRecord
    {
        public abstract string[] toArray();
        public abstract void init(DataRow dataRow);
    }
}
