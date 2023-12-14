using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Data
{
    public class VehicleContext : DbContext
    {

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=teste2;uid=root;pwd=123456;",
                    new MySqlServerVersion(new Version(8, 0, 21))); 
            }
        }
    }
}
