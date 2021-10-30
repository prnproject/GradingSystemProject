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
    public class CourseManager: Connect
    {
        public static List<Course> GetCourses()
        {            
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from [Course] ", conn);
            List<Course> subject = new List<Course>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                subject.Add(new Course(reader.GetInt32(0),reader.GetString(1)));

            }
            conn.Close();
            return subject;
        }
    }
}
