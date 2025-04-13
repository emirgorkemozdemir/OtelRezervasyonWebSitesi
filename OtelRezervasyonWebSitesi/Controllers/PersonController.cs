using OtelRezervasyonWebSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelRezervasyonWebSitesi.Controllers
{
    public class PersonController : Controller
    {
        OtelRezervasyonDBEntities db = new OtelRezervasyonDBEntities();

        [HttpGet]
        public ActionResult ListPerson()
        {
            List<Person> persons = db.People.ToList();
            return View(persons);
        }

        [HttpGet]
        public ActionResult PersonDelete(int id)
        {
            Person secili_kisi = db.People.Find(id);
            db.People.Remove(secili_kisi);
            db.SaveChanges();
            return RedirectToAction("ListPerson");
        }
    }
}