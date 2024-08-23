namespace EvaluacionFinal
{
    public class DatabaseSettings
    {
        public string ConexionMSSql { get; set; }
        public string ConexionPgSql { get; set; }
        public string ConexionMySql { get; set; }

        // Propiedades para la selección visual en la vista
        public string MotorSeleccionado { get; set; }
        public string CadenaSeleccionada { get; set; }
    }
}
