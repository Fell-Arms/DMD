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

        public Language Language { get; set; }       //Uses entire LANGUAGE model
        public Class Class { get; set; }            //Uses entire CLASS model
        public Skill Skill { get; set; }             //Uses entire SKILL model
        public Race Race { get; set; }               //Uses entire RACE model
        public Stat Stat { get; set; }              //Uses entire STAT model
        public Weapon Weapon { get; set; }           //Uses entire WEAPON model
        public Armor Armor { get; set; }             //Uses entire ARMOR model

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
