using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Entities
{
    [Table("pizza")]
    public class Pizza
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pizza_size_id")]
        [Required]
        public int PizzaSizeId { get; set; }

        [Column("pizza_topping_id")]
        [Required]
        public List<int> PizzaToppingId { get; set; } = new List<int>();

        [Column("pizza_size")]
        [Required]
        public PizzaSize PizzaSize { get; set; } = new PizzaSize();

        [Required]
        public List<PizzaTopping> PizzaToppings { get; set; } = new List<PizzaTopping>();
    }
}
