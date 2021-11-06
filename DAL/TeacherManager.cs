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
    public class TeacherManager : Connect
    {
        public static Teacher GetTeacherByAccountID(int accountID)
        {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"select * from Teacher where TeacherAccountID={accountID}", conn);

                SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    return new Teacher(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }
                return null;
            }
            finally
            {
                reader.Close();
            }
        }

        public static Teacher GetTeacherByTeacherID(int teacherID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Teacher where TeacherID={teacherID}", conn);

            Console.WriteLine(command.CommandText);

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    return new Teacher(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
                }
            }
            finally
            {
                reader.Close();
                Console.WriteLine("TeacherManager conn " + conn.State);
            }
            return null;
        }
    }
}
