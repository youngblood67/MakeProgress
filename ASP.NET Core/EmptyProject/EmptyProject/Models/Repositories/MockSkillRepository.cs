using EmptyProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyProject.Models.Repositories
{
    public class MockSkillRepository : ISkillRepository
    {
        private List<Skill> _skillsList;


        public MockSkillRepository()
        {
            _skillsList = new List<Skill> {
                  new Skill {
                    Id = 1,
                   Name = "Révision sur les bases ASP.NET MVC Core : View, Model, Controller",
                   Description ="Utilisation d'un repository implémentant une interface pour permettre l'injection de dépendance.Configuration de Startup.cs AddSingleton<I, Rep>()"
                },
                new Skill {
                    Id = 2,
                   Name = "Apprendre ASP.NET MVC Core : View, ViewBag, ViewData, ViewModel",
                   Description = "Passage de données du controleur vers la vue"
                },

            };
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
