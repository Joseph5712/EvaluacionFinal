namespace EvaluacionFinal.Data
{
    public class DatabaseFactory
    {
        public static string CrearFabrica(string motorBaseDatos)
        {
            switch (motorBaseDatos)
            {
                case "MSSql":
                    return "Simulación: SQL Server seleccionado";
                case "PgSql":
                    return "Simulación: PostgreSQL seleccionado";
                case "MySql":
                    return "Simulación: MySQL seleccionado";
                default:
                    throw new ArgumentException("Motor de base de datos no soportado");
            }
        }
    }
}
