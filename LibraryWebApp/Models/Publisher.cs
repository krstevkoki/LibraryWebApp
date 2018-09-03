using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Publisher
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Publisher")]
        [Required]
        public string PublisherName { get; set; }

        [Display(Name = "Country")]
        [Required]
        public string PublisherCountry { get; set; }

        [Display(Name = "City")]
        [Required]
        public string PublisherCity { get; set; }

        [Required]
        public string Address { get; set; }

        [RegularExpression("07[01235678]\\d{6}", ErrorMessage = "Invalid phone number!")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}