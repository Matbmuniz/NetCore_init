using Microsoft.EntityFrameworkCore;

namespace FilmesCRUDRazor.Models
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options)
            : base(options)
        {
            // DEFAULT 
        }

        public DbSet<Filme> Filme {get; set; }
    }
}