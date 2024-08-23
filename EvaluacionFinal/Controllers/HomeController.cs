using EvaluacionFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EvaluacionFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Obtener los valores desde la sesión
            var motorSeleccionado = HttpContext.Session.GetString("MotorSeleccionado") ?? "No seleccionado";
            var cadenaSeleccionada = HttpContext.Session.GetString("CadenaSeleccionada") ?? "No seleccionada";

            // Pasar los valores a la vista mediante ViewData o ViewBag
            ViewData["MotorSeleccionado"] = motorSeleccionado;
            ViewData["CadenaSeleccionada"] = cadenaSeleccionada;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
