using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Venue
    {
        [Key]
        public int venueID { get; set; }
        public string name { get; set; }
        public int addressID { get; set; }
    }
}
