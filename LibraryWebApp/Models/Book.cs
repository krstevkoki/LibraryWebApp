using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWebApp.Models
{
    public class Book
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Pages { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public Genre Genre { get; set; }

        public string CoverURL { get; set; }

        [Required]
        public string PublishPlace { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime PublishDate { get; set; }

        public virtual ICollection<Author> Authors { get; set; }

        public virtual ICollection<Publisher> Publishers { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public Book()
        {
            Authors = new List<Author>();
            Publishers = new List<Publisher>();
            Reviews = new List<Review>();
        }
    }
}