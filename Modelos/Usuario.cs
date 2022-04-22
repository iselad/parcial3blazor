using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    //para mandar un mensaje si tira un error y esta etiqueta se coloca antes de la propiedad 
    [Required(ErrorMessage ="El campo codigo es Obligatorio")]
   
    //propiedades
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El campo Nombre es Obligatorio")]
    public string Nombre { get; set; }
    [Required(ErrorMessage = "El campo Rol es Obligatorio")]
    public string Rol { get; set; }
    public string Clave { get; set; }
    public bool EstaActivo { get; set; }




}
