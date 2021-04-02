using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpGrAdE.Models;
using UpGrAdE.Models.Interfaces;
using UpGrAdE.Models.Repositories;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class SkillController : Controller
    {
        private readonly ShowSkillViewModel _showViewModel;
        private readonly AddSkillViewModel _createViewModel;
        private readonly PurposeSkillViewModel _purposeModel;
        private ISkillRepository _skillRepository;


        public SkillController(ISkillRepository skillRepository)
        {
            _showViewModel = new ShowSkillViewModel();
            _createViewModel = new AddSkillViewModel();
            _purposeModel = new PurposeSkillViewModel();
            _skillRepository = skillRepository;
        }


        [Route("ShowSkill")]
        [Route("ss")]
        public ViewResult ShowSkill()
        {
            _showViewModel.PageTitle = "Compétences :";
            return View("~/Views/Skill/ShowSkill.cshtml", _showViewModel);
        }

        [HttpGet]
        [Route("AddSkill")]
        [Route("cs")]
        public ViewResult AddSkill()
        {
            _createViewModel.PageTitle = "Ajout de nouvelles compétences :";
            return View("~/Views/Skill/AddSkill.cshtml", _createViewModel);
        }

        [HttpPost]
        [Route("AddSkill")]
        [Route("cs")]
        public ViewResult AddSkill(string? skillTitle, string? significiantPoints, string? feedback)
        {
            _showViewModel.PageTitle = "Nouvelle compétence ajoutée :";
            List<string> listSignificiantPoints = new List<string>();
            if (significiantPoints != null)
            {
                foreach (var s in significiantPoints.Split("\r\n"))
                {
                    listSignificiantPoints.Add(s);
                }
            }
            Skill skill = new Skill(skillTitle, listSignificiantPoints, feedback);
            _skillRepository.Add(skill);
            _showViewModel.Skills = _skillRepository.GetSkills();
            return View("~/Views/Skill/ShowSkill.cshtml", _showViewModel);


        }

        [Route("PurposeSkill")]
        [Route("ps")]
        public ViewResult PurposeSkill()
        {
            _purposeModel.PageTitle = "Objectifs d'acquisition de compétences :";
            return View("~/Views/Skill/PurposeSkill.cshtml", _purposeModel);
        }


    }
}
