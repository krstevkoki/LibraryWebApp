using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class ShippingAndPaymentViewModel
    {
        public Order Order { get; set; }
        public CreditCard CreditCard { get; set; }
    }
}