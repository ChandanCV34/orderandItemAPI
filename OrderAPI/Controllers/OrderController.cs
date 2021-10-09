using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;
using OrderAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderServices;

        public OrderController(OrderService orderService)
        {
            _orderServices = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderServices.Get();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderServices.Getid(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody] Order order)
        {
            var ord =  _orderServices.Add(order);
            if (ord != null)
                return ord;
            return BadRequest("Not able to order");

        }
        [Route("Create")]
        [HttpPost]


        public async Task<ActionResult<Order>> Create([FromBody] UserDTO userDTO)
        {
            var ord = _orderServices.Create(userDTO);
            if (ord != null)
                return ord;
            return BadRequest("Not able to order");

        }


        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
