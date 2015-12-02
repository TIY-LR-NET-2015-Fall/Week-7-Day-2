using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week7day2.Models;

namespace week7day2.Controllers
{
    public class ClassmatesController : Controller
    {
        // GET: Classmate
        public ActionResult List()
        {
            List<ClassmateVM> mates = new List<ClassmateVM>();
            mates.Add(new ClassmateVM() { FirstName = "Cason", LastName = "Barnhill", Height = 75, HairColor = "brown" });
            mates.Add(new ClassmateVM() { FirstName = "Baxley", LastName = "Aldworth", Height = 70, HairColor = "blonde" });
            mates.Add(new ClassmateVM() { FirstName = "Justin", LastName = "Wyatt", Height = 68, HairColor = "black" });
            mates.Add(new ClassmateVM() { FirstName = "Josh", LastName = "Hill", Height = 73, HairColor = "brown" });


            return View(mates);
        }

        [HttpGet]
        public ActionResult PostWallMessage(string name, string message )
        {
            var model = new WallMessageVM();
            model.Name = name;
            model.Message = message;

            return View(model);
        }

        [HttpPost]
        public ActionResult PostWallMessage(WallMessageVM newMessage)
        {
            //Do complex db stuff to save this message

            newMessage.Message = "PostedMessageTest: " + newMessage.Message;
            return View("ThankYou", newMessage);
        }
    }
}

