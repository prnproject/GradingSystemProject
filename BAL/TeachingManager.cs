using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class TeachingManager : Connect
    {
        public List<String> getClass(String courseID)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from Teaching where TeachingTeacherID = 1 and TeachingCourseID = {courseID}", conn);
             
            SqlDataReader reader = command.ExecuteReader();
            List<String> classID = new List<String>();
            while (reader.Read()) {
                classID.Add(reader.GetInt32(3).ToString());
            }
            conn.Close();
            return classID;
        }
    }
}
