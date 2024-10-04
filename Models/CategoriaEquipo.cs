using System.ComponentModel.DataAnnotations;

namespace Sistema_Prestamos_TI.Models
{
    public class CategoriaEquipo
    {
        // Primary key
        [Key]
        public int id { get; set; }

        //No puede ser null
        [Required(ErrorMessage = "La descripción del equipo es obligatoria")]
        public string descripcion { get; set; }

        //Estado
        public Boolean estado { get; set; }
    }
}
