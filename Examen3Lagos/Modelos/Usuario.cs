using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Usuario
{
    [Required(ErrorMessage = "El Campo CodigoUsuario Es Obligatorio")]
    public string CodigoUsuario { get; set; }
    [Required(ErrorMessage = "El Campo NombreUsuario Es Obligatorio")]
    public string Nombre { get; set; }
    public string Clave { get; set; }
    [Required(ErrorMessage = "El Campo TipoUsuario Es Obligatorio")]
    public string TipoUsuario { get; set; }
    public bool Estado { get; set; }
}
