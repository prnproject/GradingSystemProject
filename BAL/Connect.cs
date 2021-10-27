using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Connect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=LAPTOP-19CIVOIT;Initial Catalog=GradingSystem;Integrated Security=True");
    }
}
