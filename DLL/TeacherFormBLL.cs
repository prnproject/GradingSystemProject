using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TeacherFormBLL
    {
        public List<Course> GetCourses()
        {
            return CourseManager.GetCourses();
        }

        public List<Class> GetClassesByCourse(int teacherID, Course course)
        {
            return TeachingManager.GetClassesByCourseID(teacherID, course.CourseID);
        }

        public List<Student> GetStudentsByClass(Class @class)
        {
            return StudentManager.GetStudentsByClassID(@class.ClassID);
        }

        public string SaveGrade(int gradeStudentID, int gradeCourseID,int[] grades)
        {
            if (GradeManager.Exists(gradeStudentID, gradeCourseID))
            {
                return GradeManager.UpdateGrade(gradeStudentID, gradeCourseID, grades[0], grades[1], grades[2], grades[3], grades[4], grades[5]);
            }
            else
            {
                return GradeManager.InsertGrade(gradeStudentID, gradeCourseID, grades[0], grades[1], grades[2], grades[3], grades[4], grades[5]);
            }
            
        }

        public string DeleteGrade(int gradeStudentID, int gradeCourseID)
        {
            return GradeManager.DeleteGrade(gradeStudentID, gradeCourseID);
        }

        public Grade GetCourseGradeOfStudent(int GradeStudentID, int GradeCourseID)
        {
            return GradeManager.getCourseGradeOfStudent(GradeStudentID, GradeCourseID);
        }
    }
}
