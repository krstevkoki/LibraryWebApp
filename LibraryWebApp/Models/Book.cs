﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LibraryWebApp.Models
{
    public class Book
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(0,int.MaxValue)]
        public int Pages { get; set; }

        [Required]
        public Genre Genre { get; set; }

        public string CoverURL { get; set; }

        [Required]
        public string PublishPlace { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }

        public virtual ICollection<Author> authors { get; set; }

        public virtual ICollection<Publisher> publishers { get; set; }

        public Book()
        {
            authors = new List<Author>();
            publishers = new List<Publisher>();
        }
    }
}