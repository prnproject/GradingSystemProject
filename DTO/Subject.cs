using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject
    {
        int subjectID;
        string subjectName;

        public Subject(int subjectID, string subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
        }

        public int SubjectID { get => subjectID; set => subjectID = value; }
        public string SubjectName { get => subjectName; set => subjectName = value; }
    }
}
