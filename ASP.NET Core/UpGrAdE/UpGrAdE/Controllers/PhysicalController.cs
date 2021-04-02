using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class PhysicalController : Controller
    {
        private readonly ShowPhysicalViewModel _showViewModel;
        private readonly AddPhysicalViewModel _createViewModel;
        private readonly PurposePhysicalViewModel _purposeModel;


        public PhysicalController()
        {
            _showViewModel = new ShowPhysicalViewModel();
            _createViewModel = new AddPhysicalViewModel();
            _purposeModel = new PurposePhysicalViewModel();
        }


        [Route("ShowPhysical")]
        [Route("sp")]
        public ViewResult ShowPhysical()
        {
            _showViewModel.PageTitle = "Aptitudes Physiques :";
            return View("~/Views/Physical/ShowPhysical.cshtml", _showViewModel);
        }
        [Route("AddPhysical")]
        [Route("cp")]
        public ViewResult AddPhysical()
        {
            _createViewModel.PageTitle = "Entrainement aux aptitudes Physiques :";
            return View("~/Views/Physical/AddPhysical.cshtml", _createViewModel);
        }

        [Route("PurposePhysical")]
        [Route("pp")]
        public ViewResult PurposePhysical()
        {
            _purposeModel.PageTitle = "Objectifs physiques :";
            return View("~/Views/Physical/PurposePhysical.cshtml", _purposeModel);
        }
    }
}
