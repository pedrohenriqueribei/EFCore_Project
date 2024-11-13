using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Database
{
    public class eCommerceContext : DbContext
    {
        
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options) { 
            
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //para adicionar dados em uma tabela

            modelBuilder.Entity<Departamento>().HasData(
                    new Departamento { Id = 1, Nome = "Moda Infantil" },
                    new Departamento { Id = 2, Nome = "Moda Feminina" },
                    new Departamento { Id = 3, Nome = "Moda Masculina" },
                    new Departamento { Id = 4, Nome = "Moda Gestante" },
                    new Departamento { Id = 5, Nome = "Calçados" },
                    new Departamento { Id = 6, Nome = "Beleza" },
                    new Departamento { Id = 7, Nome = "Informática" },
                    new Departamento { Id = 8, Nome = "Celulares" },
                    new Departamento { Id = 9, Nome = "Eletrônicos" },
                    new Departamento { Id = 10, Nome = "Livros" }
            );
        }


        #region
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Quando não tem configuração para ambiente diferente
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DB_EFCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;");
        }
        */
        #endregion

    }
}
