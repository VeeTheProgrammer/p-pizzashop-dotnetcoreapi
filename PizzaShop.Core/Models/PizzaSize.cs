using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Models
{
    public partial class PizzaSize
    {
        public int Id { get; set; }

        [Required]
        public string Size { get; set; }
    }
}
