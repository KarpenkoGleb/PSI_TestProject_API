﻿using PSI_TestProject_API.Models;

namespace PSI_TestProject_API.Interfaces
{
    public interface IInvoicesRepository
    {
        ICollection<Invoices> GetInvoices();
        Invoices GetInvoice(int invoiceId);
        ICollection<Invoices> GetInvoicesOfClient(int clientId);
        ICollection<Invoices> GetInvoicesOfService(int serviceId);
        ICollection<Invoices> GetInvoicesByFilters(int? clientId
                                                 , int? serviceId
                                                 , DateTime? creationDate
                                                 , DateTime? paymentDate
                                                 , bool? isPaymentCompleted);
        bool InvoiceExists(int invoiceId);
        bool CreateInvoice(Invoices invoice);
        bool UpdateInvoice(Invoices invoice);
        bool DeleteInvoice(Invoices invoice);
        bool Save();
    }
}