using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoceApp.Entidades
{
    public class Login
    {
        public string User { get; private set; }
        public string Password { get; private set; }
        public bool Admin { get; private set; }
        public Login(string user, string password, bool admin)
        {
            User = user;
            Password = password;
            Admin = admin;
        }
    }
}
