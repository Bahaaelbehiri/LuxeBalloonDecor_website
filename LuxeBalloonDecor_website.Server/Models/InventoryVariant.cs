using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class InventoryVariant
    {
        [Key]
        public int VariantID { get; set; }
        public int ItemID { get; set; }
        public ICollection<VariantPrice> InventoryPrices { get; set; }
    }
}
