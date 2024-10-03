using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
  public class Rol
  {
      [Key]
      public int Id { get; set; }

      [Required(ErrorMessage = "La descripción es obligatoria.")]
      public string Descripcion { get; set; }
  }
}