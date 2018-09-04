using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class AddToBookModel
    {
        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int BookId { get; set; }

        public ICollection<Author> Authors { get; set; }

        public AddToBookModel()
        {
            Authors = new List<Author>()
        }
    }
}