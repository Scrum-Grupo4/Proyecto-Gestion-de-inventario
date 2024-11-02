using Microsoft.EntityFrameworkCore;

public class GestionContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Productos> Producto { get; set; }

    public GestionContext(DbContextOptions<GestionContext> options) : base(options)
    {
    }
}
