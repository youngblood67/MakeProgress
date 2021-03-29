using UpGrAdE.Models.Interfaces;
using UpGrAdE.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace UpGrAdE.Controllers
{
    [Route("")]
    [Route("Learning")]
    public class LearningController : Controller
    {
        private ShowSkillViewModel viewModel;
        public LearningController()
        {
            viewModel = new ShowSkillViewModel();
        }

        /////////COMPETENCES\\\\\\\\\\\\\

        [Route("")]
        [Route("ShowSkill")]
        [Route("ss")]
        public ViewResult ShowSkill()
        {
            viewModel.Title = "Compétences :";
            return View("~/Views/Learning/Skill/ShowSkill.cshtml", viewModel);
        }

        [Route("CreateSkill")]
        [Route("cs")]
        public ViewResult CreateSkill()
        {
            viewModel.Title = "Ajout de nouvelles compétences :";
            return View("~/Views/Learning/Skill/CreateSkill.cshtml", viewModel);
        }

        [Route("PurposeSkill")]
        [Route("ps")]
        public ViewResult PurposeSkill()
        {
            viewModel.Title = "Objectifs d'acquisition de compétences :";
            return View("~/Views/Learning/Skill/PurposeSkill", viewModel);
        }

        /////////CONNAISSANCES\\\\\\\\\\\\\

        [Route("ShowKnowledge")]
        [Route("sk")]
        public ViewResult ShowKnowledge()
        {
            viewModel.Title = "Connaissances, culture générale :";
            return View("~/Views/Learning/Knowledge/ShowKnowledge.cshtml", viewModel);
        }

        [Route("CreateKnowledge")]
        [Route("ck")]
        public ViewResult CreateKnowledge()
        {
            viewModel.Title = "Ajout de nouvelles connaissances";
            return View("~/Views/Learning/Knowledge/CreateKnowledge.cshtml", viewModel);
        }

        [Route("PurposeKnowledge")]
        [Route("pk")]
        public ViewResult PurposeKnowledge()
        {
            viewModel.Title = "Objectifs d'acquisition des connaissances :";
            return View("~/Views/Learning/Knowledge/PurposeKnowledge.cshtml", viewModel);
        }

        /////////APTITUDES COGNITIVES\\\\\\\\\\\\\

        [Route("ShowCognitive")]
        [Route("sc")]
        public ViewResult ShowCognitive()
        {
            viewModel.Title = "Aptitudes cognitives :";
            return View("~/Views/Learning/Cognitive/ShowCognitive.cshtml", viewModel);
        }

        [Route("CreateCognitive")]
        [Route("cc")]
        public ViewResult CreateCognitive()
        {
            viewModel.Title = "Entrainement aux aptitudes cognitives :";
            return View("~/Views/Learning/Cognitive/CreateCognitive.cshtml", viewModel);
        }

        [Route("PurposeCognitive")]
        [Route("pc")]
        public ViewResult PurposeCognitive()
        {
            viewModel.Title = "Objectifs cognitifs :";
            return View("~/Views/Learning/Cognitive/PurposeCognitive.cshtml", viewModel);
        }


        /////////APTITUDES PHYSIQUES\\\\\\\\\\\\\

        [Route("ShowPhysical")]
        [Route("sp")]
        public ViewResult ShowPhysical()
        {
            viewModel.Title = "Aptitudes Physiques :";
            return View("~/Views/Learning/Physical/ShowPhysical.cshtml", viewModel);
        }
        [Route("CreatePhysical")]
        [Route("cp")]
        public ViewResult CreatePhysical()
        {
            viewModel.Title = "Entrainement aux aptitudes Physiques :";
            return View("~/Views/Learning/Physical/CreatePhysical.cshtml", viewModel);
        }

        [Route("PurposePhysical")]
        [Route("pp")]
        public ViewResult PurposePhysical()
        {
            viewModel.Title = "Objectifs physiques :";
            return View("~/Views/Learning/Physical/PurposePhysical.cshtml", viewModel);
        }
    }
}
