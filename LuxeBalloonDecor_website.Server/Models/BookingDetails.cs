using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class BookingDetails
    {
        [Key]
        public int bookingDetailsID { get; set; }
        public int bookingID { get; set; }
    }
}
