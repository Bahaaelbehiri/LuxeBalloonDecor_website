using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public DateTime BookingDate { get; set; }
        public ICollection<InventoryItem> BookingItems { get; set; }
    }
}
