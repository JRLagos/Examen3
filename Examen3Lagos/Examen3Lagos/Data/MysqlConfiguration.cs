namespace Examen3Lagos.Data;

public class MysqlConfiguration
{
    public string CadenaConexion { get; }
    public MysqlConfiguration(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;

    }
}
