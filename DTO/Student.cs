using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Student
    {
        int studentID;
        int studentClassID;
        int studentAccountID;
        string studentName;
        string studentPhoneNumber;
        string studentMail;

        public Student(int studentID, int studentClassID, int studentAccountID, string studentName, string studentPhoneNumber, string studentMail)
        {
            StudentID = studentID;
            StudentClassID = studentClassID;
            StudentAccountID = studentAccountID;
            StudentName = studentName;
            StudentPhoneNumber = studentPhoneNumber;
            StudentMail = studentMail;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public int StudentClassID { get => studentClassID; set => studentClassID = value; }
        public int StudentAccountID { get => studentAccountID; set => studentAccountID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentPhoneNumber { get => studentPhoneNumber; set => studentPhoneNumber = value; }
        public string StudentMail { get => studentMail; set => studentMail = value; }

        public override string ToString()
        {
            return StudentName;
        }
    }
}
