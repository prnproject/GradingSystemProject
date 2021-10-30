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
        public static String InsertGrade(int gradeStudentID, int gradeCourse, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int finalAverageGrade)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"insert into [Grade] values('{gradeStudentID}','{gradeCourse}','{attendenceGrade}','{projectGrade}','{writtenGrade}','{practicalExamGrade}','{finalExamGrade}','{finalAverageGrade}')", conn);

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Insert Success!";
                } 
            }
            catch (Exception ex)
            {
                return ex.Message + "\nInsert Failed!";
            }
            finally
            {
                conn.Close();
            }
            return "Insert Success!";
        }

        public static String UpdateGrade(int gradeStudentID, int gradeCourseID, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int finalAverageGrade)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"update Grade set AttendanceGrade='{attendenceGrade}',ProjectGrade='{projectGrade}',WrittenGrade='{writtenGrade}', PracticalExamGrade='{practicalExamGrade}',FinalExamGrade='{finalExamGrade}',FinalAverageGrade='{finalAverageGrade}' where GradeStudentID='{gradeStudentID}' and GradeCourseID='{gradeCourseID}' ", conn);

                

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Update Success!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\nUpdate Failed!";
            }
            finally
            {
                conn.Close();
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
            finally
            {
                conn.Close();
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

                SqlCommand command = new SqlCommand($"update Grade set AttendanceGrade='0',ProjectGrade='0',WrittenGrade='0', PracticalExamGrade='0',FinalExamGrade='0',FinalAverageGrade='0' where GradeStudentID='{gradeStudentID} and GradeCourseID='{gradeCourseID}'", conn);

                if (command.ExecuteNonQuery() > 0)
                {
                    return "Delete Success!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\nDelete Failed!";
            }
            finally
            {
                conn.Close();
            }          
            return "Delete Failed!";
        }

        public static Grade getCourseGradeOfStudent(int gradeStudentID, int gradeCourseID)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"select * from Grade where GradeStudentID='{gradeStudentID}' and GradeCourseID='{gradeCourseID}'", conn);

                var r = command.ExecuteReader();

                if (r.Read())
                {
                    int attendanceGrade = r.GetInt32(2);
                    int projectGrade = r.GetInt32(3);
                    int writtenGrade = r.GetInt32(4);
                    int practicalGrade = r.GetInt32(5);
                    int finalExamGrade = r.GetInt32(6);
                    int finalAverageGrade = r.GetInt32(7);
                    return new Grade(gradeStudentID, gradeCourseID, attendanceGrade, projectGrade, writtenGrade, practicalGrade, finalExamGrade, finalAverageGrade);
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
