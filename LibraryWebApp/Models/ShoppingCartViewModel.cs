using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }

        public ShoppingCartViewModel()
        {
            CartItems = new List<Cart>();
        }
    }
}