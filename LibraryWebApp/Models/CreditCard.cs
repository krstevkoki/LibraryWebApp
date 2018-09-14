using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class CreditCard
    {
        [Required]
        [Display(Name = "Card holder")]
        public string CardHolder { get; set; }

        [Key]
        [Required]
        [Display(Name = "Card number")]
        [RegularExpression(
            @"^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$",
            ErrorMessage = "Not a valid format for card number!")]
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "Expiry date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "Not a valid format for CVV2 code!")]
        [Display(Name = "CVV2 Code")]

        public string CVV2 { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Account balance")]
        public int Balance { get; set; }
    }
}