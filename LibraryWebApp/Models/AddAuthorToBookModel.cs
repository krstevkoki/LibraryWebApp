using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class AddAuthorToBookModel
    {
        public Book Book { get; set; }
        public ICollection<Author> Authors { get; set; }
        public int SelectedAuthor { get; set; }

        public AddAuthorToBookModel()
        {
            Book = new Book();
            Authors = new List<Author>();
        }
    }
}