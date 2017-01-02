
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
