using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Course
    {
        int courseID;
        string courseName;

        public Course(int courseID, string courseName)
        {
            CourseID = courseID;
            CourseName = courseName;
        }

        public override string ToString()
        {
            return courseName;
        }

        public int CourseID { get => courseID; set => courseID = value; }
        public string CourseName { get => courseName; set => courseName = value; }
    }
}
