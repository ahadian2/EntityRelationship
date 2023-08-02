using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityRelationship.Models
{
    [Table("T_Category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }
        [MaxLength(400)]
        public string CategoryDescription { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}