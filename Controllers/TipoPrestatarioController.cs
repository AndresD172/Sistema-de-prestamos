using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.ProjectModel;
using NuGet.Protocol.Plugins;
using Sistema_Prestamos_TI.Datos;
using Sistema_Prestamos_TI.Models;
using Sistema_Prestamos_TI.Models.ViewModels;

namespace Sistema_Prestamos_TI.Controllers
{
    public class TipoPrestatarioController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TipoPrestatarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TipoPrestatario> lista = _db.tipoPrestatario
                .Include(p => p.Prestatario)
                .Include(d => d.Departamento)
                .Include(s => s.Seccion)
                .Include(e => e.Especialidad)
                .Include(i => i.Institucion);

            return View(lista);
        }

        public IActionResult Upsert(int? Id)
        {
            TipoPrestatarioVM tipoPrestatarioVM = new TipoPrestatarioVM()
            {
                tipoPrestatario = new TipoPrestatario(),
                prestatarioLista = _db.prestatario.Select(p => new SelectListItem
                {
                    Text = p.Nombre,
                    Value = p.Id.ToString()
                }),
                departamentoLista = _db.departamento.Select(d => new SelectListItem
                {
                    Text = d.Descripcion,
                    Value = d.Id.ToString()
                }),
                seccionLista = _db.seccion.Select(s => new SelectListItem
                {
                    Text = s.Descripcion,
                    Value = s.Id.ToString()
                }),
                especialidadLista = _db.especialidad.Select(e => new SelectListItem
                {
                    Text = e.Descripcion,
                    Value = e.Id.ToString()
                }),
                institucionLista = _db.institucion.Select(i => new SelectListItem
                {
                    Text = i.Descripcion,
                    Value = i.Id.ToString()
                })
            };

            if (Id == null)
            {
                return View(tipoPrestatarioVM);
            }
            else
            {
                tipoPrestatarioVM.tipoPrestatario = _db.tipoPrestatario.Find(Id);

                if (tipoPrestatarioVM == null)
                {
                    return NotFound();
                }

                return View(tipoPrestatarioVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(TipoPrestatarioVM tipoPrestatarioVM)
        {
            if (ModelState.IsValid)
            {
                if (tipoPrestatarioVM.tipoPrestatario.Id == 0)
                {
                    _db.tipoPrestatario.Add(tipoPrestatarioVM.tipoPrestatario);
                }
                else
                {
                    _db.tipoPrestatario.Update(tipoPrestatarioVM.tipoPrestatario);
                }

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoPrestatarioVM);
        }

        public IActionResult Eliminar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            TipoPrestatario tipoPrestatario = _db.tipoPrestatario
                .Include(p => p.Prestatario)
                .Include(d => d.Departamento)
                .Include(s => s.Seccion)
                .Include(e => e.Especialidad)
                .Include(i => i.Institucion)
                .FirstOrDefault(tp => tp.Id == id);

            if (tipoPrestatario == null)
            {
                return NotFound();
            }

            return View(tipoPrestatario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Eliminar(TipoPrestatario tipoPrestatario)
        {
            if (tipoPrestatario == null)
            {
                return NotFound();
            }

            _db.tipoPrestatario.Remove(tipoPrestatario);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
}
