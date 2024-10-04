using System.ComponentModel.DataAnnotations;

namespace Sistema_Prestamos_TI.Models
{
    public class Usuario
    {        
        // Primary key
        [Key]
        public int Id { get; set; }

        //Nombre no puede ser null
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        public string nombreUsuario { get; set; }

        //Correo no puede ser null
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string correo { get; set; }

        //Contraseña no puede ser null
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string contrasena { get; set; }

        //Estado
        public Boolean estado { get; set; }
    }
}
