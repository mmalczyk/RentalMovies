using RentalMovies.HelperClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Tables
{
    public class DataTableObject
    {
        protected DatabaseConnection objConnect;

        public void SetObjConnect(ref DatabaseConnection objConnect)
        {
            this.objConnect = objConnect;
        }

    }
}
