using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Sistema_Prestamos_TI.Models
{
    public class Prestatario
    {
        [Key]
        public int Id { get; set; }

        //Necesita DataAnnotations
        [Required(ErrorMessage = "Nombre de Prestatario es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Primer apellido de Prestatario es obligatorio")]
        public string PrimerApellido { get; set; }

        [Required(ErrorMessage = "Segundo apellido de Prestatario es obligatorio")]
        public string SegundoApellido { get; set; }

        [Required(ErrorMessage = "Identificacion de Prestatario es obligatorio")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "Correo de Prestatario es obligatorio")]
        public string Correo { get; set; }

        //Estado
        public Boolean estado { get; set; }


    }
}
