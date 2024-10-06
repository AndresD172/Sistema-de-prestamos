using Microsoft.AspNetCore.Mvc;
using Sistema_Prestamos_TI.Datos;
using Sistema_Prestamos_TI.Models;

namespace Sistema_Prestamos_TI.Controllers
{
    public class PrestatarioController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PrestatarioController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Prestatario> lista = _db.prestatario;

            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Prestatario prestatario)
        {
            if (ModelState.IsValid)
            {
                _db.prestatario.Add(prestatario);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(prestatario);
        }

        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.prestatario.Find(Id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Prestatario prestatario)
        {
            if (ModelState.IsValid)
            {
                _db.prestatario.Update(prestatario);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(prestatario);
        }

        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            var obj = _db.prestatario.Find(Id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Prestatario prestatario)
        {
            if (prestatario == null)
            {
                return NotFound();
            }

            _db.prestatario.Remove(prestatario);
            _db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }

}
