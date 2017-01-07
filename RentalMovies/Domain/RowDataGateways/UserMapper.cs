using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
