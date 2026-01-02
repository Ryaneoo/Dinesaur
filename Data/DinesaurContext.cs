using Dinesaur.Configurations.Entities;
using Dinesaur.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Dinesaur.Data
{
    public class DinesaurContext(DbContextOptions<DinesaurContext> options) : IdentityDbContext<DinesaurUser>(options)
    {
        public DbSet<Dinesaur.Domain.DinesaurUserModel> DinesaurUser { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Food> Food { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Menu> Menu { get; set; } = default!;
        public DbSet<Dinesaur.Domain.PreOrder> PreOrder { get; set; } = default!;
        public DbSet<Dinesaur.Domain.PreOrderItem> PreOrderItem { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Reservation> Reservation { get; set; } = default!;

        public DbSet<Dinesaur.Domain.Restaurant> Restaurant { get; set; } = default!;
        public DbSet<Dinesaur.Domain.Review> Review { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DinesaurUserSeeding());
            modelBuilder.ApplyConfiguration(new FoodSeeding());
            modelBuilder.ApplyConfiguration(new MenuSeeding());
            modelBuilder.ApplyConfiguration(new PreOrderItemSeeding());
            modelBuilder.ApplyConfiguration(new PreorderSeeding());
            modelBuilder.ApplyConfiguration(new ReservationSeeding());
            modelBuilder.ApplyConfiguration(new RestaurantSeeding());
            modelBuilder.ApplyConfiguration(new ReviewsSeeding());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());


        }

    }
}
