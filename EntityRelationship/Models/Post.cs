using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityRelationship.Models
{
    [Table("T_Post")]
    public class Post
    {
        [Key]
        public int PostIs { get; set; }
        [Required]
        [MaxLength(200)]
        public string PostTitel { get; set; }
        public string PostDescription { get; set; }
        [MaxLength(100)]
        public string PostImage { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}