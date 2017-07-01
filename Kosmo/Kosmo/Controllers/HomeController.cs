// Copyright(C) 2017 Kustom Automation Pty Ltd & Contributors
//
// This software may be modified and distributed under the terms of the 
// MIT license - see the LICENSE file for details.
// This copyright notice must be maintained in accordance with the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Kosmo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application home page.";

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
