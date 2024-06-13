using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Analytics
    {
        [Key]
        public int analyticsID { get; set; }
        public int pageID { get; set; }
        public int view { get; set; }
    }
}
