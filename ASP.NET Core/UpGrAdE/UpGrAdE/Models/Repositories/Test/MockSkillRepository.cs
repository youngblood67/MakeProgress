using UpGrAdE.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Repositories
{
    public class MockSkillRepository : ISkillRepository
    {
        private List<Skill> _skillsList;


        public MockSkillRepository()
        {
            _skillsList = new List<Skill> {
                  new Skill(
                   "Révision sur les bases ASP.NET MVC Core : View, Model, Controller",
                 new List<string>{
                       "Utilisation d'un repository implémentant une interface pour permettre l'injection de dépendance",
                       "Configuration de Startup.cs",
                       "AddSingleton<I, Rep>()"
                   },
                  "Super cool"),

                new Skill (
                  "Apprendre ASP.NET MVC Core : View, ViewBag, ViewData, ViewModel",
                   new List<string>{
                   "Passage de données du controleur vers la vue"
                     },
                   "Super cool")
             };
        }

        public void Add(Skill skill)
        {
            _skillsList.Add(skill);
        }

        public Skill GetSkill(int id)
        {
            return this._skillsList.FirstOrDefault(e => e.Id == id);
        }

        public List<Skill> GetSkills()
        {
            return _skillsList;
        }

        public List<Skill> GetSkillsByCategory(string category)
        {
            throw new NotImplementedException();
        }
    }
}
