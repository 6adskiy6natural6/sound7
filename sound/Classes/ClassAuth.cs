using sound.Interfaces;
using System;
using sound.Models.ModelDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Runtime;
using System.Windows.Controls;

namespace sound.Classes
{

    public class ClassAuth : auth
    {
        shopdb12RukosuevEntities dbContext = new shopdb12RukosuevEntities();
        public bool auth(string login, string password)
        {
            var user = dbContext.Users.Include(u => u.Roles).FirstOrDefault(u => u.Login == login && u.Pass == password);
            if (user != null && user.Pass == password)
            {
                new DataGrid(user).Show();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
