using Modelos;

namespace Datos.Interfaces;

public interface IUsuarioRepositorio
{
    //agregamos los metodos que nos ayudan a manipular la tabla usuario
    //vamos a trabajar con programacion asincrona
 
    Task<bool> Nuevo(Usuario usuario);    //Crear metodo para nuevo 
    Task <bool>Actualizar (Usuario usuario); //Actualizar
    Task<bool>Eliminar(Usuario usuario); //Eliminar
    Task<IEnumerable<Usuario>> GetLista();   
    Task<Usuario> GetPorCodigo( string codigo);    
    
}
