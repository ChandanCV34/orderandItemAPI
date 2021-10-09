using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemDetailAPI.Models
{
    public class pizzaContext : DbContext
    {
        public pizzaContext()
        {
        }
        public pizzaContext(DbContextOptions<pizzaContext> options) : base(options)
        {

        }

        public virtual DbSet<ItemTopping> ItemToppings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemTopping>()
                .HasKey(o => new { o.ItemNumber, o.ToppingNumber });
        }
    }
}
