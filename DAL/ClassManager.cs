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
    public class ClassManager : Connect
    {
        public static Class GetClassByStudentID(int StudentID)
        {
            int ClassID = StudentManager.GetClassIDByStudentID(StudentID);

            return GetClassByClassID(ClassID);
        }

        public static Class GetClassByClassID(int ClassID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlDataReader reader = null;

            SqlCommand command = new SqlCommand($"select * from Class where ClassID = {ClassID}", conn);
            reader = command.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    return new Class(reader.GetInt32(0), reader.GetString(1));
                }
                return null;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }
    }
}
