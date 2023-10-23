

namespace PSI_WinForms.DTO
{
    internal class InvoicesDTO
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
        public int Amount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime PayBefore { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int receiptId { get; set; }
        public bool IsPaymentCompleted { get; set; }
        public ServicesDTO? Service { get; set; }
        public ClientsDTO? Client { get; set; }
    }
}
