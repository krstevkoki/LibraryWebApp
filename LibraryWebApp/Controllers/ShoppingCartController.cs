using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LibraryWebApp.Models;
using Microsoft.AspNet.Identity.Owin;

namespace LibraryWebApp.Controllers
{
    [Authorize]
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCard(this.HttpContext);

            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (user == null)
                return HttpNotFound();

            var model = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal(),
                Points = user.Points
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult AddToCart(int id)
        {
            var book = db.Books.Find(id);

            if (book == null)
                return HttpNotFound();

            var cart = ShoppingCart.GetCard(this.HttpContext);

            cart.AddToCard(book);

            var result = new ShoppingCartAddViewModel()
            {
                Message = $"Book {Server.HtmlEncode(book.Title)} was added to your cart!",
                AddId = id,
                CartCount = cart.GetCount(),
                CartTotal = cart.GetTotal(),
            };

            return Json(result);
        }

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCart.GetCard(this.HttpContext);
            var book = db.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return Json(HttpNotFound());

            var bookName = book.Title;
            var itemCount = cart.RemoveFromCard(id);

            var results = new ShoppingCartRemoveViewModel
            {
                Message = $"{Server.HtmlEncode(bookName)} has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };

            return Json(results);
        }
    }
}