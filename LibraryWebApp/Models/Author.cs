using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Author
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Author Name")]
        [Required]
        public string Name { get; set; }

        public string ImageURL { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}