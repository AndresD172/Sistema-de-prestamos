using System.ComponentModel.DataAnnotations;
namespace Sistema_Prestamos_TI.Models
{
    public class Seccion
    {
        [Key]
        public int Id { get; set; }

        //Necesita DataAnnotations
        [Required(ErrorMessage = "Descripcion de seccion es obligatorio")]
        public string Descripcion { get; set; }

        //Estado
        public Boolean estado { get; set; }
    }
}
