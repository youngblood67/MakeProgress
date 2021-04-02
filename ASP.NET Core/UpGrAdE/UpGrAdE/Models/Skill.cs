using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models
{
    public class Skill : Upgrade
    {
        public List<string> SignificiantPoints { get; set; }

        public Skill(string title, List<string> significiantPoints, string feedback) : base(title, feedback)
        {
            this.SignificiantPoints = significiantPoints;
        }




    }
}
