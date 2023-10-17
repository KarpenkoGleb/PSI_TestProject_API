﻿using AutoMapper;
using PSI_TestProject_API.Data;
using PSI_TestProject_API.Interfaces;
using PSI_TestProject_API.Models;
using System.Diagnostics.Metrics;

namespace PSI_TestProject_API.Repository
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ServicesRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public bool ServiceExists(int serviceId)
        {
            return _context.Services.Any(c => c.Id == serviceId);
        }

        public bool CreateService(Services service)
        {
            _context.Add(service);
            return Save();
        }

        public bool DeleteService(Services service)
        {
            _context.Remove(service);
            return Save();
        }

        public Services GetService(int serviceId)
        {
            return _context.Services.Where(c => c.Id == serviceId).FirstOrDefault();
        }

        public Services GetServiceByInvoice(int invoiceId)
        {
            return _context.Invoices.Where(i => i.Id == invoiceId).Select(s => s.Service).FirstOrDefault();
        }

        public ICollection<Services> GetServices()
        {
            return _context.Services.ToList();
        }

        //public ICollection<Invoices> GetInvoicesOfService(int serviceId)
        //{
        //    return _context.Invoices.Where(i => i.Service.Id == serviceId).ToList();
        //}


        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateService(Services service)
        {
            _context.Update(service);
            return Save();
        }
    }
}