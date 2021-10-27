using BLL;
using DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystemProject
{
    public partial class TeacherViewForm : Form
    {
        public TeacherViewForm()
        {
            InitializeComponent();

        }
		TeacherFormBLL teacherbll = new TeacherFormBLL();
		int tempTeacherID = 1; //id cứng tạm thời cho teacher vì chưa có login để lấy id
		int selectedStudentID = -1;
		TextBox[] gradeTextBoxes;

		private void Form1_Load(object sender, EventArgs e)
        {
			List<Course> courses = teacherbll.GetCourses();
            foreach (Course c in courses)
            {
                cboCourse.Items.Add(c);
            }

			LockScoreTextBox();

			gradeTextBoxes = new TextBox[] {
				txtAttendanceGrade,
				txtProjectGrade,
				txtWrittenQuizGrade,
				txtPracticalQuizGrade,
				txtFinalExamGrade,
				txtAverageGrade
			};
		}

		private void ResetTextBox()
        {
			txtName.Text = "";
			Controls.OfType<GroupBox>().ToList().ForEach(grp => grp.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Text = ""));
        }

		private void UnlockScoreTextBox()
		{
			txtAttendanceGrade.ReadOnly = false;
			txtWrittenQuizGrade.ReadOnly = false;
			txtProjectGrade.ReadOnly = false;
			txtPracticalQuizGrade.ReadOnly = false;
			txtFinalExamGrade.ReadOnly = false;
		}

		private void LockScoreTextBox()
		{
			txtAttendanceGrade.ReadOnly = true;
			txtWrittenQuizGrade.ReadOnly = true;
			txtProjectGrade.ReadOnly = true;
			txtPracticalQuizGrade.ReadOnly = true;
			txtFinalExamGrade.ReadOnly = true;
		}

		private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
			selectedStudentID = -1;
			ResetTextBox();
			LockScoreTextBox();			
			List <Class> classes = teacherbll.GetClassesByCourse(tempTeacherID, (Course)cboCourse.SelectedItem);
			cboClass.Text = "";
			cboClass.Items.Clear();
			cboClass.Items.AddRange(classes.ToArray());
			lstStudent.Items.Clear();
		}

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedStudentID = -1;
			ResetTextBox();
			LockScoreTextBox();
			List<Student> students = teacherbll.GetStudentsByClass((Class)cboClass.SelectedItem);
			lstStudent.Items.Clear();
			
			foreach(Student student in students)
            {
				ListViewItem item = new ListViewItem(new String[]
				{
					student.StudentID.ToString(),
					student.StudentName,
					student.StudentPhoneNumber,
					student.StudentMail
				});

				lstStudent.Items.Add(item);
            }
		}

        private void lstStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (lstStudent.SelectedItems.Count == 0) return;

			selectedStudentID = int.Parse(lstStudent.SelectedItems[0].SubItems[0].Text);
			txtName.Text = lstStudent.SelectedItems[0].SubItems[1].Text;

			UnlockScoreTextBox();

		}

        private void btnCompute_Click(object sender, EventArgs e)
        {
			if(selectedStudentID == -1)
            {
				MessageBox.Show("Choose a student!");
				return;
			}

			int a = default(int);
			decimal b = new decimal();

			if (Information.IsNumeric(txtAttendanceGrade.Text))
			{
				if (int.Parse(txtAttendanceGrade.Text) <= 20)
				{
					a = (int)((double.Parse(txtAttendanceGrade.Text) * 100) / 20);
					txtAttendanceEG.Text = a.ToString();
					b = (decimal)(a * 0.1);
					txtAttendancePercent.Text = b.ToString();
				}
				else
				{
					MessageBox.Show("Please Enter value equal to 20 and below!");
					return;
				}
			}
			if (Information.IsNumeric(txtWrittenQuizGrade.Text))
			{

				if (int.Parse(txtWrittenQuizGrade.Text) <= 50)
				{
					int c = default(int);
					decimal d = new decimal();
					c = (int)((double.Parse(txtWrittenQuizGrade.Text) * 100) / 50);
					txtWrittenQuizEG.Text = c.ToString();
					d = (decimal)(c * 0.1);
					txtWrittenQuizPercent.Text = d.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 50 and below!");
					return;
				}
			}

			if (Information.IsNumeric(txtPracticalQuizGrade.Text))
			{
				if (int.Parse(txtPracticalQuizGrade.Text) <= 50)
				{
					int g = default(int);
					decimal f = new decimal();
					g = (int)((double.Parse(txtPracticalQuizGrade.Text) * 100) / 50);
					txtPracticalQuizEG.Text = g.ToString();
					f = (decimal)(g * 0.2);
					txtPracticalQuizPercent.Text = f.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 50 and below!");
					return;
				}
			}
			if (Information.IsNumeric(txtProjectGrade.Text))
			{
				if (int.Parse(txtProjectGrade.Text) <= 100)
				{
					int g = default(int);
					decimal f = new decimal();
					g = (int)((double.Parse(txtProjectGrade.Text) * 100) / 100);
					txtProjectEG.Text = g.ToString();
					f = (decimal)(g * 0.3);
					txtProjectPercent.Text = f.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 100 and below!");
					return;
				}
			}

			if (Information.IsNumeric(txtFinalExamGrade.Text))
			{
				if (int.Parse(txtFinalExamGrade.Text) <= 100)
				{
					int j = default(int);
					decimal f1 = new decimal();
					j = (int)((double.Parse(txtFinalExamGrade.Text) * 100) / 100);
					txtFinalExamEG.Text = j.ToString();
					f1 = (decimal)(j * 0.3);
					txtFinalExamPercent.Text = f1.ToString();

				}
				else
				{
					MessageBox.Show("Please Enter value equal to 100 and below!");
					return;
				}
			}

			decimal adal = new decimal();
			adal = (decimal)(Conversion.Val(txtAttendancePercent.Text) + Conversion.Val(txtWrittenQuizPercent.Text) + Conversion.Val(txtPracticalQuizPercent.Text) + Conversion.Val(txtProjectPercent.Text) + Conversion.Val(txtFinalExamPercent.Text));

			txtAverageGrade.Text = adal.ToString();

			if (Conversion.Val(txtAverageGrade.Text) <= 74)
			{

				txtRemarks.Text = "Failed";
				txtRemarks.ForeColor = Color.Red;
			}
			else
			{
				txtRemarks.Text = "Passed";
				txtRemarks.ForeColor = Color.Green;
			}
		}

        private void btnDelete_Click(object sender, EventArgs e)
        {
			ResetTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

			if (gradeTextBoxes.Any(tb => tb.Text.Trim() == ""))
            {
				MessageBox.Show("Can not save! Must fill all field or compute first!");
				return;
            }			

			int studentID = selectedStudentID;
			int courseID = ((Course)cboCourse.SelectedItem).CourseID;
			int[] grades = gradeTextBoxes.Select(tb => (int)double.Parse(tb.Text)).ToArray();

			string report = teacherbll.SaveGrade(studentID, courseID, grades);

			MessageBox.Show(report);
        }
    }
}
