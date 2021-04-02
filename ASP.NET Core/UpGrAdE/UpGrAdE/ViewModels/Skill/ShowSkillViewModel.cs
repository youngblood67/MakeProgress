﻿using UpGrAdE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.ViewModels
{
    public class ShowSkillViewModel
    {
        public string PageTitle { get; set; }

        public List<Skill> Skills { get; set; } = new List<Skill>();
       
    }
}
