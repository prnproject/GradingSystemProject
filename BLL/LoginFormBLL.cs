using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginFormBLL
    {
        public Account CheckLogin(string accountUserName, string accountPassword)
        {
            return AccountManager.GetAccount(accountUserName, accountPassword);
        }

        public Teacher GetTeacherByAccountID(int accountID)
        {
            return TeacherManager.GetTeacherByAccountID(accountID);
        }

        public Student GetStudentByAccountID(int accountID)
        {
            return StudentManager.GetStudentByAccountID(accountID);
        }
    }
}
