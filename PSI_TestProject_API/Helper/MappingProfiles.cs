using AutoMapper;
using PSI_TestProject_API.Dto;
using PSI_TestProject_API.Models;
using System.Diagnostics.Metrics;

namespace PSI_TestProject_API.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Clients, ClientsDto>();
            CreateMap<ClientsDto, Clients>();
            CreateMap<Services, ServicesDto>();
            CreateMap<ServicesDto, Services>();
            CreateMap<Invoices, InvoicesDto>();
            CreateMap<InvoicesDto, Invoices>();
        }
    }
}