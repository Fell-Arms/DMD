using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblUserMap
    {
        public Guid Id { get; set; }
        public Guid User_Id { get; set; }
        public Guid Map_Id { get; set; }

        public virtual tblMap Map { get; set; } = null!;
        public virtual tblUser User { get; set; } = null!;
    }
}
