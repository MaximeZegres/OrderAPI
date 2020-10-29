using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Data;
using OrderAPI.Models;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderAPIRepo _repository;

        public OrdersController(IOrderAPIRepo repository)
        {
            _repository = repository;
        }



    }
}