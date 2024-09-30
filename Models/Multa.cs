using Sistema_Prestamos_TI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
    public class Multa
    {

        //Primary Key
        [Key]
        public int IdMulta { get; set; }

        [Required(ErrorMessage = "Fecha de Creación de la multa es obligatoria")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "Descripción de la multa es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado de la multa es obligatorio")]
        public string EstadoMulta { get; set; }

        //Foreing Key
        public int IdPrestamo { get; set; }

        [ForeignKey("IdPrestamo")]
        public virtual Prestamo? Prestamo { get; set; }

    }
}
