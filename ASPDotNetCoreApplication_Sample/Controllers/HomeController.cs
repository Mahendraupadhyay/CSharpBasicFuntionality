using ASPDotNetCoreApplication_Sample.Models;
using ASPDotNetCoreApplication_Sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetCoreApplication_Sample.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurentData _restaurent;

        public HomeController(IRestaurentData restaurentData)
        {
            _restaurent = restaurentData;
        }
        public IActionResult Index()
        {
            var model = _restaurent.GetAll();
            //return new ObjectResult(model);
            return View(model);
        }
    }
}
