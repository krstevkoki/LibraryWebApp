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
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "Expiry date")]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [RegularExpression(@"[0-9]{3}", ErrorMessage = "Not a valid format for CVV2 code!")]
        [Display(Name = "CVV2 Code")]

        public int CVV2 { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Account balance")]
        public int Balance { get; set; }
    }
}