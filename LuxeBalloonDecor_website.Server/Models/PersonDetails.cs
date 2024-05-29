using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class PersonDetails
    {
        [Key]
        public int personID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public int role { get; set; } // Stored as Int compare with enum when getting
        public List<string> testimonials { get; set; }
        public List<ContactInfo> contactDetails { get; set; }
    }
}
