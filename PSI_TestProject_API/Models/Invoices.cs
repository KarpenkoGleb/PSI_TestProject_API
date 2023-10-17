using System.ComponentModel.DataAnnotations.Schema;

namespace PSI_TestProject_API.Models
{
    [Table("Invoices")]
    public class Invoices
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("ServiceId")]
        public int ServiceId { get; set; }

        [Column("ClientId")]
        public int ClientId { get; set; }

        [Column("Amount")]
        public int Amount { get; set; }

        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }

        [Column("PayBefore")]
        public DateTime PayBefore { get; set; }

        [Column("PaymentDate")]
        public DateTime? PaymentDate { get; set; }

        [Column("receiptId")]
        public int receiptId { get; set; }

        [Column("IsPaymentCompleted")]
        public bool IsPaymentCompleted { get; set; }

        public Services? Service { get; set; }
        public Clients? Client { get; set; }
    }
}
