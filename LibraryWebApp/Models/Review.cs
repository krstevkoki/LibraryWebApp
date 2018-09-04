using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Review
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string ReviewerUsername { get; set; }

        [Required]
        public string ReviewMessage { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }
    }
}