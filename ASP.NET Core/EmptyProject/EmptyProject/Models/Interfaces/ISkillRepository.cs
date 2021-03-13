using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyProject.Models.Interfaces
{
    public interface ISkillRepository
    {
        Skill GetSkill(int id);

        List<Skill> GetSkills();

        List<Skill> GetSkillsByCategory(string category);
    }
}
