using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Data;
using OrderAPI.Dtos;
using OrderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrderAPI.Controllers
{
    public class CustomersController : ControllerBase
    {
        private readonly IOrderAPIRepo _repository;
        private readonly IMapper _mapper;

        public CustomersController(IOrderAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerReadDto>> GetAllCustomers()
        {
            var customers = _repository.GetAllCustomers();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
        }

        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<CustomerReadDto> GetCustomerById(int id)
        {
            var customer = _repository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CustomerReadDto>(customer));
        }

        [HttpPost]
        public ActionResult<CustomerCreateDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<Customer>(customerCreateDto);
            _repository.CreateCustomer(customerModel);
            _repository.SaveChanges();

            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);
            return CreatedAtRoute(nameof(GetCustomerById), new { Id = customerReadDto.CustomerId }, customerReadDto);
        }


        [HttpPatch]
        public ActionResult PartialCustomerUpdate(int id, JsonPatchDocument<CustomerUpdateDto> patchCustomer)
        {
            var customerFromRepo = _repository.GetCustomerById(id);
            if (customerFromRepo == null)
            {
                return NotFound();
            }

            var customerToPatch = _mapper.Map<CustomerUpdateDto>(customerFromRepo);
            patchCustomer.ApplyTo(customerToPatch, ModelState);
            if (!TryValidateModel(customerToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(customerToPatch, customerFromRepo);
            _repository.UpdateCustomer(customerFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customerFromRepo = _repository.GetCustomerById(id);
            if (customerFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteCustomer(customerFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}
