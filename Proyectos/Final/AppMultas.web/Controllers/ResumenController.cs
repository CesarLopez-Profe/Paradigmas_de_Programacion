using AppMultas.web.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace AppMultas.web.Controllers
{
    public class ResumenController : Controller
    {
        private readonly MultaService _multaService;

        public ResumenController(MultaService multaService)
        {
            _multaService = multaService;
        }

        public IActionResult Index()
        {
            var resumenConductores = _multaService.ResumenPorConductor();
            var resumenTipo = _multaService.ContarPorTipo();

            ViewBag.ResumenConductores = resumenConductores;
            ViewBag.Mayores = resumenTipo.mayor;
            ViewBag.Menores = resumenTipo.menor;
            ViewBag.Total = _multaService.TotalRecaudado();

            return View();
            
        }
    }
}
