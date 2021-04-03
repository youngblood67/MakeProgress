using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    public class PhysicalController : Controller
    {
        private readonly ShowPhysicalViewModel _showViewModel;
        private readonly AddPhysicalViewModel _addViewModel;
        private readonly PurposePhysicalViewModel _purposeModel;


        public PhysicalController()
        {
            _showViewModel = new ShowPhysicalViewModel();
            _addViewModel = new AddPhysicalViewModel();
            _purposeModel = new PurposePhysicalViewModel();
        }


        [Route("ShowPhysical")]
        public ViewResult ShowPhysical()
        {
            _showViewModel.PageTitle = "Aptitudes Physiques :";
            return View("~/Views/Physical/ShowPhysical.cshtml", _showViewModel);
        }
        [Route("AddPhysical")]
        public ViewResult AddPhysical()
        {
            _addViewModel.PageTitle = "Entrainement aux aptitudes Physiques :";
            return View("~/Views/Physical/AddPhysical.cshtml", _addViewModel);
        }

        [Route("PurposePhysical")]
        public ViewResult PurposePhysical()
        {
            _purposeModel.PageTitle = "Objectifs physiques :";
            return View("~/Views/Physical/PurposePhysical.cshtml", _purposeModel);
        }
    }
}
