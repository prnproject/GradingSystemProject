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
    public class StudentManager : Connect
    {
        public static Student GetStudentByAccountID(int accountID)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Student where StudentAccountID={accountID}", conn);

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    return new Student(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            finally
            {
                reader.Close();;
            }
            return null;
        }    

        public static List<Student> GetStudentsByClassID(int ClassID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Student where StudentClassID={ClassID}", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                students.Add(
                    new Student(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetString(3).Trim(),
                        reader.GetString(4).Trim(),
                        reader.GetString(5).Trim()
                    )
                );
            }
            reader.Close();;
            return students;
        }

        public static int GetClassIDByStudentID(int StudentID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select StudentClassID from Student where StudentID={StudentID}", conn);

            int ClassID = (int)command.ExecuteScalar();            
            return ClassID;
        }
    }
}
