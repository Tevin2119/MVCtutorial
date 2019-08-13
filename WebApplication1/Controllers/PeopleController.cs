using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName1 = "Tevin", LastName1 = "Muparadzi", Age1 = 24, IsAlive1 = true });
            people.Add(new PersonModel { FirstName1 = "Kevin", LastName1 = "Steven", Age1 = 34, IsAlive1 = true });
            people.Add(new PersonModel { FirstName1 = "Marc", LastName1 = "Anthony", Age1 = 45, IsAlive1 = false });
            people.Add(new PersonModel { FirstName1 = "Kim", LastName1 = "Sithole", Age1 = 21, IsAlive1 = true });

            return View(people);
        }
    }
}