using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class MultimediaContent
    {
        [Key]
        public int multimediaContentID { get; set; }
        public int contentType { get; set; } // Content Type Enum
        public string filePath { get; set; }
        public int filesize { get; set; }
        public int fileFormat { get; set; } // File Type Enum
        public string description { get; set; }
    }
}
