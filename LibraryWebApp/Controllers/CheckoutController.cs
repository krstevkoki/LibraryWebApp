using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LibraryWebApp.Models;

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
            var model = new Order();
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

            var cart = ShoppingCart.GetCard(this.HttpContext);
            await cart.CreateOrder(order);

            return RedirectToAction("Complete", "Checkout", new {id = order.OrderId});
        }

        [HttpGet]
        public ActionResult Complete(int? id)
        {
            if (!id.HasValue)
                return HttpNotFound();

            if (db.Orders.Any(o => o.OrderId == id.Value && o.Username == User.Identity.Name))
                return View(id);
            return HttpNotFound();
        }
    }
}