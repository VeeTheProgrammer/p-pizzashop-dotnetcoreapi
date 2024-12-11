using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Core.Entities
{
    [Table("address")]
    public class Address
    {
        [Column("id")]
        public int Id { get; set; } 

        [Required]
        [Column("street_number")]
        public int StreetNumber { get; set; }

        [Column("address_line1")]
        [Required, MaxLength(250)]
        public string AddressLine1 { get; set; } = string.Empty;

        [Column("address_line2")]
        [MaxLength(250)]
        public string? AddressLine2 { get; set; }

        [Column("city")]
        [Required, MaxLength(250)]
        public string City { get; set; } = string.Empty;

        [Required]
        [Column("state_id")]
        public int StateID { get; set; }

        [Required]
        [Column("zip")]
        public int Zip { get; set; }

        [Required]
        public AddressState AddressState { get; set; } = new AddressState();
    }
}
