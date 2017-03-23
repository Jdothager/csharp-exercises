using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantMenu.Controllers
{
    public class RestaurantController : Controller
    {
        private static Models.Menu theMenu = new Models.Menu();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.theMenu = theMenu;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }


    }
}
