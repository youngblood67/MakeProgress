using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpGrAdE.Models;
using UpGrAdE.Models.Interfaces;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class PhysicalController : Controller
    {
        private readonly ShowPhysicalViewModel _showViewModel;
        private readonly AddPhysicalViewModel _addViewModel;
        private readonly PurposePhysicalViewModel _purposeModel;
        private IPhysicalRepository _physicalRepository;


        public PhysicalController(IPhysicalRepository physicalRepository)
        {
            _showViewModel = new ShowPhysicalViewModel();
            _addViewModel = new AddPhysicalViewModel();
            _purposeModel = new PurposePhysicalViewModel();
            _physicalRepository = physicalRepository;
        }


        [Route("ShowPhysical")]
        public ViewResult ShowPhysical()
        {
            _showViewModel.PageTitle = "Aptitudes Physiques :";
            return View("~/Views/Physical/ShowPhysical.cshtml", _showViewModel);
        }

        [HttpGet]
        [Route("AddPhysical")]
        public ViewResult AddPhysical()
        {
            _addViewModel.PageTitle = "Entrainement aux aptitudes Physiques :";
            return View("~/Views/Physical/AddPhysical.cshtml", _addViewModel);
        }


        [HttpPost]
        [Route("AddPhysical")]
        public ViewResult AddPhysical(string? skillTitle, int nbRepetitions, string feedback)
        {
            _showViewModel.PageTitle = "Nouvelle aptitude physique entrainée :";

            PhysicalAbility physicalAbility = new PhysicalAbility(skillTitle, feedback,nbRepetitions);
            _physicalRepository.Add(physicalAbility);
            _showViewModel.PhysicalAbilities = _physicalRepository.GetPhysicalAbilities();
            return View("~/Views/Skill/ShowSkill.cshtml", _showViewModel);
        }


        [Route("PurposePhysical")]
        public ViewResult PurposePhysical()
        {
            _purposeModel.PageTitle = "Objectifs physiques :";
            return View("~/Views/Physical/PurposePhysical.cshtml", _purposeModel);
        }
    }
}
