using Bib_multas.Clases;
using Microsoft.AspNetCore.Mvc;
using AppMultas.web.Servicios;

namespace AppMultas.web.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly VehiculoService _service;

        public VehiculosController(VehiculoService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.ObtenerTodos());
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(string placa, string marca, string modelo, DateTime ano)
        {
            try
            {
                var nuevo = new Vehiculo(placa, marca, modelo, ano);
                _service.Agregar(nuevo);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }
        }
    }
}
