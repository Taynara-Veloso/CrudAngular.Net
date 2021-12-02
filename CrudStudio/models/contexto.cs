using Microsoft.EntityFrameworkCore;

namespace CrudStudio.models 
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            
        }
    }
}
