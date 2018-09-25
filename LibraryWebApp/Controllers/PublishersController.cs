using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryWebApp.Models;
using LibraryWebApp.Models.ViewModels;


namespace LibraryWebApp.Controllers
{
    public class PublishersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Publishers/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id, string returnUrl)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var publisher = db.Publishers.Include(a => a.Books).FirstOrDefault(a => a.Id == id);

            if (publisher == null)
            {
                return HttpNotFound();
            }

            var booksByPublisher = publisher.Books.ToList();


            var model = new PublisherDetailsViewModel()
            {
                Publisher = publisher,
                BooksByPublisher = booksByPublisher
            };

            ViewBag.ReturnUrl = returnUrl;
            return View(model);
        }

        // GET: Publishers/Create
        [Authorize(Roles = "Admin, Staff")]
        public ActionResult Create(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: Publishers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Staff")]
        public ActionResult Create([Bind(Include = "Id,Name,Country,City,Address,PhoneNumber")] Publisher publisher, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                db.Publishers.Add(publisher);
                db.SaveChanges();
                return RedirectToLocal(returnUrl);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(publisher);
        }

        // GET: Publishers/Edit/5
        [Authorize(Roles = "Admin, Staff")]
        public ActionResult Edit(int? id, string returnUrl)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Publisher publisher = db.Publishers.Find(id);
            if (publisher == null)
                return HttpNotFound();


            ViewBag.ReturnUrl = returnUrl;
            return View(publisher);
        }

        // POST: Publishers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Staff")]
        public ActionResult Edit([Bind(Include = "Id,Name,Country,City,Address,PhoneNumber")] Publisher publisher, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(publisher).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToLocal(returnUrl);
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(publisher);
        }

        // GET: Publishers/Delete/5
        [Authorize(Roles = Roles.Admin)]
        public ActionResult Delete(int? id, string returnUrl)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Publisher publisher = db.Publishers.Find(id);
            if (publisher == null)
                return HttpNotFound();
            
            db.Publishers.Remove(publisher);
            db.SaveChanges();
            return RedirectToLocal(returnUrl);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Books");
        }
    }
}
