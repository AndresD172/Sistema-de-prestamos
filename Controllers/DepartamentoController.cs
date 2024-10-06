using Microsoft.AspNetCore.Mvc;
using Sistema_Prestamos_TI.Datos;
using Sistema_Prestamos_TI.Models;

namespace Sistema_Prestamos_TI.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DepartamentoController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Departamento> lista = _db.departamento;

            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Crear(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                _db.departamento.Add(departamento);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(departamento);
        }

        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.departamento.Find(Id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Editar(Departamento departamento)
        {
            if (ModelState.IsValid)//valida que el modelo tenga datos
            {
                _db.departamento.Update(departamento);//Actualiza el objeto que recibimos por parametro
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));//Envia los datos al index
            }

            return View(departamento);
        }

        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.departamento.Find(Id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Eliminar(Departamento departamento)
        {

            if (departamento == null)
            {
                return NotFound();
            }

            _db.departamento.Remove(departamento);//Elimina el objeto que recibimos por parametro
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));//Envia los datos al index
        }
    }
}
