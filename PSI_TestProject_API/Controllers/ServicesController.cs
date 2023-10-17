﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PSI_TestProject_API.Dto;
using PSI_TestProject_API.Interfaces;
using PSI_TestProject_API.Models;
using PSI_TestProject_API.Repository;

namespace PSI_TestProject_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : Controller
    {
        private readonly IServicesRepository _servicesRepository;
        private readonly IMapper _mapper;

        public ServicesController(IServicesRepository ServicesRepository, IMapper mapper)
        {
            _servicesRepository = ServicesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Services>))]
        public IActionResult GetServices()
        {
            var Services = _mapper.Map<List<ServicesDto>>(_servicesRepository.GetServices());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(Services);
        }

        [HttpGet("{serviceId}")]
        [ProducesResponseType(200, Type = typeof(Services))]
        [ProducesResponseType(400)]
        public IActionResult GetService(int serviceId)
        {
            if (!_servicesRepository.ServiceExists(serviceId))
                return NotFound();

            var service = _mapper.Map<ServicesDto>(_servicesRepository.GetService(serviceId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(service);
        }

        [HttpGet("/services/{invoiceId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(Services))]
        public IActionResult GetServiceByInvoice(int invoiceId)
        {
            var service = _mapper.Map<ServicesDto>(
                _servicesRepository.GetServiceByInvoice(invoiceId));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(service);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateService([FromBody] ServicesDto ServiceCreate)
        {
            if (ServiceCreate == null)
                return BadRequest(ModelState);

            var Service = _servicesRepository.GetServices()
                .Where(c => c.Service.Trim().ToUpper() == ServiceCreate.Service.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (Service != null)
            {
                ModelState.AddModelError("", "Service already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var ServiceMap = _mapper.Map<Services>(ServiceCreate);

            if (!_servicesRepository.CreateService(ServiceMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok("Successfully created");
        }

        [HttpPut("{serviceId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateService(int serviceId, [FromBody] ServicesDto updatedService)
        {
            if (updatedService == null)
                return BadRequest(ModelState);

            if (serviceId != updatedService.Id)
                return BadRequest(ModelState);

            if (!_servicesRepository.ServiceExists(serviceId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var ServiceMap = _mapper.Map<Services>(updatedService);

            if (!_servicesRepository.UpdateService(ServiceMap))
            {
                ModelState.AddModelError("", "Something went wrong while updating Service");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{serviceId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteService(int serviceId)
        {
            if (!_servicesRepository.ServiceExists(serviceId))
            {
                return NotFound();
            }

            var ServiceToDelete = _servicesRepository.GetService(serviceId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_servicesRepository.DeleteService(ServiceToDelete))
            {
                ModelState.AddModelError("", "Something went wrong while deleting Service");
            }

            return NoContent();
        }
    }
}