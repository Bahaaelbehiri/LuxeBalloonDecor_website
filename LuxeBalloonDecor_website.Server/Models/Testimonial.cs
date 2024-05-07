namespace LuxeBalloonDecor_website.Server.Models
{
    public class Testimonial
    {
        public int TestimonailID { get; set; }
        public string TestimonialTitle { get; set; }
        public DateOnly TestimonialDate { get; set; }
        public string TestimonailDescription { get; set; }
        public string TestimonailInitials { get; set; }
    }
}
