using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Order
    {
        [ScaffoldColumn(false)] public int OrderId { get; set; }

        [ScaffoldColumn(false)] public string Username { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required] public string Address { get; set; }

        [Required] public string City { get; set; }

        [Required] public string State { get; set; }

        [Required]
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }

        [Required] public string Country { get; set; }

        [Required] [Phone] public string Phone { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)] public decimal Total { get; set; }

        [ScaffoldColumn(false)] public DateTime OrderDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}