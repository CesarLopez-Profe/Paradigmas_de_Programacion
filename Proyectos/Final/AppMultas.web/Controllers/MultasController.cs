using AppMultas.web.Servicios;
using Bib_multas.Clases;
using Microsoft.AspNetCore.Mvc;
using System;
using static Bib_multas.Clases.Mayor;
using static Bib_multas.Clases.Menor;

namespace AppMultas.web.Controllers
{
    public class MultasController : Controller
    {
        private static ConductorService _cService = new();
        private static VehiculoService _vService = new();
        private static MultaService _mService = new();
        
       
        public MultasController(ConductorService cService, VehiculoService vService, MultaService mService)
        {
            _cService = cService;
            _vService = vService;
            _mService = mService;
        }
        public IActionResult Index()
        {
            return View(_mService.ObtenerTodas());
        }

        public IActionResult Crear() //get
        {
            ViewBag.Conductores = _cService.ObtenerTodos();
            ViewBag.Vehiculos = _vService.ObtenerTodos();
            return View();
        }

        [HttpPost]
        public IActionResult Crear(string idConductor, string placaVehiculo, string tipoMulta)
        {
            try
            {
                            
                var conductor = _cService.BuscarPorId(idConductor);
                var vehiculo = _vService.BuscarPorPlaca(placaVehiculo);
                
                Random aleat;
                Array arr_multas;

                // Validar selección
                if (string.IsNullOrEmpty(idConductor) || string.IsNullOrEmpty(placaVehiculo) || string.IsNullOrEmpty(tipoMulta))
                {
                    ViewBag.Error = "Debe seleccionar un conductor, vehículo y tipo de multa.";
                    ViewBag.Conductores = _cService.ObtenerTodos();
                    ViewBag.Vehiculos = _vService.ObtenerTodos();
                    return View();
                }

                if (conductor == null || vehiculo == null)
                {
                    ViewBag.Error = "Conductor o Vehículo no encontrados.";
                    ViewBag.Conductores = _cService.ObtenerTodos();
                    ViewBag.Vehiculos = _vService.ObtenerTodos();
                    return View();
                }

                Multa multa;
                aleat = new Random();
                

                if (tipoMulta.Equals("Mayor"))
                {
                    arr_multas = Enum.GetValues(typeof(inf_mayores));
                    multa = new Mayor(conductor, vehiculo, (inf_mayores)arr_multas.GetValue(aleat.Next(arr_multas.Length)));
                    //multa = new Mayor(conductor, vehiculo, Bib_multas.Clases.Mayor.inf_mayores.Manejar_embriagado);
                }

                else
                {
                    arr_multas = Enum.GetValues(typeof(inf_menores));
                    multa = new Menor(conductor, vehiculo, (inf_menores)arr_multas.GetValue(aleat.Next(arr_multas.Length)));
                    //multa = new Menor(conductor, vehiculo, Bib_multas.Clases.Menor.inf_menores.contravía);
                }

                _mService.Agregar(multa);
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
