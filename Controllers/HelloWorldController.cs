using Microsoft.AspNetCore.Mvc;

namespace MvcProject.Controllers {

    public class HelloWorldController : Controller {
        public IActionResult Index () {
            ViewData["Message"] = "Hello Bebişim";
            return View ();
        }

        public IActionResult Welcome () {
            ViewData["Message"] = "Hello Bebişim Welcome";
            return View ();
        }
    }
}