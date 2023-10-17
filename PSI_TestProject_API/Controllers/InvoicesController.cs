﻿﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PSI_TestProject_API.Dto;
using PSI_TestProject_API.Interfaces;
using PSI_TestProject_API.Models;
using PSI_TestProject_API.Repository;

namespace PSI_TestProject_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : Controller
    {
        private readonly IInvoicesRepository _invoicesRepository;
        private readonly IServicesRepository _servicesRepository;
        private readonly IClientsRepository _clientsRepository;
        private readonly IMapper _mapper;

        public InvoicesController(IInvoicesRepository invoicesRepository,
            IServicesRepository servicesRepository,
            IClientsRepository clientsRepository,
            IMapper mapper)
        {
            _invoicesRepository = invoicesRepository;
            _servicesRepository = servicesRepository;
            _clientsRepository = clientsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Invoices>))]
        public IActionResult GetInvoices()
        {
            var invoices = _mapper.Map<List<InvoicesDto>>(_invoicesRepository.GetInvoices());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(invoices);
        }

        [HttpGet("{invoiceId}")]
        [ProducesResponseType(200, Type = typeof(Invoices))]
        [ProducesResponseType(400)]
        public IActionResult GetInvoice(int invoiceId)
        {
            if (!_invoicesRepository.InvoiceExists(invoiceId))
                return NotFound();

            var invoice = _mapper.Map<InvoicesDto>(_invoicesRepository.GetInvoice(invoiceId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(invoice);
        }

        [HttpGet("byClientId/{clientId}")]
        [ProducesResponseType(200, Type = typeof(Invoices))]
        [ProducesResponseType(400)]
        public IActionResult GetInvoicesByClient(int clientId)
        {
            if (!_clientsRepository.ClientExists(clientId))
                return NotFound();

            var invoices = _mapper.Map<List<InvoicesDto>>(
                _invoicesRepository.GetInvoicesOfClient(clientId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(invoices);
        }

        [HttpGet("byServiceId/{serviceId}")]
        [ProducesResponseType(200, Type = typeof(Invoices))]
        [ProducesResponseType(400)]
        public IActionResult GetInvoicesByService(int serviceId)
        {
            if (!_servicesRepository.ServiceExists(serviceId))
            {
                return NotFound();
            }

            var invoices = _mapper.Map<List<InvoicesDto>>(
                _invoicesRepository.GetInvoicesOfService(serviceId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(invoices);
        }

        [HttpGet("byfilters")]
        [ProducesResponseType(200, Type = typeof(Invoices))]
        [ProducesResponseType(400)]
        public IActionResult GetInvoicesByFilters(int? clientId
                                                , int? serviceId
                                                , DateTime? creationDate
                                                , DateTime? paymentDate
                                                , bool? isPaymentCompleted)
        {
            //if (clientId != null && !_clientsRepository.ClientExists(clientId))
            //    return NotFound();

            //if (!_servicesRepository.ServiceExists(serviceId))
            //    return NotFound();

            var invoices = _mapper.Map<List<InvoicesDto>>(
                _invoicesRepository.GetInvoicesByFilters(clientId
                                                        , serviceId
                                                        , creationDate
                                                        , paymentDate
                                                        , isPaymentCompleted));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(invoices);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateInvoice([FromBody] InvoicesDto invoiceCreate)
        {
            if (invoiceCreate == null)
                return BadRequest(ModelState);

            var invoices = _invoicesRepository.GetInvoices()
                .Where(c => c.receiptId == invoiceCreate.receiptId)
                .FirstOrDefault();

            if (invoices != null)
            {
                ModelState.AddModelError("", "Invoice already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var invoiceMap = _mapper.Map<Invoices>(invoiceCreate);

            //invoiceMap.Service = _servicesRepository.GetService(serviceId);

            if (!_invoicesRepository.CreateInvoice(invoiceMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpPut("{invoiceId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateInvoice(int invoiceId, [FromBody] InvoicesDto updatedInvoice)
        {
            if (updatedInvoice == null)
                return BadRequest(ModelState);

            if (invoiceId != updatedInvoice.Id)
                return BadRequest(ModelState);

            if (!_invoicesRepository.InvoiceExists(invoiceId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var invoiceMap = _mapper.Map<Invoices>(updatedInvoice);

            if (!_invoicesRepository.UpdateInvoice(invoiceMap))
            {
                ModelState.AddModelError("", "Something went wrong updating invoice");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{invoiceId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteOwner(int invoiceId)
        {
            if (!_invoicesRepository.InvoiceExists(invoiceId))
            {
                return NotFound();
            }

            var invoiceToDelete = _invoicesRepository.GetInvoice(invoiceId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_invoicesRepository.DeleteInvoice(invoiceToDelete))
            {
                ModelState.AddModelError("", "Something went wrong deleting invoice");
            }

            return NoContent();
        }
    }
}