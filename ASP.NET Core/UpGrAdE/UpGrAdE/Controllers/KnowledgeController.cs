using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class KnowledgeController : Controller
    {
        private readonly ShowKnowledgeViewModel _showViewModel;
        private readonly AddKnowledgeViewModel _createViewModel;
        private readonly PurposeKnowledgeViewModel _purposeModel;


        public KnowledgeController()
        {
            _showViewModel = new ShowKnowledgeViewModel();
            _createViewModel = new AddKnowledgeViewModel();
            _purposeModel = new PurposeKnowledgeViewModel();
        }


        [Route("ShowKnowledge")]
        [Route("sk")]
        public ViewResult ShowKnowledge()
        {
            _showViewModel.PageTitle = "Connaissances, culture générale :";
            return View("~/Views/Knowledge/ShowKnowledge.cshtml", _showViewModel);
        }

        [Route("AddKnowledge")]
        [Route("ck")]
        public ViewResult AddKnowledge()
        {
            _createViewModel.PageTitle = "Ajout de nouvelles connaissances";
            return View("~/Views/Knowledge/AddKnowledge.cshtml", _createViewModel);
        }

        [Route("PurposeKnowledge")]
        [Route("pk")]
        public ViewResult PurposeKnowledge()
        {
            _purposeModel.PageTitle = "Objectifs d'acquisition des connaissances :";
            return View("~/Views/Knowledge/PurposeKnowledge.cshtml", _purposeModel);
        }

    }
}
