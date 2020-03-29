using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mi.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(object employee)
        {
            if (!ModelState.IsValid)
            {
                //do whatever you want here
            }

            return RedirectToAction("Index","Home");
        }

        //[HttpPost]
        //public 
    }
}