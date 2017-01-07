using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace RentalMovies.Domain.Mapper
{
    public class CustomerMapper : AbstractMapper<Customer>
    {

        public override DataRow mapObjToRow(Customer obj)
        {
            throw new NotImplementedException();
        }

        public override Customer mapRowToObj(DataRow row)
        {
            Customer obj = new Customer();
            obj.Id = MapperUtils.GetValue(row, 0);
            obj.Name = MapperUtils.GetValue(row, 1);
            obj.Surname = MapperUtils.GetValue(row, 2);
            obj.Pesel = MapperUtils.GetValue(row, 3);
            obj.Phone = MapperUtils.GetValue(row, 4);
            obj.Address = MapperUtils.GetValue(row, 5);
            return obj;
        }

        protected override void initColumnNames()
        {
            columnNames.Add("id");
            columnNames.Add("name");
            columnNames.Add("surname");
            columnNames.Add("pesel");
            columnNames.Add("phone");
            columnNames.Add("address");
        }

        protected override void initTableName()
        {
            tableName = "Customers";
        }

        protected override void initDataType()
        {
            dataType = DataObjectType.Customer;
        }
    }
}
