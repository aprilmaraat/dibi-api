using System;
using System.Security.Principal;

namespace Dibi.Auth.Models
{
    public class UserData
    {
        public UserData() 
        {
            this.EmailAddress = "";
            this.FirstName = "";
            this.LastName = "";
            this.ProfilePicture = "";
        }
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime DateCreated { get; set; }
    }
}