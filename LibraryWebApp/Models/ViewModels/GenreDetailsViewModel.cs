using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class GenreDetailsViewModel
    {
        public Genre Genre { get; set; }
        public List<Book> Books { get; set; }
    }
}