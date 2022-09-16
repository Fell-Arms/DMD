using System;
using System.Collections.Generic;

namespace DMD.PL
{
    public partial class Character
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public string Race { get; set; } = null!;
        public string Class { get; set; } = null!;
        public int Level { get; set; }
        public int ArmorClass { get; set; }
        public string MaxHealth { get; set; } = null!;
        public string CurrentHealth { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public Guid LanguageId { get; set; }
        public Guid StatsId { get; set; }
        public Guid AttacksId { get; set; }
        public string Alignment { get; set; } = null!;
        public string? Portrait { get; set; }
        public int? Age { get; set; }
        public string? Height { get; set; }
        public double? Weight { get; set; }
        public string? EyeColor { get; set; }
        public string? HairColor { get; set; }
        public string? HairStyle { get; set; }
    }
}
