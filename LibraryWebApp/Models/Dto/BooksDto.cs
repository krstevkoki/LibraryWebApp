using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class BooksDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverUrl { get; set; }
    }
}