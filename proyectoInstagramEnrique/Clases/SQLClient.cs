using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace proyectoFinal.Classes
{
    public class SQLClient
    {
        public SqlConnection connection { get; }

        public SQLClient(string cString)
        {
            connection=new SqlConnection(cString);
        }

        public bool Open()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Close()
        {
            try
            {
                if (connection.State==System.Data.ConnectionState.Open) connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    
}
