using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class CognitiveController : Controller
    {
        private readonly ShowCognitiveViewModel _showViewModel;
        private readonly CreateCognitiveViewModel _createViewModel;
        private readonly PurposeCognitiveViewModel _purposeModel;


        public CognitiveController()
        {
            _showViewModel = new ShowCognitiveViewModel();
            _createViewModel = new CreateCognitiveViewModel();
            _purposeModel = new PurposeCognitiveViewModel();
        }



        [Route("ShowCognitive")]
        [Route("sc")]
        public ViewResult ShowCognitive()
        {
            _showViewModel.PageTitle = "Aptitudes cognitives :";
            return View("~/Views/Cognitive/ShowCognitive.cshtml", _showViewModel);
        }

        [Route("CreateCognitive")]
        [Route("cc")]
        public ViewResult CreateCognitive()
        {
            _createViewModel.PageTitle = "Entrainement aux aptitudes cognitives :";
            return View("~/Views/Cognitive/CreateCognitive.cshtml", _createViewModel);
        }

        [Route("PurposeCognitive")]
        [Route("pc")]
        public ViewResult PurposeCognitive()
        {
            _purposeModel.PageTitle = "Objectifs cognitifs :";
            return View("~/Views/Cognitive/PurposeCognitive.cshtml", _purposeModel);
        }


    }
}
