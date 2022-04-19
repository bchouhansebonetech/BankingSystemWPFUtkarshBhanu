using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSyestem.LogIn
{
    internal class UserLoginDataDO
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public Boolean Status { get; set; }

        public UserLoginDataDO(string username, string password, Boolean status)
        {
            this. UserName = username;
            this. Password = password;
            this.Status = status;
        }
    }
}
