using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sound.Models
{
    public class UserModel
    {
        public string login { set; get; }
        public string pass { set; get; }
        public UserModel(string Login, string Pass)
        {
            login = Login;
            pass = Pass;
        }

    }
}
