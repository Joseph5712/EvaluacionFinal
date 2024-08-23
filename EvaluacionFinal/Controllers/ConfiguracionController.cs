using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EvaluacionFinal.Controllers
{
    public class ConfiguracionController : Controller
    {
        private readonly DatabaseSettings _dbSettings;

        public ConfiguracionController(IOptions<DatabaseSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        public IActionResult Index()
        {
            // Obtener los valores seleccionados desde la sesión
            var motorSeleccionado = HttpContext.Session.GetString("MotorSeleccionado") ?? "MS SQL Server";
            var cadenaSeleccionada = HttpContext.Session.GetString("CadenaSeleccionada") ?? _dbSettings.ConexionMSSql;

            // Pasar los valores a la vista
            _dbSettings.MotorSeleccionado = motorSeleccionado;
            _dbSettings.CadenaSeleccionada = cadenaSeleccionada;

            return View(_dbSettings);
        }

        [HttpPost]
        public IActionResult Index(string motorBaseDatos, string cadenaConexion)
        {
            // Guardar los valores seleccionados en la sesión
            HttpContext.Session.SetString("MotorSeleccionado", motorBaseDatos);
            HttpContext.Session.SetString("CadenaSeleccionada", cadenaConexion);

            ViewBag.Message = "Configuraciones guardadas correctamente en la sesión.";

            return RedirectToAction("Index");
        }
    }
}
