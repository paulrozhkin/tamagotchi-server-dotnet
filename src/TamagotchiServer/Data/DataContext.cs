using Microsoft.EntityFrameworkCore;
using TamagotchiServer.Models;

namespace TamagotchiServer.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}
        
        public DbSet<File> Files { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
    }
}