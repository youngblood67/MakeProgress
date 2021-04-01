using UpGrAdE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.ViewModels
{
    public class CreateSkillViewModel
    {
        public string PageTitle { get; set; }

        public string SkillTitle { get; set; }
        public string Feedback { get; set; }

        public string SignificiantPoints { get; set; }
    }
}
