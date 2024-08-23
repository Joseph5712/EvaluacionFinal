using EvaluacionFinal.Models;

namespace EvaluacionFinal.Data.Roles
{
    public class RolRepository : IRepository<RolModel>
    {
        private static List<RolModel> roles = new List<RolModel>();

        public IEnumerable<RolModel> ObtenerTodos()
        {
            return roles;
        }

        public RolModel ObtenerPorId(int id)
        {
            return roles.FirstOrDefault(r => r.ID == id);
        }

        public void Agregar(RolModel entidad)
        {
            roles.Add(entidad);
        }

        public void Actualizar(RolModel entidad)
        {
            var rol = ObtenerPorId(entidad.ID);
            if (rol != null)
            {
                rol.Nombre = entidad.Nombre;
                rol.Descripción = entidad.Descripción;
                rol.Estado = entidad.Estado;
            }
        }

        public void Eliminar(int id)
        {
            var rol = ObtenerPorId(id);
            if (rol != null)
            {
                roles.Remove(rol);
            }
        }
    }
}
