using EvaluacionFinal.Models;

namespace EvaluacionFinal.Data.Usuarios
{
    public class UsuarioRepository : IRepository<UsuarioModel>
    {
        private static List<UsuarioModel> usuarios = new List<UsuarioModel>();

        public IEnumerable<UsuarioModel> ObtenerTodos()
        {
            return usuarios;
        }

        public UsuarioModel ObtenerPorId(int id)
        {
            return usuarios.FirstOrDefault(u => u.ID == id);
        }

        public void Agregar(UsuarioModel entidad)
        {
            usuarios.Add(entidad);
        }

        public void Actualizar(UsuarioModel entidad)
        {
            var usuario = ObtenerPorId(entidad.ID);
            if (usuario != null)
            {
                usuario.NombreUsuario = entidad.NombreUsuario;
                usuario.NombreCompleto = entidad.NombreCompleto;
                usuario.Edad = entidad.Edad;
                usuario.Correo = entidad.Correo;
                usuario.RolID = entidad.RolID;
            }
        }

        public void Eliminar(int id)
        {
            var usuario = ObtenerPorId(id);
            if (usuario != null)
            {
                usuarios.Remove(usuario);
            }
        }
    }
}
