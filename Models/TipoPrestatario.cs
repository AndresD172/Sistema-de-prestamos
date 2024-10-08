using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Prestamos_TI.Models
{
    public class TipoPrestatario
    {
        internal IQueryable<SelectListItem> prestatarioLista;

        [Key]
        public int Id { get; set; }

        public int PrestatarioId { get; set; }

        [ForeignKey("PrestatarioId")]
        public virtual Prestatario? Prestatario { get; set; }

        public int SeccionId { get; set; }

        [ForeignKey("SeccionId")]
        public virtual Seccion? Seccion { get; set; }

        public int EspecialidadId { get; set; }

        [ForeignKey("EspecialidadId")]
        public virtual Especialidad? Especialidad { get; set; }

        public int DepartamentoId { get; set; }

        [ForeignKey("DepartamentoId")]
        public virtual Departamento? Departamento { get; set; }

        public int InstitucionId { get; set; }

        [ForeignKey("InstitucionId")]
        public virtual Institucion? Institucion { get; set; }

        //Estado
        public Boolean Estado { get; set; }
    }
}
