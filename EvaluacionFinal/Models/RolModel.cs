namespace EvaluacionFinal.Models
{
    public class RolModel
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Descripción { get; set; }
        public bool Estado { get; set; }

        // Propiedad de navegación inversa
        public List<UsuarioModel> Usuarios { get; set; }
    }
}
