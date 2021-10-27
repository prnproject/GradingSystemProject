using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class GradeManager : Connect
    {
        public bool SaveGrade(int gradeStudentID, int gradeSubjectID, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int finalAverageGrade)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"insert into [Grade] values('{gradeStudentID}','{gradeSubjectID}','{attendenceGrade}','{projectGrade}','{writtenGrade},'{practicalExamGrade}','{finalExamGrade}','{finalAverageGrade}'", conn);

                if (command.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch
            {

            }
            conn.Close();
            return false;
        }
    }
}
