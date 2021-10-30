using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TeacherManager : Connect
    {
        public static int getTeacherIDByAccountID(int accountID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"select * from Teacher where TeacherAccountID={accountID}", conn);

                var r = command.ExecuteReader();

                if (r.Read())
                {
                    return r.GetInt32(0);
                }
            }
            catch (Exception)            {
                return -1;
                throw;
            }
            finally
            {
                conn.Close();
            }
            return -1;
        }
    }
}
