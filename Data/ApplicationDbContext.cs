using Microsoft.EntityFrameworkCore;
using RelatorioCliente.Models;

namespace RelatorioCliente.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<ClientesModel> Clientes { get; set; }
    }
}
