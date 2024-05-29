using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Page
    {
        [Key]
        public int pageID { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
