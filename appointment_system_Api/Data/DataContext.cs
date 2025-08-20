using appointment_system_Api.Model;
using Microsoft.EntityFrameworkCore;
namespace appointment_system_Api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
        }

        public DbSet<Patienete> Patiente { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
    }
}
