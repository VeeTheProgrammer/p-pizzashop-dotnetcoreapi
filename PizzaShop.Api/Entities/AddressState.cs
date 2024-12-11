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
    [Table("address_state")]
    public class AddressState
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("state_initial")]
        [Required, MaxLength(5)]
        public string StateInitial { get; set; } = string.Empty;

        [Column("state_name")]
        [Required, MaxLength(200)]
        public string StateName { get; set; } = string.Empty;
    }

    public enum AddressStateInitialEnum : int
    {
        [Description("Alabama")]
        AL = 1,

        [Description("Alaska")]
        AK = 2,

        [Description("Arizona")]
        AZ = 3,

        [Description("Arkansas")]
        AR = 4,

        [Description("California")]
        CA = 5,

        [Description("Colorado")]
        CO = 6,

        [Description("Connecticut")]
        CT = 7,

        [Description("Delaware")]
        DE = 8,

        [Description("Florida")]
        FL = 9,

        [Description("Georgia")]
        GA = 10,

        [Description("Hawaii")]
        HI = 11,

        [Description("Idaho")]
        ID = 12,

        [Description("Illinois")]
        IL = 13,

        [Description("Indiana")]
        IN = 14,

        [Description("Iowa")]
        IA = 15,

        [Description("Kansas")]
        KS = 16,

        [Description("Kentucky")]
        KY = 17,

        [Description("Louisiana")]
        LA = 18,

        [Description("Maine")]
        ME = 19,

        [Description("Montana")]
        MT = 20,

        [Description("Nebraska")]
        NE = 21,

        [Description("Nevada")]
        NV = 22,

        [Description("New Hampshire")]
        NH = 23,

        [Description("New Jersey")]
        NJ = 24,

        [Description("New Mexico")]
        NM = 25,

        [Description("New York")]
        NY = 26,

        [Description("North Carolina")]
        NC = 27,

        [Description("North Dakota")]
        ND = 28,

        [Description("Ohio")]
        OH = 29,

        [Description("Oklahoma")]
        OK = 30,

        [Description("Oregon")]
        OR = 31,

        [Description("Maryland")]
        MD = 32,

        [Description("Massachusetts")]
        MA = 33,

        [Description("Michigan")]
        MI = 34,

        [Description("Minnesota")]
        MN = 35,

        [Description("Mississippi")]
        MS = 36,

        [Description("Missouri")]
        MO = 37,

        [Description("Pennsylvania")]
        PA = 38,

        [Description("Rhode Island")]
        RI = 39,

        [Description("South Carolina")]
        SC = 40,

        [Description("South Dakota")]
        SD = 41,

        [Description("Tennessee")]
        TN = 42,

        [Description("Texas")]
        TX = 43,

        [Description("Utah")]
        UT = 44,

        [Description("Vermont")]
        VT = 45,

        [Description("Virginia")]
        VA = 46,

        [Description("Washington")]
        WA = 47,

        [Description("West Virginia")]
        WV = 48,

        [Description("Wisconsin")]
        WI = 49,

        [Description("Wyoming")]
        WY = 50,

        [Description("District of Columbia")]
        DC = 51,
    }
}
