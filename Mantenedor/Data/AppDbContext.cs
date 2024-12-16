using Mantenedor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mantenedor.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TipoReporte> TiposReporte { get; set; }
        public DbSet<EstadoReporte> EstadosReporte { get; set; }
    }
}
