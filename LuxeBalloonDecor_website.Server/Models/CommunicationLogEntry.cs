using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class CommunicationLogEntry
    {
        [Key]
        public int logID { get; set; }
        public int personID { get; set; }
        public DateTime date { get; set; }
        public int mode { get; set; } // Mode Enum
        public string content { get; set; }
        public int? multimediaContentID { get; set; }
        public int outcome { get; set; } // Communication Outcome Enum
    }
}
