using EmptyProject.Models.Interfaces;
using EmptyProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyProject.Controllers
{
    [Route("")]
    [Route("Learning")]
    public class LearningController : Controller
    {
        private readonly IPersonRepository _personRepository;
        private readonly ISkillRepository _skillRepository;
        public LearningController(IPersonRepository personRepository, ISkillRepository skillRepository)
        {
            _personRepository = personRepository;
            _skillRepository = skillRepository;
        }

        [Route("")]
        [Route("Skill")]
        [Route("Skills")]
        public ViewResult Skills()
        {
            LearningSkillsViewModel viewModel = new LearningSkillsViewModel();
            viewModel.Title = "Nouvelle compétence étudiée :";
            return View(viewModel);   
            //return View("~/Views/Home/MyHomePage.cshtml,viewModel);
        }

      
    }
}
