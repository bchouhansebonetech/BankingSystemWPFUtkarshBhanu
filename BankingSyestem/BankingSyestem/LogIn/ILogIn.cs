using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSyestem.LogIn
{
    public interface ILogIn
    {
        public UserLoginDataDO loginAccess(UserLoginDataDO userLoginDataDO,List<UserLoginDataDO> userLoginDataDOList);
    }
}
