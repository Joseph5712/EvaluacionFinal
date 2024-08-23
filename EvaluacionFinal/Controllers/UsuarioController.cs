using EvaluacionFinal.Data.Usuarios;
using EvaluacionFinal.Helpers;
using EvaluacionFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EvaluacionFinal.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioHelper _usuarioHelper;

        public UsuarioController()
        {
            _usuarioHelper = new UsuarioHelper();
        }
        
        public IActionResult Index()
        {
            var usuarios = _usuarioHelper.ObtenerTodosLosUsuarios();
            return View(usuarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioHelper.CrearUsuario(usuario);
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        public IActionResult Details(int id)
        {
            var usuario = _usuarioHelper.ObtenerUsuarioPorId(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
    }
}
