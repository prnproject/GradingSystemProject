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
    public class SubjectManager: Connect
    {
        public List<Subject> subject()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand command = new SqlCommand($"select * from [Course] ", conn);
            List<Subject> subject = new List<Subject>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                subject.Add(new Subject(reader.GetInt32(0),reader.GetString(1)));

            }
            conn.Close();
            return subject;
        }
    }
}
