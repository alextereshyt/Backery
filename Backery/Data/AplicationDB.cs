
using Microsoft.EntityFrameworkCore;
using Backery.Models;

namespace Backery.Data
{
    public class ApplicationDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public ApplicationDB(DbContextOptions<ApplicationDB> opt) : base(opt)
        {
            Database.EnsureCreated();
        }
      
    } 
}
