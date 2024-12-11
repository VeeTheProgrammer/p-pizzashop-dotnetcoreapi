using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }

        [Required]
        public List<int> PizzaId { get; set; }

        [Required]
        public Decimal Price { get; set; }
    }
}
