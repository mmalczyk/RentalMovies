using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Records
{
    public class DVDTag : ActiveRecord
    {
        public static class CategoryListing
        {
            private const string writer = "Writer";
            private const string genre = "Genre";
            private const string room = "Room";
            private const string actor = "Actor";

            public static string Writer
            {
                get
                {
                    return writer;
                }
            }

            public static string Genre
            {
                get
                {
                    return genre;
                }
            }

            public static string Room
            {
                get
                {
                    return room;
                }
            }

            public static string Actor
            {
                get
                {
                    return actor;
                }
            }
        }

        private string name;
        private string category;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public DVDTag() { }

        public DVDTag(DataRow dataRow)
        {
            init(dataRow);
        }

        public override string[] toArray()
        {
            return new string[] {name, id};
        }

        public override void init(DataRow row)
        {
            id = row.ItemArray.GetValue(0).ToString().Trim();
            name = row.ItemArray.GetValue(1).ToString().Trim();
            category = row.ItemArray.GetValue(2).ToString().Trim();
        }

        public static bool isTagCorrect(string tag)
        {
            if (tag == null) return false;
            if (tag.Trim().CompareTo("") == 0) return false;
            return true;
        }
    }
}
