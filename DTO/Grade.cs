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
        int gradeSubjectID;
        int attendenceGrade;
        int projectGrade;
        int practicalExamGrade;
        int finalExamGrade;
        int finalAvarageGrade;

        public Grade(int gradeStudentID, int gradeSubjectID, int attendenceGrade, int projectGrade, int practicalExamGrade, int finalExamGrade)
        {
            GradeStudentID = gradeStudentID;
            GradeSubjectID = gradeSubjectID;
            AttendenceGrade = attendenceGrade;
            ProjectGrade = projectGrade;
            PracticalExamGrade = practicalExamGrade;
            FinalExamGrade = finalExamGrade;
        }

        public int GradeStudentID { get => gradeStudentID; set => gradeStudentID = value; }
        public int GradeSubjectID { get => gradeSubjectID; set => gradeSubjectID = value; }
        public int AttendenceGrade { get => attendenceGrade; set => attendenceGrade = value; }
        public int ProjectGrade { get => projectGrade; set => projectGrade = value; }
        public int PracticalExamGrade { get => practicalExamGrade; set => practicalExamGrade = value; }
        public int FinalExamGrade { get => finalExamGrade; set => finalExamGrade = value; }
        public int FinalAvarageGrade { get => finalAvarageGrade; set => finalAvarageGrade = value; }
    }
}
