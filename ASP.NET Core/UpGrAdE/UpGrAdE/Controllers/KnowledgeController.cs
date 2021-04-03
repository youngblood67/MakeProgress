using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class KnowledgeController : Controller
    {
        private readonly ShowKnowledgeViewModel _showViewModel;
        private readonly AddKnowledgeViewModel _addViewModel;
        private readonly PurposeKnowledgeViewModel _purposeModel;


        public KnowledgeController()
        {
            _showViewModel = new ShowKnowledgeViewModel();
            _addViewModel = new AddKnowledgeViewModel();
            _purposeModel = new PurposeKnowledgeViewModel();
        }


        [Route("ShowKnowledge")]
        public ViewResult ShowKnowledge()
        {
            _showViewModel.PageTitle = "Connaissances, culture générale :";
            return View("~/Views/Knowledge/ShowKnowledge.cshtml", _showViewModel);
        }

        [Route("AddKnowledge")]
        public ViewResult AddKnowledge()
        {
            _addViewModel.PageTitle = "Ajout de nouvelles connaissances";
            return View("~/Views/Knowledge/AddKnowledge.cshtml", _addViewModel);
        }

        [Route("PurposeKnowledge")]
        public ViewResult PurposeKnowledge()
        {
            _purposeModel.PageTitle = "Objectifs d'acquisition des connaissances :";
            return View("~/Views/Knowledge/PurposeKnowledge.cshtml", _purposeModel);
        }

    }
}
