using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week7Day2.HW.Models;

namespace Week7Day2.HW.Controllers
{
    public class ClassmatesController : Controller
    {
        // GET: Classmates
        public ActionResult List()
        {
            var model = new List<ClassmateVM>
            {
                new ClassmateVM() {HairColor = "brown", Height = 80, Name = "Daniel Pollock"},
                new ClassmateVM() {HairColor = "red", Height = 72, Name = "Baxley"},
                new ClassmateVM() {HairColor = "green", Height = 64, Name = "Justin"},
                new ClassmateVM() {HairColor = "blue", Height = 72, Name = "Cason"}
            };

            return View(model);
        }
    }
}