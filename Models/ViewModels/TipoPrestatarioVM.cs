using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sistema_Prestamos_TI.Models.ViewModels
{
    public class TipoPrestatarioVM
    {
        public TipoPrestatario tipoPrestatario { get; set; }

        public IEnumerable<SelectListItem>? prestatarioLista { get; set; }

        public IEnumerable<SelectListItem>? seccionLista { get; set; }

        public IEnumerable<SelectListItem>? departamentoLista { get; set; }

        public IEnumerable<SelectListItem>? especialidadLista { get; set; }

        public IEnumerable<SelectListItem>? institucionLista { get; set; }
    }
}
