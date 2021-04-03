using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models
{
    public abstract class Ability : Upgrade
    {
        public Ability(string title, string feedback) : base(title, feedback) { }
    
    }
}
