using RentalMovies.Domain.Records;
using System;
using System.Data;

namespace RentalMovies.Domain.Mapper
{
    public class UserMapper : AbstractMapper<User>
    {
        public override DataRow mapObjToRow(User obj)
        {
            throw new NotImplementedException();
        }

        public override User mapRowToObj(DataRow row)
        {
            User obj = new User();
            obj.Id = MapperUtils.GetValue(row, 0);
            obj.Name = MapperUtils.GetValue(row, 1);
            obj.Surname = MapperUtils.GetValue(row, 2);
            obj.Login = MapperUtils.GetValue(row, 3);
            obj.Password = MapperUtils.GetValue(row, 4);
            obj.Job = MapperUtils.GetValue(row, 5);
            return obj;
        }

        protected override void initColumnNames()
        {
            columnNames.Add("id");
            columnNames.Add("name");
            columnNames.Add("surname");
            columnNames.Add("login");
            columnNames.Add("password");
            columnNames.Add("job");
        }


        protected override void initTableName()
        {
            tableName = "Users";
        }

        protected override void initDataType()
        {
            dataType = DataObjectType.User;
        }

        public override void Insert(User obj)
        {
            string newId = objConnect.GetNewID();
            obj.Id = newId;
            InsertParameters.Add("@1", newId);
            InsertParameters.Add("@2", obj.Name);
            InsertParameters.Add("@3", obj.Surname);
            InsertParameters.Add("@4", obj.Login);
            InsertParameters.Add("@5", obj.Password);
            InsertParameters.Add("@6", obj.Job);
            base.Insert(obj);
        }

        public override void Update(User obj)
        {
            UpdateParameters.Add("@1", obj.Id);
            UpdateParameters.Add("@2", obj.Name);
            UpdateParameters.Add("@3", obj.Surname);
            UpdateParameters.Add("@4", obj.Login);
            UpdateParameters.Add("@5", obj.Password);
            UpdateParameters.Add("@6", obj.Job);
            UpdateParameters.Add("@7", obj.Id);
            base.Update(obj);
        }

    }
}
