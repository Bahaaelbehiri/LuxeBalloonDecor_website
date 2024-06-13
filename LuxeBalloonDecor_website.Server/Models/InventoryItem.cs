using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class InventoryItem
    {
        [Key]
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemDescription { get; set; }
        public int quantityAvailable { get; set; }
    }
}
