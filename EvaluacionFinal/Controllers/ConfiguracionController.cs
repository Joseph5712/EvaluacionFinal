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
            // Pasamos las configuraciones actuales a la vista
            return View(_dbSettings);
        }

        [HttpPost]
        public IActionResult Index(DatabaseSettings settings)
        {
            if (ModelState.IsValid)
            {
                // Aquí podrías guardar las nuevas configuraciones, si fuera necesario
                ViewBag.Message = "Configuraciones guardadas correctamente.";
            }

            return View(settings);
        }
    }
}
