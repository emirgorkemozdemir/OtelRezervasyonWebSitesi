using OtelRezervasyonWebSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtelRezervasyonWebSitesi.Controllers
{
    public class OdemeController : Controller
    {
        // GET: Odeme
        OtelRezervasyonDBEntities db = new OtelRezervasyonDBEntities();

        [HttpGet]
        public ActionResult ListPays()
        {
            List<Odemeler> pays = db.Odemelers.ToList();
            return View(pays);
        }

        [HttpGet]

        public ActionResult OdemeDelete(int id)
        {
            Odemeler secili_odeme = db.Odemelers.Find(id);
            db.Odemelers.Remove(secili_odeme);
            db.SaveChanges();
            return RedirectToAction("ListPays");
        }
    }
}