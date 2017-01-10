using RentalMovies.Domain.Records;
using System;
using System.Data;
using RentalMovies.Domain.Mapper;

namespace RentalMovies.Domain.Tables
{
    public class MoviesTable : DataTableObject<Movie>
    {
        private MovieMapper MovieTableGateway;

        public MoviesTable()
        {
            MovieTableGateway = DataGatewayRegistry.SoleInstance.MovieTableGateway;
        }

        override public Movie Select(string id)
        {
            MovieTableGateway.setColumnNames(new string[] { "id" });
            MovieTableGateway.FindParameters.Add("@1", id);
            return MovieTableGateway.Find();
        }

        override public void Add(Movie obj)
        {
            MovieTableGateway.Insert(obj);
        }

        override public void Delete(Movie obj)
        {
            MovieTableGateway.Delete(obj);
        }

        override public void Update(Movie obj)
        {
            MovieTableGateway.Update(obj);
        }
        public DataRowCollection FindAll(string order = "title")
        {
            MovieTableGateway.FindAllParameters.Add("@1", order);
            return MovieTableGateway.FindAll();
        }

        public override void PopulateRow(Movie obj, ref DataRow row, bool isNew)
        {
            if (isNew)
                row[0] = objConnect.GetNewID();
            row[1] = obj.Title;
            row[2] = obj.ReleaseYear;
            row[3] = obj.Country;
            row[4] = obj.Cost;
            row[5] = obj.Description;
        }

        public override Movie RowToDataObject(DataRow row)
        {
            throw new NotImplementedException();
        }

    }
}
