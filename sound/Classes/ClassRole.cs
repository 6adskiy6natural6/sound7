using sound.Models;
using sound.Models.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sound.Classes
{
    public class ClassRole
    {
        private Users user;
        public bool RoleCheck(Users currentUser)
        {
            user = currentUser;
            int role = user.Roles.RoleID;
            if (role == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
