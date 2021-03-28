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
        private LearningSkillsViewModel viewModel;
        public LearningController(IPersonRepository personRepository, ISkillRepository skillRepository)
        {
            _personRepository = personRepository;
            _skillRepository = skillRepository;
           viewModel = new LearningSkillsViewModel();
        }

        [Route("")]
        [Route("Skill")]
        [Route("s")]
        public ViewResult Skill()
        {       
            viewModel.Title = "Acquisition de compétence :";
            return View(viewModel);   
            //return View("~/Views/Home/MyHomePage.cshtml,viewModel);
        }

     
        [Route("Knowledge")]
        [Route("k")]
        public ViewResult Knowledge()
        {
            viewModel.Title = "Connaissances, culture générale :";
            return View(viewModel);
            //return View("~/Views/Home/MyHomePage.cshtml,viewModel);
        }

  
        [Route("Cognitive")]
        [Route("c")]
        public ViewResult Cognitive()
        {
            viewModel.Title = "Aptitudes cognitives :";
            return View(viewModel);
            //return View("~/Views/Home/MyHomePage.cshtml,viewModel);
        }


        [Route("Physical")]
        [Route("p")]
        public ViewResult Physical()
        {
            viewModel.Title = "Aptitudes Physiques :";
            return View(viewModel);
            //return View("~/Views/Home/MyHomePage.cshtml,viewModel);
        }


    }
}
