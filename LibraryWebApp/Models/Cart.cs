using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Cart
    {
        [Key]
        [Required]
        public int RecordId { get; set; }

        [Required]
        public string CartId { get; set; }

        [Required]
        public int BookID { get; set; }

        public int Count { get; set; }

        public System.DateTime DateCreated { get; set; }

        public virtual Book Book { get; set; }

        public Cart()
        {
            Book = new Book();
        }
    }
}