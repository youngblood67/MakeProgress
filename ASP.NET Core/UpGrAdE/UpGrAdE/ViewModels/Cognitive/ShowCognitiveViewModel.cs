﻿using UpGrAdE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.ViewModels
{
    public class ShowCognitiveViewModel
    {
        public string PageTitle { get; set; }

        public List<CognitiveAbility> CognitiveAbilities { get; set; } = new List<CognitiveAbility>();
    }
}
