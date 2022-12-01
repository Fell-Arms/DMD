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
    public class PlayViewModel
    {
        //BASE CLASS from - BL Model---Name-------get/set

        public Character currentUserCharacter { get; set; }
        public List<Character> allUserCharacters { get; set; } // List all the CHARACTERS.
        public User User { get; set; } //Uses entire user model
        public List<Map> myMaps { get; set; } // List all the MAPS

        public Guid SelectedCharacterId { get; set; } //


        //-------------FOR STATS LOADING AND UPDATES ------------------------
        public List<Stat> CharacterStats { get; set; }               //Lists all the STATS to choose from
        public List<Guid> CharacterStatIds { get; set; }               //Lists all the Stat Ids a character should have.
        public List<int> CharacterStatValues { get; set; }            // Lists the values of the CharacterStatIds (The character stats)
        public List<Stat> Stats { get; set; }               //Lists all the STATS to choose VALUES from

    }
}
