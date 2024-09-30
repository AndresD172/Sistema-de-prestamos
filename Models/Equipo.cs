using Sistema_Prestamos_TI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
    public class Equipo
    {
        //Primary Key
        [Key]
        public int IdEquipo { get; set; }

        [Required(ErrorMessage = "Marca del equipo es obligatorio")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Modelo del equipo es obligatorio")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Numero de serie del equipo es obligatorio")]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "Descripcion del equipo es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Estado del equipo es obligatorio")]
        public string EstadoEquipo { get; set; }
/*
        //Foreing Key
        public int IdCategoriaEquipo { get; set; }

        [ForeignKey("IdCategoriaEquipo")]
        public virtual CategoriaEquipo? CategoriaEquipo { get; set; }
*/
    }
}
