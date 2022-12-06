using System.ComponentModel;

namespace DMD.BL.Models
{
    public class User
    {
        public Guid Id { get; set; } // use guids instead of integers for the Id 
        [DisplayName("Username")] public string UserName { get; set; }
        public string Password { get; set; } //todo: Make sure this is hashed later.

        public string Email { get; set; }
        [DisplayName("First Name")] public string FirstName { get; set; }
        [DisplayName("Last Name")] public string LastName { get; set; }
        [DisplayName("Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public List<Character> Characters { get; set; }
        //public string? Address { get; set; }
    }
}