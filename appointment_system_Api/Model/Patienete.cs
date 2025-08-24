using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_system_Api.Model
{
    [Table ("Patiente")]
    public class Patienete
    {
        [Key]
        public string Number_SS { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public long Phone { get; set; }
        public long Number_Appointment { get; set; }
        public string CURP { get; set; }
        public string Name_Hospital { get; set; }

    }
}
