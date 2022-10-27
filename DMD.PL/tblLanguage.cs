using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblLanguage
    {
        public tblLanguage()
        {
            tblCharacterLanguages = new HashSet<tblCharacterLanguage>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<tblCharacterLanguage> tblCharacterLanguages { get; set; }
    }
}
