using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class InvoiceDetails
    {
        [Key]
        public int invoiceDetailsID { get; set; }
        public int financialRecordID { get; set; }
        public decimal amount { get; set; }
        public DateTime dateTime { get; set; }
        public int status { get; set; } // Financial Status Enum
        public string reciptDetails { get; set; }
        public string paymentDetails { get; set; }
    }
}
