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
            reader.Close();;
            return classes;
        }

        public static List<Teaching> GetTeacherTeachingCourseByStudentID(int StudentID)
        {
            Class @class = ClassManager.GetClassByStudentID(StudentID);
            return GetTeacherTeachingCourseByClassID(@class.ClassID);
        }


        public static List<Teaching> GetTeacherTeachingCourseByClassID(int ClassID)
        {
            List<Teaching> teachings = new List<Teaching>();

            Class @class = ClassManager.GetClassByClassID(ClassID);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Teaching where TeachingClassID={ClassID}", conn);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Teaching teaching = new Teaching
                {
                    TeachingTeacherID = reader.GetInt32(0),
                    TeachingCourseID = reader.GetInt32(1),
                    TeachingClassID = @class.ClassID
                };
                teaching.Teacher = TeacherManager.GetTeacherByTeacherID(teaching.TeachingTeacherID);
                teaching.Course = CourseManager.GetCourseByCourseID(teaching.TeachingCourseID);
                teaching.Class = @class;

                Console.WriteLine(teaching);

                teachings.Add(teaching);
            }
            reader.Close();
            return teachings;
        }
    }
}
