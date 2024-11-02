using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public int IdUsuario {get; set; }
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string Rol { get; set; }
}

public class Productos
{
    [Key]
    public int IdProducto {get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double Precio { get; set; }
    public string Imagen { get; set; }
}
