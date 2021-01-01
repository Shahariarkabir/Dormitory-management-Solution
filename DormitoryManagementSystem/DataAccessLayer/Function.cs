using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Log_In.DataAccessLayer
{
    class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "data source = .\\sqlexpress; database= DormitoryManagement;integrated security=true;";
            return connection;
        }
        
        
        
        
        public DataSet getData(string query)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query,string msg)
        {
            SqlConnection connection = getConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
