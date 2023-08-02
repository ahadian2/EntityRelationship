using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityRelationship.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Required]
        [MaxLength(100)]
        public string AuthorName { get; set; }
        [Required]
        [MaxLength(100)]
        public string AuthorFamily { get; set; }
        [Required]
        [MaxLength(100)]
        public string AuthorEmail { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}