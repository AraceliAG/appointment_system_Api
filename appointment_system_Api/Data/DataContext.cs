using Microsoft.EntityFrameworkCore;
namespace appointment_system_Api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
        }

        public DbSet<Model.Patienete> Patientes { get; set; }
        public DbSet<Model.Doctor> Doctors { get; set; }
        public DbSet<Model.Appointment> Appointments { get; set; }
    }
}
