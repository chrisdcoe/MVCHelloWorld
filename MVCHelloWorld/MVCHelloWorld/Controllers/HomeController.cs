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
            Person person = new Person { FirstName = "", LastName = " " };


            return View(person);
        }

        public ActionResult SayHello(Person person)
        {
            //person.FirstName = person.FirstName.ToUpper();
            //person.LastName = person.LastName.ToUpper();

            PersonRepository.AddPerson(person);

            return RedirectToAction("ShowMeAList", "Home");
        }

        public ActionResult ShowMeAList()
        {
            return View("ShowMeAList", PersonRepository.GetAllPersons());
        }

        public static class PersonRepository
        {
            static List<Person> list = new List<Person>()
            {
                new Person() { FirstName = "Owen", LastName = "Landen" },
                new Person() { FirstName = "Troy", LastName = "Stouthammer" },
                new Person() { FirstName = "Huxley", LastName = "Webb" }
            };

            public static List<Person> GetAllPersons()
            {
                return list;
            }

            public static void AddPerson(Person p)
            {
                list.Add(p);
            }
        }
    }
}