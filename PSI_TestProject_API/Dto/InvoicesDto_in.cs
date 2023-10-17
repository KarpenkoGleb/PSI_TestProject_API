using PSI_TestProject_API.Models;

namespace PSI_TestProject_API.Dto
{
    public class InvoicesDto_in
    {
        public int Id { get; set; }
        public int Service { get; set; }
        public int Client { get; set; }
        public int Amount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PayBefore { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int receiptId { get; set; }
        public bool IsPaymentCompleted { get; set; }
    }
}
