using Microsoft.AspNetCore.Mvc;
using PruebaSoporteLogico.Datos;
using PruebaSoporteLogico.Models;

namespace PruebaSoporteLogico.Controllers
{
    public class VinculacionController : Controller
    {

        private readonly ApplicationDbContext _db;
        public VinculacionController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Empleado> lista = _db.Empleado;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Vinculacion vinculacion)
        {
            _db.Vinculacion.Add(vinculacion);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Vinculaciones(int id)
        {
            IEnumerable<Vinculacion> lista = from Vinculacion in _db.Vinculacion where Vinculacion.IdEmpleado_Vinculacion == id select Vinculacion;
            return View(lista);
        }
    }
}
