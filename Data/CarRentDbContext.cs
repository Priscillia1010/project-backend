using Microsoft.EntityFrameworkCore;
using CarRent_Backend.Model;

namespace CarRent_Backend.Data
{
    public class CarRentDbContext : DbContext
    {
        public CarRentDbContext(DbContextOptions<CarRentDbContext> options) : base(options)
        {

        }

        public DbSet<MsCar> MsCar { get; set; }
        public DbSet<MsCarImage> MsCarImage { get; set; }
        public DbSet<MsCustomer> MsCustomer { get; set; }
        public DbSet<TrRental> TrRental { get; set; }
        public DbSet<TrPayment> TrPayment { get; set; }
    }
}
