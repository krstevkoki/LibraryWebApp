using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWebApp.Models
{
    public class Review
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookID { get; set; }

        [Required]
        [Display(Name = "Reviewer Username")]
        public string ReviewerUsername { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string ReviewMessage { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        [Display(Name = "Date")]
        public DateTime ReviewDate { get; set; }

        
    }
}