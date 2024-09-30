using Sistema_Prestamos_TI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
    public class Prestamo
    {
        //Primary Key
        [Key]
        public int IdPrestamo { get; set; }

        [Required(ErrorMessage = "Fecha de Prestación del equipo es obligatoria")]
        public DateTime FechaPrestacion { get; set; }

        [Required(ErrorMessage = "Fecha de Devolución del equipo es obligatoria")]
        public DateTime FechaDevolucion { get; set; }

        [Required(ErrorMessage = "Estado de Prestacion del equipo es obligatorio")]
        public string EstadoPrestacion { get; set; }



        //Foreing Key 1
        public int IdEquipo { get; set; }

        [ForeignKey("IdEquipo")]
        public virtual Equipo? Equipo { get; set; }

        //Foreing Key 2
        public int IdPerfilTecnico { get; set; }

        [ForeignKey("IdPerfilTecnico")]
        public virtual PerfilTecnico? PerfilTecnico { get; set; }

        //Foreing Key 3
        public int IdPrestatario { get; set; }

        [ForeignKey("IdPrestatario")]
        public virtual Prestatario? Prestatario { get; set; }

    }
}
