using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SohatNotebook.Entities.DbSet;

namespace SohatNotebook.DataService.Data
{
    public class AppDbContext : IdentityDbContext
    {
        // al heredar de IdentitiyDbContext se crearan todas las tablas tablas requeridas en la base de datos
        // que requieran Identity como los roles de usuarios de asp .net core
        public virtual DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
    }
}
