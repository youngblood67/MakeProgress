using Microsoft.AspNetCore.Mvc;
using UpGrAdE.Models;
using UpGrAdE.Models.Interfaces;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class CognitiveController : Controller
    {
        private readonly ShowCognitiveViewModel _showViewModel;
        private readonly AddCognitiveViewModel _addViewModel;
        private readonly PurposeCognitiveViewModel _purposeModel;
        private ICognitiveRepository _cognitiveRepository;


        public CognitiveController(ICognitiveRepository cognitiveRepository)
        {
            _showViewModel = new ShowCognitiveViewModel();
            _addViewModel = new AddCognitiveViewModel();
            _purposeModel = new PurposeCognitiveViewModel();
            _cognitiveRepository = cognitiveRepository;
        }



        [Route("ShowCognitive")]
        public ViewResult ShowCognitive()
        {
            _showViewModel.PageTitle = "Aptitudes cognitives :";
            return View("~/Views/Cognitive/ShowCognitive.cshtml", _showViewModel);
        }

        [HttpGet]
        [Route("AddCognitive")]
        public ViewResult AddCognitive()
        {
            _addViewModel.PageTitle = "Entrainement aux aptitudes cognitives :";
            return View("~/Views/Cognitive/AddCognitive.cshtml", _addViewModel);
        }

        [HttpPost]
        [Route("AddCognitive")]
        public ViewResult AddPhysical(string? skillTitle, int nbRepetitions, string feedback)
        {
            _showViewModel.PageTitle = "Nouvelle aptitude physique entrainée :";

            CognitiveAbility cognitiveAbility = new CognitiveAbility(skillTitle, feedback);
            _cognitiveRepository.Add(cognitiveAbility);
            _showViewModel.CognitiveAbilities = _cognitiveRepository.GetCognitiveAbilities();
            return View("~/Views/Skill/ShowCognitive.cshtml", _showViewModel);
        }


        [Route("PurposeCognitive")]
        public ViewResult PurposeCognitive()
        {
            _purposeModel.PageTitle = "Objectifs cognitifs :";
            return View("~/Views/Cognitive/PurposeCognitive.cshtml", _purposeModel);
        }


    }
}
