using EvaluacionFinal.Data.Usuarios;
using EvaluacionFinal.Models;

namespace EvaluacionFinal.Helpers
{
    public class UsuarioHelper
    {
        private readonly UsuarioRepository _usuarioRepository;

        public UsuarioHelper()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public IEnumerable<UsuarioModel> ObtenerTodosLosUsuarios()
        {
            return _usuarioRepository.ObtenerTodos();
        }

        public UsuarioModel ObtenerUsuarioPorId(int id)
        {
            return _usuarioRepository.ObtenerPorId(id);
        }

        public void CrearUsuario(UsuarioModel usuario)
        {
            _usuarioRepository.Agregar(usuario);
        }

        public void ActualizarUsuario(UsuarioModel usuario)
        {
            _usuarioRepository.Actualizar(usuario);
        }

        public void EliminarUsuario(int id)
        {
            _usuarioRepository.Eliminar(id);
        }
    }
}
