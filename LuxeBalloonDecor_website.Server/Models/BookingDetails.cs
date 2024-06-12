using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class BookingDetails
    {
        [Key]
        public int bookingDetailsID { get; set; }
        public int bookingID { get; set; }
        public int venueID { get; set; }
        public int inventoryID { get; set; }
    }
}
