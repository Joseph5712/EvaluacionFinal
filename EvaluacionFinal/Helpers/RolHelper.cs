using EvaluacionFinal.Data.Roles;
using EvaluacionFinal.Models;

namespace EvaluacionFinal.Helpers
{
    public class RolHelper
    {
        private readonly RolRepository _rolRepository;

        public RolHelper()
        {
            _rolRepository = new RolRepository();
        }

        public IEnumerable<RolModel> ObtenerTodosLosRoles()
        {
            return _rolRepository.ObtenerTodos();
        }

        public RolModel ObtenerRolPorId(int id)
        {
            return _rolRepository.ObtenerPorId(id);
        }

        public void CrearRol(RolModel rol)
        {
            _rolRepository.Agregar(rol);
        }

        public void ActualizarRol(RolModel rol)
        {
            _rolRepository.Actualizar(rol);
        }

        public void EliminarRol(int id)
        {
            _rolRepository.Eliminar(id);
        }
    }
}
