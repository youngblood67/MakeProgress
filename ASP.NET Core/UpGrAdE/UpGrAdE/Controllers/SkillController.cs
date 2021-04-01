using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class SkillController : Controller
    {
        private readonly ShowSkillViewModel _showViewModel;
        private readonly CreateSkillViewModel _createViewModel;
        private readonly PurposeSkillViewModel _purposeModel;


        public SkillController()
        {
            _showViewModel = new ShowSkillViewModel();
            _createViewModel = new CreateSkillViewModel();
            _purposeModel = new PurposeSkillViewModel();
        }


        [Route("ShowSkill")]
        [Route("ss")]
        public ViewResult ShowSkill()
        {
            _showViewModel.PageTitle = "Compétences :";
            return View("~/Views/Skill/ShowSkill.cshtml", _showViewModel);
        }

        [Route("CreateSkill")]
        [Route("cs")]
        public ViewResult CreateSkill()
        {
            _createViewModel.PageTitle = "Ajout de nouvelles compétences :";

            return View("~/Views/Skill/CreateSkill.cshtml", _createViewModel);
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
