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
        int writtenGrade;
        int practicalExamGrade;
        int finalExamGrade;
        int finalAvarageGrade;

        public Grade(int gradeStudentID, int gradeSubjectID, int attendenceGrade, int projectGrade, int writtenGrade, int practicalExamGrade, int finalExamGrade, int finalAvarageGrade)
        {
            this.GradeStudentID = gradeStudentID;
            this.GradeSubjectID = gradeSubjectID;
            this.AttendenceGrade = attendenceGrade;
            this.ProjectGrade = projectGrade;
            this.WrittenGrade = writtenGrade;
            this.PracticalExamGrade = practicalExamGrade;
            this.FinalExamGrade = finalExamGrade;
            this.FinalAvarageGrade = finalAvarageGrade;
        }

        public int GradeStudentID { get => gradeStudentID; set => gradeStudentID = value; }
        public int GradeSubjectID { get => gradeSubjectID; set => gradeSubjectID = value; }
        public int AttendenceGrade { get => attendenceGrade; set => attendenceGrade = value; }
        public int ProjectGrade { get => projectGrade; set => projectGrade = value; }
        public int WrittenGrade { get => writtenGrade; set => writtenGrade = value; }
        public int PracticalExamGrade { get => practicalExamGrade; set => practicalExamGrade = value; }
        public int FinalExamGrade { get => finalExamGrade; set => finalExamGrade = value; }
        public int FinalAvarageGrade { get => finalAvarageGrade; set => finalAvarageGrade = value; }
    }
}
