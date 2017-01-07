using RentalMovies.Domain.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Domain
{
    public class DataGatewayRegistry
    {
        private static DataGatewayRegistry soleInstance;
        private CustomerMapper customerTableGateway;
        private DVDMapper DVDTableGateway;
        private MovieMapper movieTableGateway;
        private RentingMapper rentingTableGateway;
        private TagMapper tagTableGateway;
        private UserMapper userTableGateway;


        private DataGatewayRegistry()
        {
            customerTableGateway = new CustomerMapper();
            DVDTableGateway = new DVDMapper();
            movieTableGateway = new MovieMapper();
            rentingTableGateway = new RentingMapper();
            tagTableGateway = new TagMapper();
            userTableGateway = new UserMapper();
        }

        public static DataGatewayRegistry SoleInstance
        {
            get
            {
                if (soleInstance == null)
                    soleInstance = new DataGatewayRegistry();
                return soleInstance;
            }
        }

        public CustomerMapper CustomerTableGateway
        {
            get
            {
                return customerTableGateway;
            }
        }

        public DVDMapper DVDTableGateway1
        {
            get
            {
                return DVDTableGateway;
            }
        }

        public MovieMapper MovieTableGateway
        {
            get
            {
                return movieTableGateway;
            }
        }

        public RentingMapper RentingTableGateway
        {
            get
            {
                return rentingTableGateway;
            }
        }

        public TagMapper TagTableGateway
        {
            get
            {
                return tagTableGateway;
            }
        }

        public UserMapper UserTableGateway
        {
            get
            {
                return userTableGateway;
            }
        }
    }
}
