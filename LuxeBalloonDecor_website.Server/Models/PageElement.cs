using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class PageElement
    {
        [Key]
        public int elementID { get; set; }
        public int pageID { get; set; }
        public int elementType { get; set; } // Element Type Enum
        public string content { get; set; }
        public int? multimediaContentID { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
        public decimal? price { get; set; }
    }
}
