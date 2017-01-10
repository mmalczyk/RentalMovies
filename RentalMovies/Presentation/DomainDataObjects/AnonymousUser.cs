using RentalMovies.Domain.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.Presentation.DomainDataObjects
{
    public class AnonymousUser : User
    {


        public AnonymousUser() {
            base.setJob("anon");
            base.setName("anon");
            base.setLogin("anon");
            base.setPassword("anon");
            base.setSurname("anon");
        }

        override public User Update(string forename, string surname, string login, string role)
        {
            return this;
        }

        override public User ChangePassword(string password)
        {
            return this;

        }

        override public void setName(string value)
        {
            //don't set!
        }


        override public void setLogin(string value)
        {
            //don't set!
        }

        override public void setPassword(string value)
        {
            //don't set!
        }


        override public void setSurname(string value)
        {
            //don't set!
        }

        override public void setJob(string value)
        {
            //don't set!
        }

    }
}
