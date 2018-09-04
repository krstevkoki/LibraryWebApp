using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class AddToAuthorModel
    {
        [Required]
        [Key]
        public int BookID { get; set; }

        [Required]
        [Key]
        public int AuthorID { get; set; }

        public ICollection<Book> Books { get; set; }

        public AddToAuthorModel()
        {
            Books = new List<Book>();
        }
    }
}