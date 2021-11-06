using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentFormBLL
    {
        public List<Teaching> GetTeacherTeachingCourseByStudentID(int StudentID)
        {
            return TeachingManager.GetTeacherTeachingCourseByStudentID(StudentID);
        }

        public Class GetClass(int ClassID)
        {
            return ClassManager.GetClassByClassID(ClassID);
        }

        public Grade GetCourseGradeOfStudent(int GradeStudentID, int GradeCourseID)
        {
            return GradeManager.GetCourseGradeOfStudent(GradeStudentID, GradeCourseID);
        }
    }
}
