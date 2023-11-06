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
    public class ClientsController : Controller
    {
        private readonly IClientsRepository _clientsRepository;
        private readonly IMapper _mapper;

        public ClientsController(IClientsRepository clientsRepository, IMapper mapper)
        {
            _clientsRepository = clientsRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Clients>))]
        public IActionResult GetClients()
        {
            var clients = _mapper.Map<List<ClientsDto>>(_clientsRepository.GetClients());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(clients);
        }

        [HttpGet("{clientId}")]
        [ProducesResponseType(200, Type = typeof(Clients))]
        [ProducesResponseType(400)]
        public IActionResult GetClient(int clientId)
        {
            if (!_clientsRepository.ClientExists(clientId))
                return NotFound();

            var client = _mapper.Map<ClientsDto>(_clientsRepository.GetClient(clientId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(client);
        }

        [HttpGet("byLogin/{login}")]
        [ProducesResponseType(200, Type = typeof(Clients))]
        [ProducesResponseType(400)]
        public IActionResult GetClientByLogin(string login)
        {
            if (!_clientsRepository.ClientExistsWithLpgin(login))
                return NotFound();

            var client = _mapper.Map<ClientsDto>(_clientsRepository.GetClientByLogin(login));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(client);
        }

        [HttpGet("/clients/{invoiceId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(Clients))]
        public IActionResult GetClientByInvoice(int invoiceId)
        {
            var client = _mapper.Map<ClientsDto>(
                _clientsRepository.GetClientByInvoice(invoiceId));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(client);
        }

        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        public IActionResult CreateClient([FromBody] ClientsDto clientCreate)
        {
            if (clientCreate == null)
                return BadRequest(ModelState);

            var client = _clientsRepository.GetClients()
                .Where(c => c.Login.Trim().ToUpper() == clientCreate.Login.TrimEnd().ToUpper())
                .FirstOrDefault();

            if (client != null)
            {
                ModelState.AddModelError("", "Client already exists");
                return StatusCode(422, ModelState);
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clientMap = _mapper.Map<Clients>(clientCreate);

            if (!_clientsRepository.CreateClient(clientMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }

            return Ok(clientMap);  // return Ok("Successfully created");
        }

        [HttpPut("{clientId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult UpdateClient(int clientId, [FromBody] ClientsDto updatedClient)
        {
            if (updatedClient == null)
                return BadRequest(ModelState);

            if (clientId != updatedClient.Id)
                return BadRequest(ModelState);

            if (!_clientsRepository.ClientExists(clientId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var clientMap = _mapper.Map<Clients>(updatedClient);

            if (!_clientsRepository.UpdateClient(clientMap))
            {
                ModelState.AddModelError("", "Something went wrong while updating client");
                return StatusCode(500, ModelState);
            }

            return NoContent();
        }

        [HttpDelete("{clientId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult DeleteClient(int clientId)
        {
            if (!_clientsRepository.ClientExists(clientId))
            {
                return NotFound();
            }

            var clientToDelete = _clientsRepository.GetClient(clientId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_clientsRepository.DeleteClient(clientToDelete))
            {
                ModelState.AddModelError("", "Something went wrong while deleting client");
            }

            return NoContent();
        }
    }
}