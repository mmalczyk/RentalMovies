using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Sorts
{
    public class UserSort
    {
        private const string basicSort = " id ASC ";
        private const string sortUserByNameAsc = " name ASC ";
        private const string sortUserByNameDesc = " name DESC ";
        private const string sortUserBySurnameAsc = " surname ASC ";
        private const string sortUserBySurnameDesc = " surname DESC ";
        private const string sortUserByJobAsc = " job ASC ";
        private const string sortUserByJobDesc = " job DESC ";

        public string BasicSort
        {
            get
            {
                return basicSort;
            }
        }

        public string SortUserByNameAsc
        {
            get
            {
                return sortUserByNameAsc;
            }
        }

        public string SortUserByNameDesc
        {
            get
            {
                return sortUserByNameDesc;
            }
        }

        public string SortUserBySurnameAsc
        {
            get
            {
                return sortUserBySurnameAsc;
            }
        }

        public string SortUserBySurnameDesc
        {
            get
            {
                return sortUserBySurnameDesc;
            }
        }

        public string SortUserByJobAsc
        {
            get
            {
                return sortUserByJobAsc;
            }
        }

        public string SortUserByJobDesc
        {
            get
            {
                return sortUserByJobDesc;
            }
        }

    }
}
