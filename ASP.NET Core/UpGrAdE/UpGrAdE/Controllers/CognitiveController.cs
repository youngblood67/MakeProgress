using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class CognitiveController : Controller
    {
        private readonly ShowCognitiveViewModel _showViewModel;
        private readonly AddCognitiveViewModel _addViewModel;
        private readonly PurposeCognitiveViewModel _purposeModel;


        public CognitiveController()
        {
            _showViewModel = new ShowCognitiveViewModel();
            _addViewModel = new AddCognitiveViewModel();
            _purposeModel = new PurposeCognitiveViewModel();
        }



        [Route("ShowCognitive")]
        public ViewResult ShowCognitive()
        {
            _showViewModel.PageTitle = "Aptitudes cognitives :";
            return View("~/Views/Cognitive/ShowCognitive.cshtml", _showViewModel);
        }

        [Route("AddCognitive")]
        public ViewResult AddCognitive()
        {
            _addViewModel.PageTitle = "Entrainement aux aptitudes cognitives :";
            return View("~/Views/Cognitive/AddCognitive.cshtml", _addViewModel);
        }

        [Route("PurposeCognitive")]
        public ViewResult PurposeCognitive()
        {
            _purposeModel.PageTitle = "Objectifs cognitifs :";
            return View("~/Views/Cognitive/PurposeCognitive.cshtml", _purposeModel);
        }


    }
}
