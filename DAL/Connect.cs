using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        protected static SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GradingSystem;Integrated Security=True;MultipleActiveResultSets=true");

        public static void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
    }
}
