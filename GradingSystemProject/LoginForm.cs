using BLL;
using DTO;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            this.txtUsername.Text = "";
            this.txtPassword.Text = "";
        }

        LoginFormBLL loginFormBLL = new LoginFormBLL();

        private void btnOK_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            Console.WriteLine(password);

            var account  = loginFormBLL.CheckLogin(username, password);


            if (account != null)
            {
                try
                {
                    if (account.AccountRole == "Teacher")
                    {
                        this.Hide();
                        var teacherViewForm = new TeacherViewForm();
                        teacherViewForm.Closed += (s, args) => { this.Reset(); this.Show(); };
                        teacherViewForm.Teacher = loginFormBLL.GetTeacherByAccountID(account.AccountID);
                        teacherViewForm.Show();
                        return;
                    }
                    else
                    {
                        this.Hide();
                        var studentViewForm = new StudentViewForm();
                        studentViewForm.Closed += (s, args) => { this.Reset(); this.Show(); };
                        studentViewForm.Student = loginFormBLL.GetStudentByAccountID(account.AccountID);
                        studentViewForm.Show();
                        return;
                    }
                }
                finally
                {
                    txtUsername.Focus();
                }
            }
            MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng !");
            return;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
