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

        public int getTeacherIDByAccountID(int accountID)
        {
            return TeacherManager.getTeacherIDByAccountID(accountID);
        }
    }
}
