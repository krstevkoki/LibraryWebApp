﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class BookDetailsViewModel
    {
        public Book Book { get; set; }

        public List<Book> Books { get; set; }

    }
}