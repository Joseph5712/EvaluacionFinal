namespace EvaluacionFinal.Builder
{
    public class DatabaseConfiguration
    {
        public string MotorBaseDatos { get; set; }
        public string CadenaConexion { get; set; }
    }

    public class DatabaseConfigurationBuilder : IBuilder<DatabaseConfiguration>
    {
        private DatabaseConfiguration configuration = new DatabaseConfiguration();

        public void SetMotorBaseDatos(string motor)
        {
            configuration.MotorBaseDatos = motor;
        }

        public void SetCadenaConexion(string cadenaConexion)
        {
            configuration.CadenaConexion = cadenaConexion;
        }

        public DatabaseConfiguration Build()
        {
            return configuration;
        }
    }
}
