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

        public async Task AddToCard(Book book)
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

            await db.SaveChangesAsync();
        }

        public async Task<int> RemoveFromCard(int id)
        {
            int itemCount = 0;

            var cartItem = db.Carts.FirstOrDefault(c => c.CartId == ShoppingCartId && c.BookID == id);

            if (cartItem != null) // item does exist ? remove the item : do nothing
            {
                if (cartItem.Count > 1)
                    itemCount = --cartItem.Count;
                else
                    db.Carts.Remove(cartItem);

                await db.SaveChangesAsync();
            }

            return itemCount;
        }

        public async Task EmptyCart()
        {
            var cartItems = db.Carts.Where(c => c.CartId == ShoppingCartId);

            foreach (var cartItem in cartItems)
                db.Carts.Remove(cartItem);

            await db.SaveChangesAsync();
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

        public async Task<int> CreateOrder(Order order)
        {
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

            order.Total = GetTotal();
            db.Entry(order).State = EntityState.Modified;
            await db.SaveChangesAsync();

            await EmptyCart();

            return order.OrderId;
        }
    }
}