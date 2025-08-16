using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_system_Api.Model
{
    [Table ("Appointment")]
    public class Appointment
    {
        [Key]
        public int id_appointment { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
    }
}
