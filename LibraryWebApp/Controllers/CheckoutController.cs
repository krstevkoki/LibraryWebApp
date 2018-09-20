using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LibraryWebApp.Models;
using LibraryWebApp.Models.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;

namespace LibraryWebApp.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Checkout
        [HttpGet]
        public ActionResult ShippingAndPayment()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (user == null)
                return HttpNotFound();

            if (!db.Carts.Any(c => c.CartId == user.UserName))
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);

            var model = new ShippingAndPaymentViewModel()
            {
                Order = new Order()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = user.Address,
                    City = user.City,
                    Country = user.Country,
                    Phone = user.PhoneNumber,
                    Email = user.Email,
                    State = user.Country
                },
                CreditCard = new CreditCard()
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult ShippingAndPayment(ShippingAndPaymentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Order.Username = User.Identity.Name;
            model.Order.OrderDate = DateTime.Now;

            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (user == null)
                return HttpNotFound();

            user.FirstName = model.Order.FirstName;
            user.LastName = model.Order.LastName;

            var creditCard = db.CreditCards.Find(model.CreditCard.CardNumber);

            if (creditCard == null ||
                creditCard.CardHolder != model.CreditCard.CardHolder ||
                creditCard.CVV2 != model.CreditCard.CVV2 ||
                creditCard.ExpiryDate != model.CreditCard.ExpiryDate) // credit card doesn't exist
            {
                ModelState.AddModelError("", "Credit card does not exist!");
                return View(model);
            }

            if (creditCard.ExpiryDate < DateTime.Now) // credit card has expired
            {
                ModelState.AddModelError("", "Credit card has expired!");
                return View(model);
            }

            var cart = ShoppingCart.GetCard(this.HttpContext);
            int result = cart.CreateOrder(model.Order, creditCard);

            if (result != -1) // available funds on the credit card
            {
                if (user.Points != 0)
                {
                    var itemsCount = cart.GetCartItems().Sum(x => x.Count);
                    user.Points += (itemsCount * 10);
                    userManager.Update(user);
                }

                return RedirectToAction("Complete", "Checkout", new {id = model.Order.OrderId});
            }

            ModelState.AddModelError("", "Insufficient funds on your balance!");
            return View(model);
        }

        [HttpGet]
        public ActionResult Complete(int? id)
        {
            if (!id.HasValue)
                return HttpNotFound();

            if (db.Orders.Any(o => o.OrderId == id.Value))
            {
                if (db.Orders.Any(o => o.OrderId == id.Value && o.Username == User.Identity.Name))
                    return View(id.Value);
                return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
            }

            return HttpNotFound();
        }
    }
}