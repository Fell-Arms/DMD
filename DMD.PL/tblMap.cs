using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblMap
    {
        public tblMap()
        {
            tblUserMaps = new HashSet<tblUserMap>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; } = null!;
        public string ImagePath { get; set; } = null!;

        public virtual ICollection<tblUserMap> tblUserMaps { get; set; }
    }
}
