using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class VariantPrice
    {
        [Key]
        public int PriceId { get; set; }
        public int VariantID { get; set; }
        public string Price { get; set; }
    }
}
