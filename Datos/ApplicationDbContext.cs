using Microsoft.EntityFrameworkCore;
using Sistema_Prestamos_TI.Models;

namespace Sistema_Prestamos_TI.Datos
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Aca se agregan todos los modelos para las respectivas tablas de la BD

        public DbSet<Equipo> equipo { get; set; }
        public DbSet<Prestamo> prestamo { get; set; }
        public DbSet<Multa> multa { get; set; }
        public DbSet<Reporte> reporte { get; set; }

    }
}
