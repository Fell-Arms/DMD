﻿using DMD.BL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMD.UI.ViewModels
{
    public class AccountViewModel
    {
        //BASE CLASS from - BL Model---Name-------get/set

        public List<Character> userCharacters { get; set; } // List all the CHARACTERS.
        public User User { get; set; } //Uses entire user model
        public List<Map> myMaps { get; set; } // List all the MAPS
    }
}
