using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Connect
    {
        protected static SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=GradingSystem;User ID=sa;Password=admin;");
    }
}
