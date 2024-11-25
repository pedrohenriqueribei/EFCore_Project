using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce
{
    public class eCommerceContext : DbContext
    {

        #region Configuration
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Quando não tem configuração para ambiente diferente
            optionsBuilder
                .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_EFCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;")
           //     .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information)
           //     .EnableSensitiveDataLogging()
           //     .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        
        #endregion


        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }

        public DbSet<Departamento>? Departamentos { get; set; }

        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }

        }
}
