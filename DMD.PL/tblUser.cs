using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblUser
    {
        public tblUser()
        {
            tblCharacters = new HashSet<tblCharacter>();
            tblUserMaps = new HashSet<tblUserMap>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<tblCharacter> tblCharacters { get; set; }
        public virtual ICollection<tblUserMap> tblUserMaps { get; set; }
    }
}
