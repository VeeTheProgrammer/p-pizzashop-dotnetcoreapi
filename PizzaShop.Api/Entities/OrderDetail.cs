using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Entities
{
    [Table("order_detail")]
    public class OrderDetail
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pizza_id")]
        [Required]
        public List<int> PizzaId { get; set; } = new List<int>();

        [Column("price")]
        [Required]
        public Decimal Price { get; set; }

        [Required]
        public Pizza Pizza { get; set; } = new Pizza();
    }
}
