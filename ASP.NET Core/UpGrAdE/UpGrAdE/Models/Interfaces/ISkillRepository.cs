using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Interfaces
{
    public interface ISkillRepository
    {
        Skill GetSkill(int id);

        List<Skill> GetSkills();

        void Add(Skill skill);
    }
}
