using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGrAdE.Models.Interfaces;

namespace UpGrAdE.Models.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private List<Skill> _skills;

        public SkillRepository()
        {
            _skills = new List<Skill>();
        }

        public void Add(Skill skill)
        {
            _skills.Add(skill);
        }

        public Skill GetSkill(int id)
        {
            return _skills.FirstOrDefault(e => e.Id == id);
        }

        public List<Skill> GetSkills()
        {
            return _skills;
        }
    }
}
