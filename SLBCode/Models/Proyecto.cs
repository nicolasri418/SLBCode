using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace SLBCode.Models
{
    public class ProyectoContext : DbContext
    {
        public ProyectoContext(DbContextOptions<ProyectoContext> options)
            : base(options)
        {
        }
        public DbSet<Proyecto> ProyectoItems { get; set; }
    }
    public class Proyecto
    {
        public int id { get; set; }
        public string nombreProyecto { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }

    }
}
