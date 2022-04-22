
using Blazor.Interfaces;
using Microsoft.AspNetCore.Components;


namespace Blazor.Pages.Usuarios;


partial class Usuarios
{
    [Inject] private IUsuarioServicio _usuarioServicios { get; set; }
    private IEnumerable<Usuario> Usuarioslista { get; set; }
    
  //  protected override Task OnInitializedAsync()
  //  {

   // }
}
