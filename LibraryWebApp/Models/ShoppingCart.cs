using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LibraryWebApp.Models
{
    public class ShoppingCart
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private string ShoppingCartId { get; set; }

        public static ShoppingCart GetCard(HttpContextBase context)
        {
            return new ShoppingCart()
            {
                ShoppingCartId = context.User.Identity.Name
            };
        }

        public static ShoppingCart GetCard(Controller controller)
        {
            return GetCard(controller.HttpContext);
        }

        public void AddToCard(Book book)
        {
            var cartItem = db.Carts.FirstOrDefault(c => c.CartId == ShoppingCartId && c.BookID == book.Id);

            if (cartItem == null) // item doesn't exists, let's create it
            {
                cartItem = new Cart
                {
                    CartId = ShoppingCartId,
                    BookID = book.Id,
                    Count = 1,
                    DateCreated = DateTime.Now
                };

                db.Carts.Add(cartItem);
            }
            else
            {
                cartItem.Count++;
            }
            
            db.SaveChanges();
        }

        public int RemoveFromCard(int id)
        {
            int itemCount = 0;

            var cartItem = db.Carts.FirstOrDefault(c => c.CartId == ShoppingCartId && c.BookID == id);

            if (cartItem != null) // item does exist ? remove the item : do nothing
            {
                if (cartItem.Count > 1)
                    itemCount = --cartItem.Count;
                else
                    db.Carts.Remove(cartItem);

                db.SaveChanges();
            }

            return itemCount;
        }

        public void EmptyCart()
        {
            var cartItems = db.Carts.Where(c => c.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
                db.Carts.Remove(cartItem);

            db.SaveChanges();
        }

        public List<Cart> GetCartItems()
        {
            return db.Carts.Where(c => c.CartId == ShoppingCartId).Include(c => c.Book).ToList();
        }

        public int GetCount()
        {
            int? count = GetCartItems().Count;

            return count ?? 0;
        }

        public decimal GetTotal()
        {
            decimal? total = GetCartItems().Sum(x => x.Count * x.Book.Price);

            return total ?? decimal.Zero;
        }

        public int CreateOrder(Order order, CreditCard creditCard)
        {
            order.Total = GetTotal();

            if (creditCard.Balance < order.Total)
                return -1;

            var cartItems = GetCartItems();

            foreach (var cartItem in cartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    BookId = cartItem.BookID,
                    UnitPrice = cartItem.Book.Price,
                    Quantity = cartItem.Count
                };
                db.OrderDetails.Add(orderDetail);
            }
            
            creditCard.Balance -= order.Total;

            db.Orders.Add(order);
            db.Entry(creditCard).State = EntityState.Modified;
            db.SaveChanges();

            /*foreach (var item in order.OrderDetails)
            {
                var book = db.Books.Find(item.BookId);
                book.Quantity -= item.Quantity;
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
            }*/

            EmptyCart();

            return order.OrderId;
        }
    }
}