using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain
{
    public interface AbstractMapper
    {
        void Update();

        void Delete();
        void Insert();

    }
}
