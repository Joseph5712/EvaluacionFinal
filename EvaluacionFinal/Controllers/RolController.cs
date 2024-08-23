using EvaluacionFinal.Data.Roles;
using EvaluacionFinal.Helpers;
using EvaluacionFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionFinal.Controllers
{
    public class RolController : Controller
    {
        private readonly RolHelper _rolHelper;

        public RolController()
        {
            _rolHelper = new RolHelper();
        }

        public IActionResult Index()
        {
            var roles = _rolHelper.ObtenerTodosLosRoles();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RolModel rol)
        {
            if (ModelState.IsValid)
            {
                _rolHelper.CrearRol(rol);
                return RedirectToAction("Index");
            }
            return View(rol);
        }

        public IActionResult Details(int id)
        {
            var rol = _rolHelper.ObtenerRolPorId(id);
            if (rol == null)
            {
                return NotFound();
            }
            return View(rol);
        }
    }
}
