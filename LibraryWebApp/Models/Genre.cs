using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Genre
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}