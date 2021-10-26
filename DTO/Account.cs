using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        int accountID;
        string accountUserName;
        string accountPassword;
        string accountRole;

        public Account(int accountID, string accountUserName, string accountPassword, string accountRole)
        {
            AccountID = accountID;
            AccountUserName = accountUserName;
            AccountPassword = accountPassword;
            AccountRole = accountRole;
        }

        public int AccountID { get => accountID; set => accountID = value; }
        public string AccountUserName { get => accountUserName; set => accountUserName = value; }
        public string AccountPassword { get => accountPassword; set => accountPassword = value; }
        public string AccountRole { get => accountRole; set => accountRole = value; }
    }
}
