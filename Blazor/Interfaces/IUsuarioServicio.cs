using Modelos; 
namespace Blazor.Interfaces;

public interface IUsuarioServicio
{
    Task<bool> Nuevo(Usuario usuario);    //Crear metodo para nuevo 
    Task<bool> Actualizar(Usuario usuario); //Actualizar
    Task<bool> Eliminar(Usuario usuario); //Eliminar
    Task<IEnumerable<Usuario>> GetLista();
    Task<Usuario> GetPorCodigo(string codigo);
}
