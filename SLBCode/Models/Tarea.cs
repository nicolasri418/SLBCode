using System;
using Microsoft.EntityFrameworkCore;

namespace SLBCode.Models
{
    public class TareaContext : DbContext
    {
        public TareaContext(DbContextOptions<TareaContext> options)
            : base(options)
        {
        }
        public DbSet<Tarea> TareasItems { get; set; }
    }
    public class Tarea
    {
        public int ID { get; set; }
        public string nombreTarea { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaEjecucion { get; set; }
    }
}
