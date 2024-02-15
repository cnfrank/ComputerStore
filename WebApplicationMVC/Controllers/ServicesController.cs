using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Desktop Computers For Sale!";
            return View();
        }

        public IActionResult Desktops()
        {
            Desktop[] list = {new Desktop("Surface Pro",2500,16,15,3),
                new Desktop("IPad",1600,8,15,3),
                new Desktop("Dell Inspiron",800,16,17,6)};
            return View(list);
        }

        public IActionResult Laptops()
        {
            Laptop gaming = new("gaming rig", 1500, 16);
            Laptop office = new("office rig", 700, 8);
            Laptop business = new("business rig", 1300, 32);
            return View(new Laptop[] { gaming , office , business });
        }
    }
}
