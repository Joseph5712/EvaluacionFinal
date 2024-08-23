namespace EvaluacionFinal.Builder
{
    public interface IBuilder<T>
    {
        void SetMotorBaseDatos(string motor);
        void SetCadenaConexion(string cadenaConexion);
        T Build();
    }
}
