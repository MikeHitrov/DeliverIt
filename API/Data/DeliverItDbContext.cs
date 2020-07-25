namespace DeliverIt.Data
{
    using Microsoft.EntityFrameworkCore;

    public class DeliverItDbContext : DbContext
    {
         public static string DbConnectionString = "Server=localhost; Database=DeliverItDb; Trusted_Connection=True;";

        public DeliverItDbContext(DbContextOptions<DeliverItDbContext> options)
        : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }  
        public DbSet<Meal> Meals { get; set; } 
        public DbSet<Order> Orders { get; set; } 
        public DbSet<Image> Images { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}