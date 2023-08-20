using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibi.Auth.Models
{
    public enum UserRoleType : int 
    {
        Admin = 1,
        Tenant = 2,
    }
    public class UserRole
    {
        public UserRole()
        {
            this.Name = "";
        }
        public UserRoleType Id { get; set; }
        public string Name { get; set; }
    }
}
