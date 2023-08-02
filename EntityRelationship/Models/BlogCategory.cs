using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityRelationship.Models
{
    [Table("T_BlogCategory")]
    public class BlogCategory
    {
        [Key]
        public int BlogCategoryId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int PostIs { get; set; }

        public Category Category { get; set; }
        public Post Post { get; set; }
    }
}