using System.ComponentModel.DataAnnotations;
namespace Sistema_Prestamos_TI.Models
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }

        //Necesita DataAnnotations
        [Required(ErrorMessage = "Descripcion de departamento es obligatorio")]
        public string Descripcion { get; set; }

        //Estado
        public Boolean estado { get; set; }
    }
}
