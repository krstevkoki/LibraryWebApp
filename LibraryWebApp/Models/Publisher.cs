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
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Publisher Name")]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Publisher()
        {
            Books = new List<Book>();
        }
    }
}