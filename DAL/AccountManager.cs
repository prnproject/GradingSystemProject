using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountManager: Connect
    {
        public static Account GetAccount(string accountUserName, string accountPassword)
        {

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"select * from [Account] where accountUserName='{accountUserName}' and accountPassword='{accountPassword}'", conn);

                Console.WriteLine(command.CommandText);

                var r = command.ExecuteReader();

                if (r.Read())
                {
                    return new Account(r.GetInt32(0), r.GetString(1), r.GetString(2), r.GetString(3));
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return null;
        }
    }
}
