using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LibraryWebApp.Models;
using Microsoft.AspNet.Identity.Owin;

namespace LibraryWebApp.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Checkout
        [HttpGet]
        public ActionResult AddressAndPayment()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (user == null)
                return HttpNotFound();

            var model = new Order()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                City = user.City,
                Country = user.Country,
                Phone = user.PhoneNumber,
                Email = user.Email,
                State = user.Country
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddressAndPayment(Order order)
        {
            if (!ModelState.IsValid)
                return View(order);

            order.Username = User.Identity.Name;
            order.OrderDate = DateTime.Now;
            db.Orders.Add(order);
            await db.SaveChangesAsync();

            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var user = userManager.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

            if (user == null)
                return HttpNotFound();

            user.FirstName = order.FirstName;
            user.LastName = order.LastName;

            var cart = ShoppingCart.GetCard(this.HttpContext);
            var itemsCount = cart.GetCartItems().Sum(x => x.Count);

            if (user.Points != 0)
            {   
                user.Points += (itemsCount * 10);
                await userManager.UpdateAsync(user);
            }

            await cart.CreateOrder(order);

            return RedirectToAction("Complete", "Checkout", new {id = order.OrderId});
        }

        [HttpGet]
        public ActionResult Complete(int? id)
        {
            if (!id.HasValue)
                return HttpNotFound();

            if (db.Orders.Any(o => o.OrderId == id.Value && o.Username == User.Identity.Name))
                return View(id.Value);
            return HttpNotFound();
        }
    }
}