﻿using PSI_TestProject_API.Dto;
using PSI_TestProject_API.Models;
using System.Diagnostics.Metrics;

namespace PSI_TestProject_API.Interfaces
{
    public interface IClientsRepository
    {
        ICollection<Clients> GetClients();
        Clients GetClient(int id);
        Clients GetClientByInvoice(int invoiceId);
        Clients GetClientByLogin(string login);
        //ICollection<Invoices> GetInvoicesOfClient(int clientId);
        bool ClientExists(int clientId);
        bool ClientExistsWithLpgin(string login);
        bool CreateClient(Clients client);
        bool UpdateClient(Clients client);
        bool DeleteClient(Clients client);
        bool Save();
    }
}