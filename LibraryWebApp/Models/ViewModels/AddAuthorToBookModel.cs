using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models.ViewModels
{
    public class AddAuthorToBookModel
    {
        public Book Book { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Publisher> Publishers { get; set; }
        public ICollection<Genre> Genres { get; set; }
        [Display(Name = "Author")]
        public int SelectedAuthor { get; set; }
        [Display(Name = "Publisher")]
        public int SelectedPublisher { get; set; }
        [Display(Name = "Genre")]
        public int SelectedGenre { get; set; }

        public AddAuthorToBookModel()
        {
            Book = new Book();
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
            Genres = new List<Genre>();
        }
    }
}