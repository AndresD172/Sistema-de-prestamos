using System.ComponentModel.DataAnnotations;

namespace Sistema_Prestamos_TI.Models
{
    public class Especialidad
    {
        // Primary key
        [Key]
        public int id { get; set; }

        //No puede ser null
        [Required(ErrorMessage = "El nombre de especialidad es obligatorio")]
        public string nombre { get; set; }

        //Estado
        public Boolean estado { get; set; }
    }
}
