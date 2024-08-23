namespace EvaluacionFinal.Models
{
    public class UsuarioModel
    {
        public int ID { get; set; }
        public string? NombreUsuario { get; set; }
        public string? NombreCompleto { get; set; }
        public int Edad { get; set; }
        public string? Correo { get; set; }
        public int RolID { get; set; }

        // Propiedad de navegación
        public RolModel Rol { get; set; }
    }
}
