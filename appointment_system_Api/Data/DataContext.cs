using Microsoft.EntityFrameworkCore;
namespace appointment_system_Api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
        }

        public DbSet<Model.Patienete> Patiente { get; set; }
        public DbSet<Model.Doctor> Doctor { get; set; }
        public DbSet<Model.Appointment> Appointment { get; set; }
    }
}
