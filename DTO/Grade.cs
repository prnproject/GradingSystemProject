using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Grade
    {
        int gradeStudentID;
        int gradeCourseID;
        int attendenceGrade;
        int projectGrade;
        int writtenGrade;
        int practicalExamGrade;
        int finalExamGrade;
        int averageGrade;
        String resultText;

        public Grade(int gradeStudentID, int gradeCourseID, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int averageGrade, string resultText)
        {
            GradeStudentID = gradeStudentID;
            GradeCourseID = gradeCourseID;
            AttendenceGrade = attendenceGrade;
            ProjectGrade = projectGrade;
            WrittenGrade = writtenGrade;
            PracticalExamGrade = practicalExamGrade;
            FinalExamGrade = finalExamGrade;
            AvarageGrade = averageGrade;
            ResultText = resultText;
        }

        public int GradeStudentID { get => gradeStudentID; set => gradeStudentID = value; }
        public int GradeCourseID { get => gradeCourseID; set => gradeCourseID = value; }
        public int AttendenceGrade { get => attendenceGrade; set => attendenceGrade = value; }
        public int ProjectGrade { get => projectGrade; set => projectGrade = value; }
        public int WrittenGrade { get => writtenGrade; set => writtenGrade = value; }
        public int PracticalExamGrade { get => practicalExamGrade; set => practicalExamGrade = value; }
        public int FinalExamGrade { get => finalExamGrade; set => finalExamGrade = value; }
        public int AvarageGrade { get => averageGrade; set => averageGrade = value; }
        public string ResultText { get => resultText; set => resultText = value; }
    }
}

