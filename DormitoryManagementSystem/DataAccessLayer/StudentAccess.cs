using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Log_In.DataAccessLayer
{
    class StudentAccess
    {
        DataAccess dataAccess;

        public StudentAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM New_student WHERE UserName='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
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
