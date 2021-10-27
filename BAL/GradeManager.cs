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
                    conn.Close();
                    return "Insert Success!";
                }
            }
            catch (Exception ex)
            {
                return ex.Message + "\nInsert Failed!";
            }
            conn.Close();
            return "Insert Success!";
        }
    }
}
