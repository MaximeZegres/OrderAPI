using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Data;
using OrderAPI.Dtos;
using OrderAPI.Models;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderAPIRepo _repository;
        private readonly IMapper _mapper;

        public OrdersController(IOrderAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrderReadDto>> GetAllOrders()
        {
            var orders = _repository.GetAllOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orders));
        }

        [HttpGet("{id}", Name = "GetOrderById")]
        public ActionResult<OrderReadDto> GetOrderById(int id)
        {
            var order = _repository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderReadDto>(order));
        }

        [HttpPost]
        public ActionResult<OrderCreateDto> CreateOrder([FromBody]OrderCreateDto orderCreateDto)
        {

            var orderModel = _mapper.Map<Order>(orderCreateDto);
            _repository.CreateOrder(orderModel);
            _repository.SaveChanges();

            var orderReadDto = _mapper.Map<OrderReadDto>(orderModel);
            return CreatedAtRoute(nameof(GetOrderById), new { Id = orderReadDto.OrderId }, orderReadDto);
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var orderFromRepo = _repository.GetOrderById(id);
            if (orderFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteOrder(orderFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}