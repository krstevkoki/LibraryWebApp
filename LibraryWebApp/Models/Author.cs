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
        public string AuthorName { get; set; }

        public string ImageURL { get; set; }

        public virtual ICollection<Book> books { get; set; }

        public Author()
        {
            books = new List<Book>();
        }
    }
}