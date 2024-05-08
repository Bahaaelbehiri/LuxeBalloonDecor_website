using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class InventoryItem
    {
        [Key]
        public int InventoryID { get; set; }
        public Image InventoryImage { get; set; }
        public string InventoryTitle { get; set; }
        public string InventoryDescription { get; set; }
        public ICollection<InventoryVariant> Variants { get; set; }
    }
}
