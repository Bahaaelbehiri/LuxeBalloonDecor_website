using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public string ImageURL { get; set; }
        public string ImageName { get; set; }
        public string ImageShortDescription { get; set; }
    }
}
