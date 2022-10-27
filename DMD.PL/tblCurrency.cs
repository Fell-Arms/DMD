using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class tblCurrency
    {
        public tblCurrency()
        {
            tblCharacterCurrencies = new HashSet<tblCharacterCurrency>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;

        public virtual ICollection<tblCharacterCurrency> tblCharacterCurrencies { get; set; }
    }
}
