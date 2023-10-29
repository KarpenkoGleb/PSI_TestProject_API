

namespace PSI_TestProject_API.Dto
{
    public class InvoicesDto
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public int Amount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PayBefore { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? receiptId { get; set; }
        public bool IsPaymentCompleted { get; set; }
        public ServicesDto? Service { get; set; }
        public ClientsDto? Client { get; set; }
    }
}
