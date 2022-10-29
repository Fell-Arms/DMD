using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DMD.PL
{
    public partial class DMDEntities : DbContext
    {
        public DMDEntities()
        {
        }

        public DMDEntities(DbContextOptions<DMDEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<tblArmor> tblArmors { get; set; } = null!;
        public virtual DbSet<tblArmorStyle> tblArmorStyles { get; set; } = null!;
        public virtual DbSet<tblArmorType> tblArmorTypes { get; set; } = null!;
        public virtual DbSet<tblAttack> tblAttacks { get; set; } = null!;
        public virtual DbSet<tblAttackDamageType> tblAttackDamageTypes { get; set; } = null!;
        public virtual DbSet<tblCharacter> tblCharacters { get; set; } = null!;
        public virtual DbSet<tblCharacterArmor> tblCharacterArmors { get; set; } = null!;
        public virtual DbSet<tblCharacterAttack> tblCharacterAttacks { get; set; } = null!;
        public virtual DbSet<tblCharacterClass> tblCharacterClasses { get; set; } = null!;
        public virtual DbSet<tblCharacterCurrency> tblCharacterCurrencies { get; set; } = null!;
        public virtual DbSet<tblCharacterLanguage> tblCharacterLanguages { get; set; } = null!;
        public virtual DbSet<tblCharacterLevel> tblCharacterLevels { get; set; } = null!;
        public virtual DbSet<tblCharacterSpell> tblCharacterSpells { get; set; } = null!;
        public virtual DbSet<tblCharacterSpellCharge> tblCharacterSpellCharges { get; set; } = null!;
        public virtual DbSet<tblCharacterStat> tblCharacterStats { get; set; } = null!;
        public virtual DbSet<tblCharacterWeapon> tblCharacterWeapons { get; set; } = null!;
        public virtual DbSet<tblCharacterWeaponTypeProficiency> tblCharacterWeaponTypeProficiencies { get; set; } = null!;
        public virtual DbSet<tblClass> tblClasses { get; set; } = null!;
        public virtual DbSet<tblClassSpell> tblClassSpells { get; set; } = null!;
        public virtual DbSet<tblCurrency> tblCurrencies { get; set; } = null!;
        public virtual DbSet<tblDamageType> tblDamageTypes { get; set; } = null!;
        public virtual DbSet<tblLanguage> tblLanguages { get; set; } = null!;
        public virtual DbSet<tblMap> tblMaps { get; set; } = null!;
        public virtual DbSet<tblRace> tblRaces { get; set; } = null!;
        public virtual DbSet<tblSkill> tblSkills { get; set; } = null!;
        public virtual DbSet<tblSpell> tblSpells { get; set; } = null!;
        public virtual DbSet<tblSpellChargesByLevel> tblSpellChargesByLevels { get; set; } = null!;
        public virtual DbSet<tblSpellDamageType> tblSpellDamageTypes { get; set; } = null!;
        public virtual DbSet<tblStat> tblStats { get; set; } = null!;
        public virtual DbSet<tblStatModifier> tblStatModifiers { get; set; } = null!;
        public virtual DbSet<tblUser> tblUsers { get; set; } = null!;
        public virtual DbSet<tblUserMap> tblUserMaps { get; set; } = null!;
        public virtual DbSet<tblWeapon> tblWeapons { get; set; } = null!;
        public virtual DbSet<tblWeaponDamageType> tblWeaponDamageTypes { get; set; } = null!;
        public virtual DbSet<tblWeaponType> tblWeaponTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;Database=DMD.DB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblArmor>(entity =>
            {
                entity.ToTable("tblArmor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.ArmorStyle)
                    .WithMany(p => p.tblArmors)
                    .HasForeignKey(d => d.ArmorStyle_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkArmorStyle-ArmorStyleId");

                entity.HasOne(d => d.ArmorType)
                    .WithMany(p => p.tblArmors)
                    .HasForeignKey(d => d.ArmorType_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkArmorType-ArmorTypeId");
            });

            modelBuilder.Entity<tblArmorStyle>(entity =>
            {
                entity.ToTable("tblArmorStyle");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StyleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblArmorType>(entity =>
            {
                entity.ToTable("tblArmorType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblAttack>(entity =>
            {
                entity.ToTable("tblAttack");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.tblAttacks)
                    .HasForeignKey(d => d.Class_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkClassId-Attack");

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.tblAttacks)
                    .HasForeignKey(d => d.Stat_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkStatId-Attack");

                entity.HasOne(d => d.WeaponType)
                    .WithMany(p => p.tblAttacks)
                    .HasForeignKey(d => d.WeaponType_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkWeaponTypeId-Attack");
            });

            modelBuilder.Entity<tblAttackDamageType>(entity =>
            {
                entity.HasKey(e => new { e.DamageType_Id, e.Attack_Id })
                    .HasName("PK_AttackDamageTypes");

                entity.HasOne(d => d.Attack)
                    .WithMany(p => p.tblAttackDamageTypes)
                    .HasForeignKey(d => d.Attack_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkAttacksId-AttackDamageTypes");

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.tblAttackDamageTypes)
                    .HasForeignKey(d => d.DamageType_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkDamageTypeId-AttackDamageTypes");
            });

            modelBuilder.Entity<tblCharacter>(entity =>
            {
                entity.ToTable("tblCharacter");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Background)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.CharacterLevel)
                    .WithMany(p => p.tblCharacters)
                    .HasForeignKey(d => d.CharacterLevel_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterLevelId-Characters");

                entity.HasOne(d => d.Race)
                    .WithMany(p => p.tblCharacters)
                    .HasForeignKey(d => d.Race_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkRaceId-Characters");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.tblCharacters)
                    .HasForeignKey(d => d.User_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkUserId-Characters");

                entity.HasMany(d => d.Skills)
                    .WithMany(p => p.Characters)
                    .UsingEntity<Dictionary<string, object>>(
                        "tblCharacterSkillProficiency",
                        l => l.HasOne<tblSkill>().WithMany().HasForeignKey("Skill_Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fkSkillId-CharacterSkillProficiency"),
                        r => r.HasOne<tblCharacter>().WithMany().HasForeignKey("Character_Id").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("fkCharacterId-CharacterSkillProficiency"),
                        j =>
                        {
                            j.HasKey("Character_Id", "Skill_Id").HasName("PK_CharacterSkill");

                            j.ToTable("tblCharacterSkillProficiency");
                        });
            });

            modelBuilder.Entity<tblCharacterArmor>(entity =>
            {
                entity.ToTable("tblCharacterArmor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Armor)
                    .WithMany(p => p.tblCharacterArmors)
                    .HasForeignKey(d => d.Armor_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkArmorId-CharacterArmor");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterArmors)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterArmor");
            });

            modelBuilder.Entity<tblCharacterAttack>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Attack)
                    .WithMany(p => p.tblCharacterAttacks)
                    .HasForeignKey(d => d.Attack_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkAttacksId-CharacterAttacks");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterAttacks)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterAttacks");
            });

            modelBuilder.Entity<tblCharacterClass>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterClasses)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterClasses");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.tblCharacterClasses)
                    .HasForeignKey(d => d.Class_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkClassId-CharacterClasses");
            });

            modelBuilder.Entity<tblCharacterCurrency>(entity =>
            {
                entity.ToTable("tblCharacterCurrency");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterCurrencies)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterCurrency");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.tblCharacterCurrencies)
                    .HasForeignKey(d => d.Currency_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCurrencyId-Currency");
            });

            modelBuilder.Entity<tblCharacterLanguage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterLanguages)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterLanguages");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.tblCharacterLanguages)
                    .HasForeignKey(d => d.Language_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkLanguageId-Language");
            });

            modelBuilder.Entity<tblCharacterLevel>(entity =>
            {
                entity.ToTable("tblCharacterLevel");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblCharacterSpell>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterSpells)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterSpells");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.tblCharacterSpells)
                    .HasForeignKey(d => d.Spell_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkSpellId-CharacterSpells");
            });

            modelBuilder.Entity<tblCharacterSpellCharge>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterSpellCharges)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterSpellCharges");

                entity.HasOne(d => d.Spell_Charges_By_Level)
                    .WithMany(p => p.tblCharacterSpellCharges)
                    .HasForeignKey(d => d.Spell_Charges_By_Level_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkSpellChargesByLevel-CharacterSpellCharges");
            });

            modelBuilder.Entity<tblCharacterStat>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterStats)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterStats");

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.tblCharacterStats)
                    .HasForeignKey(d => d.Stats_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkStatId-CharacterStats");

                entity.HasOne(d => d.ValueNavigation)
                    .WithMany(p => p.tblCharacterStats)
                    .HasForeignKey(d => d.Value)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkValueId-CharacterStats");
            });

            modelBuilder.Entity<tblCharacterWeapon>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterWeapons)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterWeapons");

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.tblCharacterWeapons)
                    .HasForeignKey(d => d.Weapon_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkWeaponId-CharacterWeapons");
            });

            modelBuilder.Entity<tblCharacterWeaponTypeProficiency>(entity =>
            {
                entity.ToTable("tblCharacterWeaponTypeProficiency");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.tblCharacterWeaponTypeProficiencies)
                    .HasForeignKey(d => d.Character_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCharacterId-CharacterWeaponTypeProficiency");

                entity.HasOne(d => d.WeaponType)
                    .WithMany(p => p.tblCharacterWeaponTypeProficiencies)
                    .HasForeignKey(d => d.WeaponType_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkWeaponTypeId-CharacterWeaponTypeProficiency");
            });

            modelBuilder.Entity<tblClass>(entity =>
            {
                entity.ToTable("tblClass");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblClassSpell>(entity =>
            {
                entity.HasKey(e => e.Spell_Id)
                    .HasName("PK__tblClass__30FA58BEAAFD4203");

                entity.Property(e => e.Spell_Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.tblClassSpells)
                    .HasForeignKey(d => d.Class_Id)
                    .HasConstraintName("fkClassId-Class Spells");

                entity.HasOne(d => d.Spell)
                    .WithOne(p => p.tblClassSpell)
                    .HasForeignKey<tblClassSpell>(d => d.Spell_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkSpellId-ClassSpells");
            });

            modelBuilder.Entity<tblCurrency>(entity =>
            {
                entity.ToTable("tblCurrency");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblDamageType>(entity =>
            {
                entity.ToTable("tblDamageType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblLanguage>(entity =>
            {
                entity.ToTable("tblLanguage");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblMap>(entity =>
            {
                entity.ToTable("tblMap");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblRace>(entity =>
            {
                entity.ToTable("tblRace");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblSkill>(entity =>
            {
                entity.ToTable("tblSkill");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.tblSkills)
                    .HasForeignKey(d => d.Stats_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkStatId-Skill");
            });

            modelBuilder.Entity<tblSpell>(entity =>
            {
                entity.ToTable("tblSpell");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.tblSpells)
                    .HasForeignKey(d => d.Stat_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkStatId-Spell");
            });

            modelBuilder.Entity<tblSpellChargesByLevel>(entity =>
            {
                entity.ToTable("tblSpellChargesByLevel");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.tblSpellChargesByLevels)
                    .HasForeignKey(d => d.Class_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkClassId-SoellChargesByLevel");
            });

            modelBuilder.Entity<tblSpellDamageType>(entity =>
            {
                entity.HasKey(e => new { e.DamageType_Id, e.Spell_Id })
                    .HasName("PK_SpellDamageTypes");

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.tblSpellDamageTypes)
                    .HasForeignKey(d => d.DamageType_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkDamageTypeId-SpellDamageTypes");

                entity.HasOne(d => d.Spell)
                    .WithMany(p => p.tblSpellDamageTypes)
                    .HasForeignKey(d => d.Spell_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkSpellId-SpellDamageTypes");
            });

            modelBuilder.Entity<tblStat>(entity =>
            {
                entity.ToTable("tblStat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblStatModifier>(entity =>
            {
                entity.HasKey(e => e.Value)
                    .HasName("PK__tblStatM__07D9BBC392605E6C");

                entity.ToTable("tblStatModifier");

                entity.Property(e => e.Value).ValueGeneratedNever();
            });

            modelBuilder.Entity<tblUser>(entity =>
            {
                entity.ToTable("tblUser");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tblUserMap>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Map)
                    .WithMany(p => p.tblUserMaps)
                    .HasForeignKey(d => d.Map_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkMapId-UserMaps");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.tblUserMaps)
                    .HasForeignKey(d => d.User_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkUserId-UserMaps");
            });

            modelBuilder.Entity<tblWeapon>(entity =>
            {
                entity.ToTable("tblWeapon");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Stats)
                    .WithMany(p => p.tblWeapons)
                    .HasForeignKey(d => d.Stats_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkStatId-Weapon");

                entity.HasOne(d => d.WeaponType)
                    .WithMany(p => p.tblWeapons)
                    .HasForeignKey(d => d.WeaponType_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkWeaponTypeId-Weapon");
            });

            modelBuilder.Entity<tblWeaponDamageType>(entity =>
            {
                entity.HasKey(e => new { e.Weapon_Id, e.DamageType_id })
                    .HasName("PK_WeaponDamageTypes");

                entity.HasOne(d => d.DamageType)
                    .WithMany(p => p.tblWeaponDamageTypes)
                    .HasForeignKey(d => d.DamageType_id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkDamageTypeId-WeaponDamageTypes");

                entity.HasOne(d => d.Weapon)
                    .WithMany(p => p.tblWeaponDamageTypes)
                    .HasForeignKey(d => d.Weapon_Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkWeaponId-WeaponDamageTypes");
            });

            modelBuilder.Entity<tblWeaponType>(entity =>
            {
                entity.ToTable("tblWeaponType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
