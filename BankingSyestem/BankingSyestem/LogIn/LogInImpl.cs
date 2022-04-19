using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSyestem.LogIn
{
    public class LogInImpl : ILogIn
    {

        public UserLoginDataDO loginAccess(UserLoginDataDO userLoginDataDO, List<UserLoginDataDO> userLoginDataDOList)
        {
            if (userLoginDataDO.Status == true)
                return userLoginDataDO;
            else { 
            if (userLoginDataDO.UserName == null || userLoginDataDO.Password == null)
                userLoginDataDO.Status = false;
            else
            {
                foreach (UserLoginDataDO userLoginDatado in userLoginDataDOList)
                {
                    if (userLoginDatado.UserName == userLoginDataDO.UserName && userLoginDataDO.Password == userLoginDatado.Password)
                        userLoginDataDO.Status = true;
                    break;
                }
            }
            return userLoginDataDO;
        }
    } }
}
