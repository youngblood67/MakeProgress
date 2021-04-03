using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpGrAdE.Models;
using UpGrAdE.Models.Interfaces;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class KnowledgeController : Controller
    {
        private readonly ShowKnowledgeViewModel _showViewModel;
        private readonly AddKnowledgeViewModel _addViewModel;
        private readonly PurposeKnowledgeViewModel _purposeModel;
        private IKnowledgeRepository _knowledgeRepository;


        public KnowledgeController(IKnowledgeRepository knowledgeRepository)
        {
            _showViewModel = new ShowKnowledgeViewModel();
            _addViewModel = new AddKnowledgeViewModel();
            _purposeModel = new PurposeKnowledgeViewModel();
            _knowledgeRepository = knowledgeRepository;
        }

        [HttpGet]
        [Route("AddKnowledge")]
        public ViewResult AddKnowledge()
        {
            _addViewModel.PageTitle = "Ajout de nouvelles connaissances";
            return View("~/Views/Knowledge/AddKnowledge.cshtml", _addViewModel);
        }

        [HttpPost]
        [Route("AddKnowledge")]
        public ViewResult AddKnowledge(string? skillTitle, string? significiantPoints, string? feedback)
        {
            _showViewModel.PageTitle = "Nouvelle connaissance ajoutée :";
            List<string> listSignificiantPoints = new List<string>();
            if (significiantPoints != null)
            {
                foreach (var s in significiantPoints.Split("\r\n"))
                {
                    listSignificiantPoints.Add(s);
                }
            }
            Knowledge knowledge = new Knowledge(skillTitle, listSignificiantPoints, feedback);
            _knowledgeRepository.Add(knowledge);
            _showViewModel.Knowledges = _knowledgeRepository.GetKnowledges();
            return View("~/Views/Knowledge/ShowKnowledge.cshtml", _showViewModel);


        }

        [Route("ShowKnowledge")]
        public ViewResult ShowKnowledge()
        {
            _showViewModel.PageTitle = "Connaissances, culture générale :";
            return View("~/Views/Knowledge/ShowKnowledge.cshtml", _showViewModel);
        }

        [Route("PurposeKnowledge")]
        public ViewResult PurposeKnowledge()
        {
            _purposeModel.PageTitle = "Objectifs d'acquisition des connaissances :";
            return View("~/Views/Knowledge/PurposeKnowledge.cshtml", _purposeModel);
        }

    }
}
