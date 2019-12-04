using System;
using System.ComponentModel.DataAnnotations;

namespace Bookshelf4.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(13)]
        public string ISBN { get; set; }

        [Required]
        public string Title { get; set; }
        public string Genre { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required]
        [Display(Name = "Owner")]
        public string OwnerId { get; set; }
        public ApplicationUser Owner { get; set; }

    }
}
