using appointment_system_Api.Data;
using appointment_system_Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace appointment_system_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatienteController:ControllerBase
    {
        private readonly DataContext _context;

        public PatienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("GetPatiente")]
        public async Task<ActionResult<IEnumerable<Patienete>>> GetPatiente()
        {
            return await _context.Patiente.ToListAsync();
        }

    }
}
