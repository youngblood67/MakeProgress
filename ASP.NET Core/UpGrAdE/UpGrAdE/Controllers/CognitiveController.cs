using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class CognitiveController : Controller
    {
        private readonly ShowCognitiveViewModel _showViewModel;
        private readonly AddCognitiveViewModel _createViewModel;
        private readonly PurposeCognitiveViewModel _purposeModel;


        public CognitiveController()
        {
            _showViewModel = new ShowCognitiveViewModel();
            _createViewModel = new AddCognitiveViewModel();
            _purposeModel = new PurposeCognitiveViewModel();
        }



        [Route("ShowCognitive")]
        [Route("sc")]
        public ViewResult ShowCognitive()
        {
            _showViewModel.PageTitle = "Aptitudes cognitives :";
            return View("~/Views/Cognitive/ShowCognitive.cshtml", _showViewModel);
        }

        [Route("AddCognitive")]
        [Route("cc")]
        public ViewResult AddCognitive()
        {
            _createViewModel.PageTitle = "Entrainement aux aptitudes cognitives :";
            return View("~/Views/Cognitive/AddCognitive.cshtml", _createViewModel);
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
