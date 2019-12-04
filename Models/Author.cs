using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookshelf4.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public string Penname { get; set; }
        public string PreferredGenre { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

      
        public string UserCreatedId { get; set; }
        public ApplicationUser UserCreated { get; set; }
    }
}