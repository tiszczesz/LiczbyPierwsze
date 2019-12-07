using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiczbyPierwsze.WebCoreApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiczbyPierwsze.WebCoreApp1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            MathModel mm = new MathModel();

            mm.Cities = new List<string>(){"Warszawa","Praga","Moskwa","Madryt"};
            return View(mm);
        }

        //POST
        [HttpPost]
        public IActionResult Index(MathModel mm) {
          //  if (ModelState.IsValid) {

                mm.Result = mm.A + mm.B;
                return View(mm);
        //    }
        //    else {
        //        return View(mm);
        //    }
        }
    }
}