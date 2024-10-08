using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
    public class PerfilTecnico
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        public string PrimerApellido { get; set; }
        
        [Required(ErrorMessage = "El segundo apellido es obligatorio")]
        public string SegundoApellido { get; set; }
        
        [Required(ErrorMessage = "El número de identificación es obligatorio")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "La dirección de correo electrónico es obligatorio")]
        public string CorreoProfesional { get; set; }
    }
}