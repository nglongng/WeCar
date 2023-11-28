

using Microsoft.EntityFrameworkCore;

namespace WeCar.Controller
{
    internal class WeCarDbContext: DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-03KCA0G;Database=wecar;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<CarTypes> CarTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Fuels> Fuels { get; set; }
        public DbSet<Schedules> Schedules { get; set; }
        public DbSet<Service> Services { get; set; }


    }
}
