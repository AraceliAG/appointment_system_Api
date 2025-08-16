using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_system_Api.Model
{
    [Table ("Doctor")]
    public class Doctor
    {
        [Key]
        public int NumEmpleado { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Hospital_Name { get; set; }
        public int NumeroCita { get; set; }

    }
}
