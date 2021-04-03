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
        private readonly AddSkillViewModel _addViewModel;
        private readonly PurposeSkillViewModel _purposeModel;
        private ISkillRepository _skillRepository;


        public SkillController(ISkillRepository skillRepository)
        {
            _showViewModel = new ShowSkillViewModel();
            _addViewModel = new AddSkillViewModel();
            _purposeModel = new PurposeSkillViewModel();
            _skillRepository = skillRepository;
        }


        [Route("ShowSkill")]
        public ViewResult ShowSkill()
        {
            _showViewModel.PageTitle = "Compétences :";
            return View("~/Views/Skill/ShowSkill.cshtml", _showViewModel);
        }

        [HttpGet]
        [Route("AddSkill")]
        public ViewResult AddSkill()
        {
            _addViewModel.PageTitle = "Ajout de nouvelles compétences :";
            return View("~/Views/Skill/AddSkill.cshtml", _addViewModel);
        }

        [HttpPost]
        [Route("AddSkill")]
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
        public ViewResult PurposeSkill()
        {
            _purposeModel.PageTitle = "Objectifs d'acquisition de compétences :";
            return View("~/Views/Skill/PurposeSkill.cshtml", _purposeModel);
        }


    }
}
