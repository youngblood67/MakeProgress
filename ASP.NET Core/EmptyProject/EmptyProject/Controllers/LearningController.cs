using EmptyProject.Models;
using EmptyProject.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyProject.Controllers
{
    public class LearningController : Controller
    {
        private readonly IPersonRepository _personRepository;
        private readonly ISkillRepository _skillRepository;
        public LearningController(IPersonRepository personRepository, ISkillRepository skillRepository)
        {
            _personRepository = personRepository;
            _skillRepository = skillRepository;
        }



        public ViewResult Skills()
        {
            ViewBag.PageTitle = "Aujourd'hui : ";
            Person person = _personRepository.GetPerson(1);
            Skill skill = _skillRepository.GetSkill(1);
            return View(skill);         
        }

      
    }
}
