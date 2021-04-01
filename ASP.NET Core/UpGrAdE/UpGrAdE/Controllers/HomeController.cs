using Microsoft.AspNetCore.Mvc;
using UpGrAdE.ViewModels;

namespace UpGrAdE.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
      
        [Route("Home")]
        [Route("")]
        public ViewResult Home()
        {     
            return View("~/Views/Home.cshtml");
        }

      
    }
}
