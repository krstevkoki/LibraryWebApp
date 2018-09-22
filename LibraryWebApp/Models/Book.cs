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
        [Range(1, int.MaxValue, ErrorMessage = "The Pages field must be greater than zero")]
        public int Pages { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The Quantity field must be non-negative number")]
        public int Quantity { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Range(0, 100000.00, ErrorMessage = "The Price field must be non-negative number")]
        public decimal Price { get; set; }

        [Display(Name = "Cover URL")]
        public string CoverURL { get; set; }

        [Required]
        [Display(Name = "Publish Place")]
        public string PublishPlace { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        [Display(Name = "Publish Date")]
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