using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class BookDetailsViewModel
    {
        public Book Book { get; set; }

        public List<Book> BooksByGenre { get; set; }

        public List<Review> ReviewsForBook { get; set; }

    }
}