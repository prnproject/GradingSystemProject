using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teaching
    {
        int teachingTeacherID;
        int teachingCourseID;
        int teachingClassID;
        Teacher teacher;
        Course course;
        Class @class;

        public Teaching()
        {
        }

        public Teaching(int teachingTeacherID, int teachingCourseID, int teachingClassID)
        {
            this.teachingTeacherID = teachingTeacherID;
            this.teachingCourseID = teachingCourseID;
            this.teachingClassID = teachingClassID;
        }

        public Teaching(Teacher teacher, Course course, Class @class)
        {
            this.teacher = teacher;
            this.course = course;
            this.@class = @class;
            this.teachingTeacherID = teacher.TeacherAccountID;
            this.teachingCourseID = course.CourseID;
            this.teachingClassID = @class.ClassID;
        }

        public Teaching(int teachingTeacherID, int teachingCourseID, int teachingClassID, Teacher teacher, Course course, Class @class)
        {
            TeachingTeacherID = teachingTeacherID;
            TeachingCourseID = teachingCourseID;
            TeachingClassID = teachingClassID;
            Teacher = teacher;
            Course = course;
            Class = @class;
        }

        public int TeachingTeacherID { get => teachingTeacherID; set => teachingTeacherID = value; }
        public int TeachingCourseID { get => teachingCourseID; set => teachingCourseID = value; }
        public int TeachingClassID { get => teachingClassID; set => teachingClassID = value; }
        public Teacher Teacher { get => teacher; set => teacher = value; }
        public Course Course { get => course; set => course = value; }
        public Class Class { get => @class; set => @class = value; }

        public override string ToString()
        {
            return $"TeachingTeacherID = {TeachingTeacherID}, TeachingCourseID = {TeachingCourseID}, TeachingClassID = {TeachingClassID}, Teacher = {Teacher}, Course = {Course}, Class = {Class}";
        }
    }
}
