using System.ComponentModel.DataAnnotations;

namespace LuxeBalloonDecor_website.Server.Models
{
    public class FinancialRecord
    {
        [Key]
        public int financialRecordID { get; set; }
        public int bookingID { get; set; }
        public int personID { get; set; }
        public int entryType { get; set; } // Entry Type Enum
        public int status { get; set; } // Financial Status Enum
        public decimal amount { get; set; }
        public DateTime dateTime { get; set; }
        public int invoiceDetailsID { get; set; }
    }
}
