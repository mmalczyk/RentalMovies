using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain.Records
{
    public class Movie : ActiveRecord
    {
        private string titles;
        private string releaseYear;
        private string country;
        private string cost;
        private string description;

        public override string[] toArray()
        {
            return new string[] { id, titles, releaseYear, country, cost, description };
        }

        public override void init(DataRow row)
        {
            id = row.ItemArray.GetValue(0).ToString().Trim();
            titles = row.ItemArray.GetValue(1).ToString().Trim();
            releaseYear = row.ItemArray.GetValue(2).ToString().Trim();
            country = row.ItemArray.GetValue(3).ToString().Trim();
            cost = row.ItemArray.GetValue(4).ToString().Trim();
            description = row.ItemArray.GetValue(5).ToString().Trim();
        }

    }
}
