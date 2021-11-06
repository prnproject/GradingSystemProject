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
    public class GradeManager : Connect
    {
        public static String InsertGrade(int gradeStudentID, int gradeCourse, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int averageGrade, String resultText)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"insert into [Grade] values('{gradeStudentID}','{gradeCourse}','{attendenceGrade}','{projectGrade}','{writtenGrade}','{practicalExamGrade}','{finalExamGrade}','{averageGrade}', '{resultText}')", conn);

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Insert Success!";
                } 
            }
            catch (Exception ex)
            {
                return ex.Message + "\nInsert Failed!";
            }
            return "Insert Success!";
        }

        public static String UpdateGrade(int gradeStudentID, int gradeCourseID, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int averageGrade, String resultText)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"update Grade set AttendanceGrade='{attendenceGrade}',ProjectGrade='{projectGrade}',WrittenGrade='{writtenGrade}', PracticalExamGrade='{practicalExamGrade}',FinalExamGrade='{finalExamGrade}',AverageGrade='{averageGrade}', ResultText='{resultText}' where GradeStudentID='{gradeStudentID}' and GradeCourseID='{gradeCourseID}' ", conn);




                if (command.ExecuteNonQuery() > 0)
                {
                    return "Update Success!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\nUpdate Failed!";
            }
            return "Update Failed!";
        }

        public static bool Exists(int gradeStudentID, int gradeCourseID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"select * from Grade where gradeStudentID ={gradeStudentID} and gradeStudentID={gradeCourseID}", conn);

                if (command.ExecuteReader().Read())
                {
                    return true;
                }                
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public static String DeleteGrade(int gradeStudentID, int gradeCourseID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"update Grade set AttendanceGrade='0',ProjectGrade='0',WrittenGrade='0', PracticalExamGrade='0',FinalExamGrade='0',AverageGrade='0' where GradeStudentID='{gradeStudentID} and GradeCourseID='{gradeCourseID}'", conn);

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Delete Success!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\nDelete Failed!";
            }       
            return "Delete Failed!";
        }

        public static Grade GetCourseGradeOfStudent(int gradeStudentID, int gradeCourseID)
        {
            

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Grade where GradeStudentID='{gradeStudentID}' and GradeCourseID='{gradeCourseID}'", conn);

            SqlDataReader reader = command.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    int attendanceGrade = reader.GetInt32(2);
                    int projectGrade = reader.GetInt32(3);
                    int writtenGrade = reader.GetInt32(4);
                    int practicalGrade = reader.GetInt32(5);
                    int finalExamGrade = reader.GetInt32(6);
                    int averageGrade = reader.GetInt32(7);
                    String resultText = reader.GetString(8);
                    return new Grade(gradeStudentID, gradeCourseID, attendanceGrade, projectGrade, writtenGrade, practicalGrade, finalExamGrade, averageGrade, resultText);
                }
            }
            finally
            {
                reader.Close();;
            }
            return null;
        }
    }
}
