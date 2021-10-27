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
        int finalAvarageGrade;

        public Grade(int gradeStudentID, int gradeCourseID, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int finalAvarageGrade)
        {
            this.GradeStudentID = gradeStudentID;
            this.GradeCourseID = gradeCourseID;
            this.AttendenceGrade = attendenceGrade;
            this.ProjectGrade = projectGrade;
            this.WrittenGrade = writtenGrade;
            this.PracticalExamGrade = practicalExamGrade;
            this.FinalExamGrade = finalExamGrade;
            this.FinalAvarageGrade = finalAvarageGrade;
        }

        public int GradeStudentID { get => gradeStudentID; set => gradeStudentID = value; }
        public int GradeCourseID { get => gradeCourseID; set => gradeCourseID = value; }
        public int AttendenceGrade { get => attendenceGrade; set => attendenceGrade = value; }
        public int ProjectGrade { get => projectGrade; set => projectGrade = value; }
        public int WrittenGrade { get => writtenGrade; set => writtenGrade = value; }
        public int PracticalExamGrade { get => practicalExamGrade; set => practicalExamGrade = value; }
        public int FinalExamGrade { get => finalExamGrade; set => finalExamGrade = value; }
        public int FinalAvarageGrade { get => finalAvarageGrade; set => finalAvarageGrade = value; }
    }
}

