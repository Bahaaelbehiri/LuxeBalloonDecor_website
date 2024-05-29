using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Booking
    {
        [Key]
        public int bookingID { get; set; }
        public int venueID { get; set; }
        public int personID { get; set; }
        public DateTime dateTime { get; set; }
        public string details { get; set; }
        public int orderNumber { get; set; }
        public int bookingStatus { get; set; } // Booking Status Enum
    }
}
