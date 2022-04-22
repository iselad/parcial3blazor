using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using Dapper;
namespace Datos.Repositorio;
//Usuramos herencia
//Cuando se quiere heredar de una clase a otra se usa DOS PUNTOS  en public class UsuarioRepositorio
//Ledamos en implementar interfaz

public class UsuarioRepositorio : IUsuarioRepositorio
{
    //nos sirve para almacenar la cadena de conexion 
    private string CadenaConexion;
    //Creamos un costructor
    public UsuarioRepositorio(string cadenaConexion)
    {
        CadenaConexion = cadenaConexion;    
    }
    //Crear un metodo que nos permita conectarnos a MSQL 
    private MySqlConnection Conexion()
    {
        return new MySqlConnection(CadenaConexion);
    }

    //Crea los metodos que ya tenia en interfaz
    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }
     //¨PARA conectar la base de datos
    public  async Task<IEnumerable<Usuario>> GetLista()
    {
       //agregar lo que vamos a devolver 
       IEnumerable<Usuario> Lista= new List<Usuario>();
        //agregamos un Try catch, para capturar las los errores
        try
        {
            //using se utiliza en conexiones (variable conexion)
            using MySqlConnection conexion = Conexion();
            //con await abrimos la conexion y OpenAsync porque estamos trabajando con async
            await conexion.OpenAsync();
            string sql = "SELECT * FROM usuario;";
            Lista = await conexion.QueryAsync<Usuario>(sql);
        }
        catch (Exception ex)
        {
        }
        return Lista;   
    }

    private void ync<T>(string sql)
    {
        throw new NotImplementedException();
    }

    public Task<Usuario> GetPorCodigo(string codigo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Nuevo(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}
