using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using appointment_system_Api.Data;
using appointment_system_Api.Model;

namespace appointment_system_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly DataContext _context;

        public AppointmentController(DataContext context)
        {
            _context = context;
        }


        [HttpGet("GetAppointment")]
        public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointment()
        {
            return await _context.Appointment.ToListAsync();
        }

        [HttpPost("CreateAppoinment")]
        public async Task<ActionResult<Appointment>> CreateAppoinment(Appointment appointment)
        {
            if (appointment == null)
            {
                return BadRequest("Appointment cannot be null");
            }

            _context.Appointment.Add(appointment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAppointment), new { id = appointment.id_appointment }, appointment);
        }


    }
}
