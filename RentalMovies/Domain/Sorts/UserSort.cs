using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Sorts
{
    public static class UserSort
    {
        private const string basicSort = " id ASC ";
        private const string sortUserByNameAsc = " name ASC ";
        private const string sortUserByNameDesc = " name DESC ";
        private const string sortUserBySurnameAsc = " surname ASC ";
        private const string sortUserBySurnameDesc = " surname DESC ";
        private const string sortUserByJobAsc = " job ASC ";
        private const string sortUserByJobDesc = " job DESC ";

        public static string BasicSort
        {
            get
            {
                return basicSort;
            }
        }

        public static string SortUserByNameAsc
        {
            get
            {
                return sortUserByNameAsc;
            }
        }

        public static string SortUserByNameDesc
        {
            get
            {
                return sortUserByNameDesc;
            }
        }

        public static string SortUserBySurnameAsc
        {
            get
            {
                return sortUserBySurnameAsc;
            }
        }

        public static string SortUserBySurnameDesc
        {
            get
            {
                return sortUserBySurnameDesc;
            }
        }

        public static string SortUserByJobAsc
        {
            get
            {
                return sortUserByJobAsc;
            }
        }

        public static string SortUserByJobDesc
        {
            get
            {
                return sortUserByJobDesc;
            }
        }

    }
}
