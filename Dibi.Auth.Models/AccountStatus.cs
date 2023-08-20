using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dibi.Auth.Models
{
    public enum StatusType 
    {
        Active = 1,
        Supended = 2,
        Deleted = 3,
    }
    public class AccountStatus
    {
        public AccountStatus() 
        {
            this.Name = "";
        }

        public StatusType Id { get; set; }
        public string Name { get; set; }
    }
}
