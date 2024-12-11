using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Entities
{
    [Table("customer")]
    public class Customer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        [Required, MaxLength(200)]
        public string FirstName { get; set; } = string.Empty;

        [Column("last_name")]
        [Required, MaxLength(200)]
        public string LastName { get; set; } = string.Empty;

        [Column("address_id")]
        [Required]
        public int AddressId { get; set; }

        [Required]
        public Address Address { get; set; } = new Address();
    }
}
