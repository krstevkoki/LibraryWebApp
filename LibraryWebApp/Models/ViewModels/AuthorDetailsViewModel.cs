using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class AuthorDetailsViewModel
    {
        public Author Author { get; set; }

        public List<Book> BooksByAuthor{ get; set; }
    }
}