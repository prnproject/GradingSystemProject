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
            SqlDataReader reader = null;
            List<Course> courses = new List<Course>();
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                courses.Add(new Course(reader.GetInt32(0),reader.GetString(1)));

            }
            if (reader != null) reader.Close();
            return courses;
        }

        public static Course GetCourseByCourseID(int CourseID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Course where CourseID={CourseID}", conn);
            SqlDataReader reader = command.ExecuteReader();

            try
            {
                if (reader.Read())
                {
                    return new Course(reader.GetInt32(0), reader.GetString(1));
                }
                return null; ;
            }
            finally
            {
                reader.Close();;
            }
        }
    }
}
