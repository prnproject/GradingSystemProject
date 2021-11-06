using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher
    {
        int teacherID;
        int teacherAccountID;
        string teacherName;
        string teacherPhoneNumber;
        string teacherMail;

        public Teacher()
        {
        }

        public Teacher(int teacherID, int teacherAccountID, string teacherName, string teacherPhoneNumber, string teacherMail)
        {
            TeacherID = teacherID;
            TeacherAccountID = teacherAccountID;
            TeacherName = teacherName;
            TeacherPhoneNumber = teacherPhoneNumber;
            TeacherMail = teacherMail;
        }

        public int TeacherID { get => teacherID; set => teacherID = value; }
        public int TeacherAccountID { get => teacherAccountID; set => teacherAccountID = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
        public string TeacherPhoneNumber { get => teacherPhoneNumber; set => teacherPhoneNumber = value; }
        public string TeacherMail { get => teacherMail; set => teacherMail = value; }

        public override string ToString()
        {
            return TeacherName;
        }
    }
}
