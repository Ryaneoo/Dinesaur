using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dinesaur.Domain;

namespace Dinesaur.Data
{
    public class DinesaurContext : DbContext
    {
        public DinesaurContext (DbContextOptions<DinesaurContext> options)
            : base(options)
        {
        }

        public DbSet<Dinesaur.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Food> Food { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Menu> Menu { get; set; } = default!;
        public DbSet<Dinesaur.Domain.PreOrder> PreOrder { get; set; } = default!;
        public DbSet<Dinesaur.Domain.PreOrderItem> PreOrderItem { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Reservation> Reservation { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Review> Review { get; set; } = default!;
        
    }
}
