using Student_Log_In.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Log_In.BusinessLayer
{
    class StudentService
    {
        StudentAccess studentAccess ;

        public StudentService()
        {
            this.studentAccess = new StudentAccess();
        }
        public bool LoginValidation(string username, string password)
        {
            return studentAccess.LoginValidation(username, password);
        }
    }
}
