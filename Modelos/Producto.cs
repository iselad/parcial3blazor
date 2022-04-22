using System.ComponentModel.DataAnnotations;
namespace Modelos;

public class Producto
{//para mandar un mensaje si tira un error y esta etiqueta se coloca antes de la propiedad 
    [Required(ErrorMessage = "El campo codigo es Obligatorio")]
    //propiedades 
    public string Codigo { get; set; }
    [Required(ErrorMessage = "El campo Descripcion es Obligatorio")]
    public string Descripcion { get; set; }
    public string Precio { get; set; }
    public string Existencia { get; set; }
    public byte[] Imagen{ get; set; }
}
