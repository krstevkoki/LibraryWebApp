using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class PublisherDetailsViewModel
    {
        public Publisher Publisher { get; set; }

        public List<Book> BooksByPublisher { get; set; }
    }
}