using Microsoft.AspNetCore.Mvc;
using Sistema_Prestamos_TI.Datos;
using Sistema_Prestamos_TI.Models;

namespace Sistema_Prestamos_TI.Controllers
{
    public class SeccionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SeccionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Seccion> lista = _db.seccion;

            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Crear(Seccion seccion)
        {
            if (ModelState.IsValid)
            {
                _db.seccion.Add(seccion);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(seccion);
        }

        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.seccion.Find(Id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Editar(Seccion seccion)
        {
            if (ModelState.IsValid)
            {
                _db.seccion.Update(seccion);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(seccion);
        }

        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.seccion.Find(Id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Eliminar(Seccion seccion)
        {
            if (seccion == null)
            {
                return NotFound();
            }

            _db.seccion.Remove(seccion);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
