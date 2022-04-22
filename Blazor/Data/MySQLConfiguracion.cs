namespace Blazor.Data;

//capturar la cadena de conexion y mandarla al proyecto de datos
public class MySQLConfiguracion
{
    public string CadenaConexion { get; }
    public MySQLConfiguracion(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;    
    }

}
