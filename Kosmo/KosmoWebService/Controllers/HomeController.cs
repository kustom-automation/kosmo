using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KosmoWebService.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Help()
        {
            return View();
        }

        public IActionResult KosmoGitHub()
        {
            return new RedirectResult("https://github.com/kustom-automation/kosmo/wiki");
        }

        public IActionResult Swagger()
        {
            return new RedirectResult("~/swagger");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
