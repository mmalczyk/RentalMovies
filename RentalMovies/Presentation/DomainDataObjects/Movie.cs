using RentalMovies.HelperClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Records
{
    public class Movie : AbstractActiveRecord
    {
        private string title;
        private string releaseYear;
        private string country;
        private Money cost;
        private string description;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string ReleaseYear
        {
            get
            {
                return releaseYear;
            }

            set
            {
                releaseYear = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public Money Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public object MapperUtils { get; private set; }

        public Movie()
        {
            DataObjectType = DataObjectType.Movie;
        }

        public override string[] toArray()
        {
            return new string[] { Id, Title, ReleaseYear, Country, Cost.ToString(), Description };
        }

        public override void init(DataRow row)
        {
            id = row.ItemArray.GetValue(0).ToString().Trim();
            Title = row.ItemArray.GetValue(1).ToString().Trim();
            ReleaseYear = row.ItemArray.GetValue(2).ToString().Trim();
            Country = row.ItemArray.GetValue(3).ToString().Trim();
            Cost = new Money(row.ItemArray.GetValue(4).ToString().Trim(), Currency.PL);
            Description = row.ItemArray.GetValue(5).ToString().Trim();
        }

    }
}
