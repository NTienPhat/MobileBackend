using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Status { get; set; }
        public int TotalPrice { get; set; }
        [ForeignKey("OrderItem")]
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }


    }
}
