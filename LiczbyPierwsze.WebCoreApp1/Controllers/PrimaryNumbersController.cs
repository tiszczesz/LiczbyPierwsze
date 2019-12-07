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
                PrimaryNumbers pn = new PrimaryNumbers();
                if (pm.ULimit < pm.DLimit) {
                    int temp = pm.DLimit;
                    pm.DLimit = pm.ULimit;
                    pm.ULimit = temp;
                }

                const int rowWidth = 20;
                int rows = (pm.ULimit - pm.DLimit) / rowWidth + 1;
                ViewBag.rows = rows;
                ViewBag.rowWidth = rowWidth;
                pm.Numbers = pn.ShowPrimaryNumbers(pm.DLimit, pm.ULimit);
                return View(pm);
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