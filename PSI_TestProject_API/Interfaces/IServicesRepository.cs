﻿using PSI_TestProject_API.Dto;
using PSI_TestProject_API.Models;
using System.Diagnostics.Metrics;

namespace PSI_TestProject_API.Interfaces
{
    public interface IServicesRepository
    {
        ICollection<Services> GetServices();
        Services GetService(int Id);
        Services GetServiceByInvoice(int invoiceId);
        //ICollection<Invoices> GetInvoicesOfService(int serviceId);
        bool ServiceExists(int serviceId);
        bool CreateService(Services service);
        bool UpdateService(Services service);
        bool DeleteService(Services service);
        bool Save();
    }
}