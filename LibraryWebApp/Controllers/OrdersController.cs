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
    public class OrdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            
            Order order = db.Orders.Include(o => o.OrderDetails).FirstOrDefault(o => o.OrderId == id);
            if (order == null)
                return HttpNotFound();
            
            if (order.Username == User.Identity.Name || User.IsInRole("Admin"))
                return View(order);

            return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
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
