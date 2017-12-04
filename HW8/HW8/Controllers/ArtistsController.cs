using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HW8.Models;

namespace HW8.Controllers
{
    public class ArtistsController : Controller
    {
        public ArtistContext db = new ArtistContext();

        // GET: Artists
        public ActionResult Index()
        {
            return View(db.Artists.ToList());
        }

        // GET: Welcome
        public ActionResult Welcome()
        {
            var genres = db.Genres;
            return View(genres);
        }

        public JsonResult Genre(int key)
        {
            var artwork = db.Genres.Find(key).Classifications.ToList().OrderBy(til => til.ArtWork.Title).Select(a => new { aw = a.ArtWKey, awa = a.ArtWork.ArtistKey }).ToList();
            string[] artworkCreator = new string[artwork.Count()];
            for (int i = 0; i < artworkCreator.Length; ++i)
            {
                artworkCreator[i] = $"<ul>{db.ArtWorks.Find(artwork[i].aw).Title} by {db.Artists.Find(artwork[i].awa).ArtistName}</ul>";
            }
            var data = new { arr = artworkCreator };

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        // GET: ArtWork
        public ActionResult ArtWork()
        {
            return View(db.ArtWorks.ToList());
        }

        // GET: Classifications
        public ActionResult Classifications()
        {
            return View(db.Classifications.ToList());
        }

        // GET: Artists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // GET: Artists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ArtistKey,ArtistName,BirthDate,BirthCity")] Artist artist)
        {
            //Vareables to check the date and compare for non-sencical dates.
            int toDateY = DateTime.Now.Year;
            int toDateM = DateTime.Now.Month;
            int toDateD = DateTime.Now.Day;
            // artBY => Artist birth year ect. ect.
            int artBY, artBM, artBD;

            string[] artDates = artist.BirthDate.Split('-');
            // they will only parse if valide enteries
            if (int.TryParse(artDates[0], out artBY)) { }
            else
            {
                artBY = 9999;
            }
            if (int.TryParse(artDates[1], out artBM)) { }
            else
            {
                artBM = 99;
            }
            if (int.TryParse(artDates[2], out artBD)) { }
            else
            {
                artBD = 99;
            }


            if (artBY > toDateY)
            {
                TempData["testmsg"] = "<script>alert('This is an invalide date.');</script>";
                return View();

            }
            else if ((artBY == toDateY) && (artBM > toDateM))
            {
                TempData["testmsg"] = "<script>alert('This is an invalide date.');</script>";
                return View();

            }
            else if ((artBY == toDateY) && (artBM == toDateM) && (artBD > toDateD))
            {
                TempData["testtmsg"] = "<script>alert('This is an invalide date.');</script>";
                return View();
            }
            else if (ModelState.IsValid)
            {
                db.Artists.Add(artist);
                db.SaveChanges();
                return RedirectToAction("Index");
            }



            return View(artist);
        }

        // GET: Artists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArtistKey,ArtistName,BirthDate,BirthCity")] Artist artist)
        {
            if (ModelState.IsValid)
            {
                db.Entry(artist).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(artist);
        }

        // GET: Artists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        // POST: Artists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Artist artist = db.Artists.Find(id);
            db.Artists.Remove(artist);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
