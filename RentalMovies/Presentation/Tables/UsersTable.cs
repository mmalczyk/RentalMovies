using RentalMovies.Domain.Mapper;
using RentalMovies.Domain.Records;
using System.Data;

namespace RentalMovies.Domain.Tables
{
    public class UsersTable : DataTableObject<User>
    {
        private UserMapper UserTableGateway;

        public UsersTable()
        {
            UserTableGateway = DataGatewayRegistry.SoleInstance.UserTableGateway;
        }
        override public User Select(string id)
        {
            UserTableGateway.setColumnNames(new string[] { "id" });
            UserTableGateway.FindParameters.Add("@1", id);
            return UserTableGateway.Find();
        }

        public User FindUser(string login, string password)
        {
            UserTableGateway.setColumnNames(new string[] { "login", "password" });
            UserTableGateway.FindParameters.Add("@1", login);
            UserTableGateway.FindParameters.Add("@2", password);
            return UserTableGateway.Find();
        }

        override public void Add(User obj)
        {
            UserTableGateway.Insert(obj);
        }

        override public void Delete(User obj)
        {
            UserTableGateway.Delete(obj);
        }

        override public void Update (User obj)
        {
            UserTableGateway.Update(obj);
        }
        public DataRowCollection FindAll(string order)
        {
            UserTableGateway.FindAllParameters.Add("@1", order);
            return UserTableGateway.FindAll();
        }

        override public void PopulateRow(User user, ref DataRow row, bool isNew)
        {
            if (isNew)
                row[0] = objConnect.GetNewID();
            row[1] = user.Name;
            row[2] = user.Surname;
            row[3] = user.Login;
            row[4] = user.Password;
            row[5] = user.Job;
        }

        override public User RowToDataObject(DataRow row)
        {
            return new User(row);
        }

    }


}
