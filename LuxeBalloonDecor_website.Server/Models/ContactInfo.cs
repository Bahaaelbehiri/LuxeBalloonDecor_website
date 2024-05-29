using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class ContactInfo
    {
        [Key]
        public int contactInfoID { get; set; }
        public int personID { get; set; }
        public int contactType { get; set; } // Contact Type Enum
        public string value { get; set; }

    }
}
