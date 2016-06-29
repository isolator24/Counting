
using Counting.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Counting.Controllers
{
    public class HomeController : Controller
    {
        private ExamEntities db = new ExamEntities();
        
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Incrementers.Single());
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            Incrementer inc = db.Incrementers.Find(id);
            if (inc.Count < 10)
            {
                inc.Count++;
            }

            if (ModelState.IsValid)
            {
                db.Entry(inc).State = EntityState.Modified;
                db.SaveChanges();
            }
            return View(db.Incrementers.Single());
        }
    }
}