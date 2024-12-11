using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PizzaShop.Core.Entities
{
    [Table("pizza_size")]
    public class PizzaSize
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("size")]
        [Required, MaxLength(100)]
        public string Size { get; set; } = string.Empty;
    }
    
    public enum PizzaSizeEnum : int
    {
        [Description("Small")]
        Small = 1,

        [Description("Medium")]
        Medium = 2,

        [Description("Large")]
        Large = 3,

        [Description("Extra Large")]
        ExtraLarge = 4
    }
}
