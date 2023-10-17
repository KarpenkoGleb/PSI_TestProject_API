
using Microsoft.EntityFrameworkCore;
using PSI_TestProject_API.Data;
using PSI_TestProject_API.Interfaces;
using PSI_TestProject_API.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PSI_TestProject_API.Repository
{
    public class InvoicesRepository : IInvoicesRepository
    {
        private readonly DataContext _context;

        public InvoicesRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateInvoice(Invoices invoice)
        {
            _context.Add(invoice);
            return Save();
        }

        public bool DeleteInvoice(Invoices invoice)
        {
            _context.Remove(invoice);
            return Save();
        }

        public Invoices GetInvoice(int invoiceId)
        {
            return _context.Invoices.Where(i => i.Id == invoiceId)
                .Include(i => i.Client)
                .Include(i => i.Service)
                .OrderBy(i => i.CreationDate)
                .FirstOrDefault();
        }

        public ICollection<Invoices> GetInvoices()
        {
            return _context.Invoices
                .Include(i => i.Client)
                .Include(i => i.Service)
                .OrderBy(i => i.CreationDate)
                .ToList();
        }

        public ICollection<Invoices> GetInvoicesOfClient(int clientId)
        {
            return _context.Invoices.Where(i => i.Client.Id == clientId).ToList();
        }

        public ICollection<Invoices> GetInvoicesOfService(int serviceId)
        {
            return _context.Invoices.Where(i => i.Service.Id == serviceId).ToList();
        }

        public ICollection<Invoices> GetInvoicesByFilters(int? clientId
                                                        , int? serviceId
                                                        , DateTime? creationDate
                                                        , DateTime? paymentDate
                                                        , bool? isPaymentCompleted)
        {
            return _context.Invoices
                .Include(i => i.Client)
                .Include(i => i.Service)
                .Where(i => clientId == null || i.Client.Id == clientId)
                .Where(i => serviceId == null || i.Service.Id == serviceId)
                .Where(i => creationDate == null || i.CreationDate == creationDate)
                .Where(i => paymentDate == null || i.PaymentDate == paymentDate)
                .Where(i => isPaymentCompleted == null || i.IsPaymentCompleted == isPaymentCompleted)
                .OrderBy(x => x.CreationDate)
                .ToList();
        }

        public bool InvoiceExists(int invoiceId)
        {
            return _context.Invoices.Any(i => i.Id == invoiceId);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateInvoice(Invoices invoice)
        {
            _context.Update(invoice);
            return Save();
        }
    }
}
