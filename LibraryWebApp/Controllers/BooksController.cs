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
    public class BooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Books
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            var model = new AddAuthorToBookModel()
            {
                Book = new Book(),
                Authors = (db.Authors.ToList()),
                SelectedAuthor = -1,
                Publishers = (db.Publishers.ToList()),
                SelectedPublisher = -1,
                Genres = (db.Genres.ToList()),
                SelectedGenre = -1
            };
            return View(model);
        }

        // POST: Books/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AddAuthorToBookModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book()
                {
                    Title = model.Book.Title,
                    Pages = model.Book.Pages,
                    Quantity = model.Book.Quantity,
                    CoverURL = model.Book.CoverURL,
                    PublishPlace = model.Book.PublishPlace,
                    PublishDate = model.Book.PublishDate,
                    Genre = db.Genres.Find(model.SelectedGenre),
                };
                book.Authors.Add(db.Authors.Find(model.SelectedAuthor));
                book.Publishers.Add(db.Publishers.Find(model.SelectedPublisher));
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            model = new AddAuthorToBookModel()
            {
                Book = new Book(),
                Authors = (db.Authors.ToList()),
                SelectedAuthor = -1,
                Publishers = (db.Publishers.ToList()),
                SelectedPublisher = -1,
                Genres = (db.Genres.ToList()),
                SelectedGenre = -1
            };
            return View(model);
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,Pages,Quantity,CoverURL,PublishPlace,PublishDate")]
            Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(book);
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
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