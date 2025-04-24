using AppMultas.web.Servicios;
using Bib_multas.Clases;
using Microsoft.AspNetCore.Mvc;

namespace AppMultas.web.Controllers
{
    public class ConductoresController : Controller
    {
        private readonly ConductorService _service;

        // ✅ Este constructor inyecta la instancia registrada en Program.cs
        public ConductoresController(ConductorService service)
        {
            _service = service;
        }

        public IActionResult Index()//HtttpGet
        {
            var lista = _service.ObtenerTodos(); // ✅ devuelve una lista (aunque esté vacía)
            return View(lista);

        }

        public IActionResult Crear() //HttpGet
        {
            return View(); //Devuelve una lista vacía
        }

        [HttpPost] //HttpPost
        public IActionResult Crear(string tipoId, string id, string nombre, byte edad)
        {
            try
            {
                var tipo = Enum.Parse<Conductor.tipos_id>(tipoId);
                var nuevo = new Conductor(tipo, id, nombre, edad); //instancia un objeto conductor en nuevo
                _service.Agregar(nuevo); //agrega el conductor a la lista de conductores
                return RedirectToAction("Index"); //Devuelve a la página index
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
    
}
