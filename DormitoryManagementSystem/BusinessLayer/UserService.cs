using Student_Log_In.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Log_In.BusinessLayer
{
    class UserService
    {
        UserAccess userAccess;
        public UserService()
        {
            this.userAccess = new UserAccess();
        }
        public bool LoginValidation(string username, string password)
        {
            return userAccess.LoginValidation(username, password);
        }
    }
}
