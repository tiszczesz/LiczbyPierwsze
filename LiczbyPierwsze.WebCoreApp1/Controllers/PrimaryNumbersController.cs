using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiczbyPierwsze.Main;
using LiczbyPierwsze.WebCoreApp1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiczbyPierwsze.WebCoreApp1.Controllers {
    public class PrimaryNumbersController : Controller {
        public IActionResult Index() {
            PrimaryModel pm = new PrimaryModel();
            return View();
        }

        //POST
        [HttpPost]
        public IActionResult Index(PrimaryModel pm) {
            if (ModelState.IsValid) {

                return View();
            }
            else {
                return View(pm);
            }
        }

        public IActionResult GetAll() {
            PrimaryModel pm = new PrimaryModel() {DLimit = 2, ULimit = 200};
            PrimaryNumbers pn = new PrimaryNumbers();
            pm.Numbers = pn.ShowPrimaryNumbers(pm.DLimit, pm.ULimit);
            return View(pm);
        }
    }
}