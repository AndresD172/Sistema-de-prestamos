using Sistema_Prestamos_TI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
    public class Reporte
    {

        //Primary Key
        [Key]
        public int IdReporte { get; set; }

        [Required(ErrorMessage = "Fecha de Creacion del reporte es obligatoria")]
        public DateTime FechaCreacion { get; set; }

        [Required(ErrorMessage = "Descripción del reporte es obligatoria")]
        public string Descripcion { get; set; }

    }
}
