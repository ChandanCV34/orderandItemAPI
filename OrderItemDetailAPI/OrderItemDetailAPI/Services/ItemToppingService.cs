using OrderItemDetailAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemDetailAPI.Services
{
    public class ItemToppingService
    {
        private readonly pizzaContext _pizzaContext;

        public ItemToppingService(pizzaContext context)
        {
            _pizzaContext = context;
        }
        public ICollection<ItemTopping> AllItem()
        {
            IList<ItemTopping> item;
            item = _pizzaContext.ItemToppings.ToList();
            return item;
        }
        public List<ItemTopping> GetItemToppings(int item)
        {
            try
            {
                List<ItemTopping> itemToppings = _pizzaContext.ItemToppings.ToList();
                return itemToppings.Where(t=>t.ItemNumber == item).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public ItemTopping AddItem(ItemTopping item)
        {
            _pizzaContext.ItemToppings.Add(item);
            _pizzaContext.SaveChanges();
            return item;
        }
    }
}
