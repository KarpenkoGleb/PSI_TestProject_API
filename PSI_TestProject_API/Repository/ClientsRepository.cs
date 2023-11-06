﻿using AutoMapper;
using PSI_TestProject_API.Data;
using PSI_TestProject_API.Interfaces;
using PSI_TestProject_API.Models;
using System.Diagnostics.Metrics;

namespace PSI_TestProject_API.Repository
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ClientsRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public bool ClientExists(int clientId)
        {
            return _context.Clients.Any(c => c.Id == clientId);
        }
        public bool ClientExistsWithLpgin(string login)
        {
            return _context.Clients.Any(c => c.Login == login);
        }

        public bool CreateClient(Clients client)
        {
            _context.Add(client);
            return Save();
        }

        public bool DeleteClient(Clients client)
        {
            _context.Remove(client);
            return Save();
        }

        public Clients GetClient(int id)
        {
            return _context.Clients.Where(c => c.Id == id).FirstOrDefault();
        }

        public Clients GetClientByInvoice(int invoiceId)
        {
            return _context.Invoices.Where(o => o.Id == invoiceId).Select(c => c.Client).FirstOrDefault();
        }

        public Clients GetClientByLogin(string login)
        {
            return _context.Clients.Where(o => o.Login == login).FirstOrDefault();
        }


        public ICollection<Clients> GetClients()
        {
            return _context.Clients.ToList();
        }

        //public ICollection<Invoices> GetInvoicesOfClient(int clientId)
        //{
        //    return _context.Invoices.Where(c => c.Client.Id == clientId).ToList();
        //}


        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateClient(Clients client)
        {
            _context.Update(client);
            return Save();
        }
    }
}