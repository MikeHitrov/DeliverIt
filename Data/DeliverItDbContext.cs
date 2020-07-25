namespace DeliverIt.Data
{
    using Microsoft.EntityFrameworkCore;

    public class DeliverItDbContext : DbContext
    {
        public DeliverItDbContext(DbContextOptions<DeliverItDbContext> options)
        : base(options)
      { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }  
        public DbSet<Meal> Meals { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<Image> Images { get; set; } 
    }
}