using Microsoft.AspNetCore.Mvc;
using appointment_system_Api.Data;
using appointment_system_Api.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace appointment_system_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController:ControllerBase
    {
        private readonly DataContext _context;

        public DoctorController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetDoctor")]
        public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctor()
        {
            return await _context.Doctor.ToListAsync();
        }

        
    }
}
