﻿using UpGrAdE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.ViewModels
{
    public class ShowPhysicalViewModel
    {
        public string PageTitle { get; set; }

        public List<PhysicalAbility> PhysicalAbilities { get; set; } = new List<PhysicalAbility>();
    }
}
