using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Entities
{
    [Table("order")]
    public class Order
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("customer_id")]
        [Required]
        public int CustomerId { get; set; }

        [Column("total_price")]
        [Required]
        public Decimal TotalPrice { get; set; }

        [Required]
        public Customer Customer { get; set; }  = new Customer();
    }
}
