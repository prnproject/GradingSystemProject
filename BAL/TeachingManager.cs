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
    public class TeachingManager : Connect
    {
        public static List<Class> GetClassesByCourseID(int TeacherID, int courseID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select ClassID, ClassName\n" +
                                                "from\n" +
                                                "Class inner join\n" +
                                                $"(select TeachingClassID from Teaching where TeachingTeacherID = {TeacherID} and TeachingCourseID = {courseID}) Teaching\n" +
                                                "on ClassID = TeachingClassID", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Class> classes  = new List<Class>();
            while (reader.Read()) {
                classes.Add(new Class(reader.GetInt32(0), reader.GetString(1)));
            }
            conn.Close();
            return classes;
        }
    }
}
