using Microsoft.AspNetCore.Mvc;
using OrderItemDetailAPI.Models;
using OrderItemDetailAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderItemDetailAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemToppingController : ControllerBase
    {
        private readonly ItemToppingService _itemToppingService;

        public ItemToppingController(ItemToppingService service)
        {
            _itemToppingService = service;
        }
        [HttpGet]
        public IEnumerable<ItemTopping> Get()
        {
            var pizzas = _itemToppingService.AllItem();
            return pizzas;
        }
        // GET: api/Toppings1
        [HttpGet("{id}")]
        public IEnumerable<ItemTopping> GetItems(int item)
        {
            return _itemToppingService.GetItemToppings(item);
        }

        [HttpPost]
        public async Task<ActionResult<ItemTopping>> AddItemTopping([FromBody] ItemTopping item)
        {
            var itemTopping = _itemToppingService.AddItem(item);
            if (itemTopping != null)
                return itemTopping;
            return BadRequest("Not able to add ItemTopping");


        }





    }
}
