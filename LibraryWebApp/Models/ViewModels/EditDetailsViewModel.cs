using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class EditDetailsViewModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Age")]
        [Range(14, 99)]
        public int Age { get; set; }

        [Required] [Display(Name = "Gender")] public bool Gender { get; set; }

        [Display(Name = "City")] public string City { get; set; }

        [Display(Name = "Country")] public string Country { get; set; }

        [Display(Name = "Address")] public string Address { get; set; }
    }
}