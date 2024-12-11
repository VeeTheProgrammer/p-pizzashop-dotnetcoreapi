using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Entities
{

    [Table("pizza_topping")]
    public class PizzaTopping
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pizza_topping")]
        [Required(AllowEmptyStrings = false), MaxLength(100)]
        public string Topping { get; set; } = string.Empty;
    }

    public enum PizzaToppingEnum : int
    {
        [Description("Pepperoni")]
        Pepperoni = 1,

        [Description("Cheese")]
        Cheese = 2,

        [Description("Ham")]
        Ham = 3,

        [Description("Banana Peppers")]
        BananaPeppers = 4,

        [Description("Steak")]
        Steak = 5,

        [Description("Beef")]
        Beef = 6,

        [Description("Spinach")]
        Spinach = 7,

        [Description("Mushrooms")]
        Mushrooms = 8,

        [Description("Sausage")]
        Sausage = 9,

        [Description("Bacon")]
        Bacon = 10,

        [Description("Green Peppers")]
        GreenPeppers = 11,

        [Description("Onions")]
        Onions = 12,

        [Description("Chicken")]
        Chicken = 13
    }
}
