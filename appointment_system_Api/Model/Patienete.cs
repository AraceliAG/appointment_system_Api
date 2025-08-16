using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appointment_system_Api.Model
{
    [Table ("Patiente")]
    public class Patienete
    {
        [Key]
        public int id_patient { get; set; }
        public int Number_SS { get; set; }
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public int Phone { get; set; }
        public int Number_Appointment { get; set; }
        public string CURP { get; set; }
        public string Name_Hospital { get; set; }

    }
}
