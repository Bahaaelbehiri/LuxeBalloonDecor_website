using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class CustomerBookings
    {
        [Key]
        public int CustomerBookingID { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
    }
}
