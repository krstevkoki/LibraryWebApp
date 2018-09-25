using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LibraryWebApp.Models;

namespace LibraryWebApp.Controllers
{
    public class ReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Reviews/Edit/5
        [Authorize(Roles = "Admin, Staff")]
        public ActionResult Edit(int? id, string returnUrl)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Review review = db.Reviews.Find(id);
            if (review == null)
                return HttpNotFound();

            ViewBag.ReturnUrl = returnUrl;
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Staff")]
        public ActionResult Edit([Bind(Include = "Id,ReviewerUsername,ReviewMessage,ReviewDate")] Review review, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var modify = db.Reviews.Find(review.Id);
                if (modify != null)
                {
                    modify.ReviewDate = DateTime.Now;
                    modify.ReviewMessage = review.ReviewMessage;
                    db.Entry(modify).State = EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToLocal(returnUrl);
                }

                return HttpNotFound();
            }

            ViewBag.ReturnUrl = returnUrl;
            return View(review);
        }

        // GET: Reviews/Delete/5
        [Authorize(Roles = Roles.Admin)]
        public ActionResult Delete(int? id, string returnUrl)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            Review review = db.Reviews.Find(id);
            if (review == null)
                return HttpNotFound();

            db.Reviews.Remove(review);
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
