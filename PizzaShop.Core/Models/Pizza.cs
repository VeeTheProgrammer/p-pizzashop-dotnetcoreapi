using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Models
{
    public partial class Pizza
    {
        public int Id { get; set; }

        [Required]
        public int PizzaSizeId { get; set; }

        [Required]
        public List<int> PizzaToppingId { get; set; }
    }
}
