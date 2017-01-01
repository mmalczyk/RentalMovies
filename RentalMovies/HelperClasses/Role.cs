using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalMovies.HelperClasses
{
    public class Role
    {
        RoleType type;

        private static Dictionary<RoleType, string> roleArray;

        static Role()
        {
            roleArray = new Dictionary<RoleType, string>();
            roleArray.Add(RoleType.Cassier, "Kasjer");
            roleArray.Add(RoleType.Editor, "Edytor");
            roleArray.Add(RoleType.Admin, "Admin");
            roleArray.Add(RoleType.Manager, "Manager");
        }

        public Role(RoleType type)
        {
            this.type = type;
        }

        public static string[] getRoles()
        {
            return roleArray.Values.ToArray();
        }

        override public string ToString()
        {
            string name;
            roleArray.TryGetValue(type, out name);
            return name;
        }

    }

}
