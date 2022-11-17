using DMD.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMD.UI.ViewModels
{
    public class CharacterViewModel
    {
        //BASE CLASS from - BL Model---Name-------get/set

        public Character Character { get; set; } //Uses entire character model
        public User User { get; set; } //Uses entire user model

        public Guid ClassId { get; set; } //


        public List<Guid> SelectedLanguageIds { get; set; } //Gets the selected LANGUAGES
        public List<Guid> SelectedArmorIds { get; set; } //Gets the selected ARMORS
        public List<Guid> SelectedWeaponIds { get; set; } //Gets the selected WEAPONS
        public List<Guid> SelectedSkillIds { get; set; } //Gets the selected SKILLS

        public List<Guid> CharacterStatIds { get; set; }               //Lists all the STATS to choose from
        public List<Stat> CharacterStats { get; set; }               //Lists all the STATS to choose from

        public List<int> CharacterStatValues { get; set; }

        public Class Class { get; set; }            //Uses entire CLASS model
        public Race Race { get; set; }               //Uses entire RACE model
        public Stat Stat { get; set; }              //Uses entire STAT model

        //LIST from - BL Model---Name-------get/set

        public List<Language> Languages { get; set; }       //Lists all the LANGUAGES to choose from
        public List<Class> Classes { get; set; }            //Lists all the CLASSES to choose from
        public List<Skill> Skills { get; set; }             //Lists all the SKILLS to choose PROFICIENCY from
        public List<Race> Races { get; set; }               //Lists all the RACES to choose from
        public List<Stat> Stats { get; set; }               //Lists all the STATS to choose from
        public List<Weapon> Weapons { get; set; }           //Lists all the WEAPONS to choose from
        public List<Armor> Armors { get; set; }             //Lists all the ARMORS to choose from


        /*
        public IEnumerable<Guid> LanguageIds { get; set; }
        public IEnumerable<Guid> ClassIds { get; set; }
        public Guid RaceId { get; set; }
        public IEnumerable<Guid> StatIds { get; set; }
        public IEnumerable<Guid> WeaponIds { get; set; }
        */
    }
}
