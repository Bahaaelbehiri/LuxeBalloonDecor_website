using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class BookingInventory
    {
        [Key]
        public int bookingInventoryID { get; set; }
        public int bookingID { get; set; }
        public int itemID { get; set; }
        public int quantity { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

    }
}
