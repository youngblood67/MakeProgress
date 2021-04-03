using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models
{
    public class PhysicalAbility : Ability
    {
        public int NbRepetitions { get; set; }

        public PhysicalAbility(string title, string feedback) : base(title, feedback)
        {
            NbRepetitions = 0;
        }

        public PhysicalAbility(string title, string feedback, int nbRepetitions) : base(title, feedback)
        {
            NbRepetitions = nbRepetitions;
        }

    }
}
