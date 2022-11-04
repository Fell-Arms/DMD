using DMD.BL.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMD.UI.ViewModels
{
    public class CharacterViewModel
    {
        //-----BL Model-----Name------get/set

        public Character Character { get; set; } //Uses entire character model
        public User User { get; set; } //Uses entire user model

        public IEnumerable<int> UserIds { get; set; }

        //List from - BL Model---Name-------get/set

        public List<Language> Languages { get; set; }       //Lists all the LANGUAGES to choose from
        public List<Class> Classes { get; set; }            //Lists all the CLASSES to choose from
        
        public List<Race> Races { get; set; }               //Lists all the RACES to choose from

        public List<Stat> Stats { get; set; }               //Lists all the STATS to choose from
        public List<StatModifier> StatModifiers { get; set; }//Lists all the STAT MODIFIERS to choose from
        public List<Weapon> Weapons { get; set; }           //Lists all the WEAPONS to choose from
        public List<Armor> Armors { get; set; }             //Lists all the ARMORS to choose from
    }
}
