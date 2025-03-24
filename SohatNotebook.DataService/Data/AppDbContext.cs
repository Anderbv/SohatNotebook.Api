using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SohatNotebook.DataService.Data
{
    public class AppDbContext: IdentityDbContext
    {
        // al heredar de IdentitiyDbContext se crearan todas las tablas tablas requeridas en la base de datos
        // que requieran Identity como los roles de usuarios de asp .net core

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
    }
}
