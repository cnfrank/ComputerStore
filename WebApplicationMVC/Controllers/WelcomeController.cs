using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
