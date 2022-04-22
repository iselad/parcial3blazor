using Blazor.Interfaces;
using Modelos;
using Blazor.Data;
using Datos.Interfaces;
using Datos.Repositorio;

namespace Blazor.Servicios;
//implementar interfaces
public class UsuarioServicios : IUsuarioServicio
{
    //readonly es solo lectura 
    private readonly MySQLConfiguracion _configuration;
    private IUsuarioRepositorio usuarioRepositorio;
    public UsuarioServicios(MySQLConfiguracion configuracion)
    {
        _configuration = configuracion; 
        usuarioRepositorio= new UsuarioRepositorio(configuracion.CadenaConexion);
    }

    public Task<bool> Actualizar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Eliminar(Usuario usuario)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Usuario>> GetLista()
    {
       return await usuarioRepositorio.GetLista();
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
