using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Address
    {
        [Key]
        public int addressID { get; set; }
        public int personID { get; set; }
        public int addressType { get; set; } // Address Type Enum
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
    }
}
