using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using LibraryWebApp.Models;
using LibraryWebApp.Models.ViewModels;
using PagedList;
using LibraryWebApp.Models.Dto;

namespace LibraryWebApp.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();


        // GET: Books
        public ActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 16;

            // var model = db.Books.Include(m => m.Authors).ToList();

            var model = db.Books.Include(m => m.Authors).OrderByDescending(b=>b.Id).ToPagedList(pageNumber, pageSize);

            ViewBag.UserRole = User.IsInRole(Roles.Admin) ? "Admin" :
                User.IsInRole(Roles.Staff) ? "Staff" :
                User.IsInRole(Roles.Member) ? "Member" :
                User.IsInRole(Roles.User) ? "User" : "";
            return View(model);
        }


        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book book = db.Books.Include(b => b.Genre).FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return HttpNotFound();
            }

            var booksByGenre = db.Books.Include(b => b.Genre).Where(b => b.Genre.Name == book.Genre.Name).ToList();
            booksByGenre.Remove(book);

            var reviewsForBook = book.Reviews.OrderByDescending(item => item.ReviewDate).ToList();

            var model = new BookDetailsViewModel()
            {
                Book = book,
                BooksByGenre = booksByGenre,
                ReviewsForBook = reviewsForBook
            };

            return View(model);
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
                    Price = model.Book.Price,
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

            var book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            var model = new AddAuthorToBookModel()
            {
                Book = book,
                Authors = (db.Authors.ToList()),
                SelectedAuthor = -1,
                Publishers = (db.Publishers.ToList()),
                SelectedPublisher = -1,
                Genres = (db.Genres.ToList()),
                SelectedGenre = -1,
            };

            return View(model);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AddAuthorToBookModel model)
        {
            if (ModelState.IsValid)
            {
                var book = db.Books.Find(model.Book.Id);
                if (book == null)
                    return HttpNotFound();

                book.Title = model.Book.Title;
                book.Pages = model.Book.Pages;
                book.Quantity = model.Book.Quantity;
                book.CoverURL = model.Book.CoverURL;
                book.PublishPlace = model.Book.PublishPlace;
                book.PublishDate = model.Book.PublishDate;
                book.Price = model.Book.Price;
                book.Genre = db.Genres.Find(model.SelectedGenre);
                book.Authors.Add(db.Authors.Find(model.SelectedAuthor));
                book.Publishers.Add(db.Publishers.Find(model.SelectedPublisher));

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            model = new AddAuthorToBookModel()
            {
                Book = model.Book,
                Authors = (db.Authors.ToList()),
                SelectedAuthor = -1,
                Publishers = (db.Publishers.ToList()),
                SelectedPublisher = -1,
                Genres = (db.Genres.ToList()),
                SelectedGenre = -1,
            };
            return View(model);
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

        [HttpPost]
        public ActionResult Search(string query)
        {
            if (query == null || query.IsEmpty())
            {
                return Json(new HttpStatusCodeResult(HttpStatusCode.BadRequest, "The search query is empty!"));
            }

            var result = db.Books.Where(b => b.Title.Contains(query)).Select(b => new BooksDto()
            {
                Id = b.Id,
                Title = b.Title,
                CoverUrl = b.CoverURL
            }).ToList();

            if (result.Count == 0)
                return Json(new HttpNotFoundResult($"We didn't find any match for query '{query}'!"));

            return Json(result);
        }

        [HttpPost]
        public ActionResult LeaveReview(Review review)
        {
            review.ReviewDate = DateTime.Now;
            var book = db.Books.Find(review.BookID);

            if (book == null)
                return Json(new Dictionary<string, string>
                {
                    { "Message", "The book was not found. Review was not added!" },
                    { "Code", "404" }
                });

            book.Reviews.Add(review);
            db.Entry(book).State = EntityState.Modified;
            db.SaveChanges();

            return Json(new Dictionary<string, string>
            {
                { "Message", "The review was successfuly added" },
                { "Code", "200" }
            });
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