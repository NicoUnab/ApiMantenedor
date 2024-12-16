using Mantenedor.Data;
using Mantenedor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mantenedor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MantenedorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MantenedorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("tipos-reporte")]
        public async Task<IActionResult> GetTiposReporte()
        {
            var tipos = await _context.TiposReporte.ToListAsync();
            return Ok(tipos);
        }

        [HttpPost("tipos-reporte")]
        public async Task<IActionResult> CrearTipoReporte(TipoReporte tipoReporte)
        {
            _context.TiposReporte.Add(tipoReporte);
            await _context.SaveChangesAsync();
            return Ok(tipoReporte);
        }

        [HttpGet("estados-reporte")]
        public async Task<IActionResult> GetEstadosReporte()
        {
            var estados = await _context.EstadosReporte.ToListAsync();
            return Ok(estados);
        }

        [HttpPost("estados-reporte")]
        public async Task<IActionResult> CrearEstadoReporte(EstadoReporte estadoReporte)
        {
            _context.EstadosReporte.Add(estadoReporte);
            await _context.SaveChangesAsync();
            return Ok(estadoReporte);
        }
    }
}
