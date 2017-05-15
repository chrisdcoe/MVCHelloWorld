using MVCHelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Person person = new Person { FirstName = "", LastName = "" };


            return View(person);
        }

        public ActionResult SayHello(Person person)
        {
            person.FirstName = person.FirstName.ToUpper();
            person.LastName = person.LastName.ToUpper();

            return View(person);
        }
    }
}