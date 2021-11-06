using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystemProject
{
    public partial class StudentViewForm : Form
    {
        public StudentViewForm()
        {
            InitializeComponent();
        }

        StudentFormBLL studentFormBLL;
        Student student;
        Class @class;
        List<Teaching> teachings;

        public Student Student { get => student; set => student = value; }

        private void Form2_Load(object sender, EventArgs e)
        {
            studentFormBLL = new StudentFormBLL();
            Class @class = studentFormBLL.GetClass(student.StudentClassID);

            txtStudent.Text = "Hello, " + Student.StudentName;
            txtClass.Text = "Class: " + @class.ClassName;

            teachings = studentFormBLL.GetTeacherTeachingCourseByStudentID(Student.StudentID);

            foreach(Teaching teaching in teachings)
            {
                ListViewItem item = new ListViewItem(teaching.Course.CourseName);
                item.SubItems.AddRange(new String[] {teaching.Teacher.TeacherName });
                lstTeacherCourse.Items.Add(item);
                Console.WriteLine(lstTeacherCourse.Items[0].SubItems[0].Text);
            }

            lblAttendance.Text = "";
            lblWritten.Text = "";
            lblProject.Text = "";
            lblPractical.Text = "";
            lblFinal.Text = "";
            lblAverage.Text = "";
            lblResult.Text = "";
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {

        }

        private void lstTeacherCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTeacherCourse.SelectedItems.Count == 0) return;

            int CourseID = teachings[lstTeacherCourse.SelectedItems[0].Index].Course.CourseID;

            Grade grade = studentFormBLL.GetCourseGradeOfStudent(student.StudentID, CourseID);

            if (grade == null)
            {
                lblAttendance.Text = "";
                lblWritten.Text = "";
                lblProject.Text = "";
                lblPractical.Text = "";
                lblFinal.Text = "";
                lblAverage.Text = "";
                lblResult.Text = "";
                return;
            }

            lblAttendance.Text = grade.AttendenceGrade.ToString();
            lblWritten.Text = grade.WrittenGrade.ToString();
            lblProject.Text = grade.ProjectGrade.ToString();
            lblPractical.Text = grade.PracticalExamGrade.ToString();
            lblFinal.Text = grade.FinalExamGrade.ToString();
            lblAverage.Text = grade.AttendenceGrade.ToString();
            lblResult.Text = grade.ResultText;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportReport_Click_1(object sender, EventArgs e)
        {
            ReportForm ReportForm = new ReportForm();
            ReportForm.StudentID = student.StudentID.ToString();
            ReportForm.Show();
        }
    }
}
