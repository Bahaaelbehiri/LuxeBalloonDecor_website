using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class StyleSettings
    {
        [Key]
        public int settingsID { get; set; }
        public int pageID { get; set; }
        public string font { get; set; }
        public string colorScheme { get; set; }
    }
}
