using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public int Number { get; set; }
        [Required]
        [Range(0,255)]
        public int CountInStock { get; set; }
        public int Rating { get; set; }
        public int NumReviews { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime DateCreated { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
