using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibi.Auth.Models
{
    public class UserAccount
    {
        public UserAccount()
        {
            this.UserName = "";
            this.AuthHash = "";
            this.AccountStatus = new AccountStatus();
            this.UserRole = new UserRole();
            this.UserData = new UserData();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string AuthHash { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public UserRole UserRole { get; set; }
        public UserData UserData { get; set; }
    }
}
