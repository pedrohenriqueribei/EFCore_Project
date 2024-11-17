using eCommerce.Models;
using eCommercer.Models.Exercicio.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace eCommercer.Models.Exercicio
{
    public class eCommerceFluentApiExercicioContext : DbContext
    {
        public eCommerceFluentApiExercicioContext(DbContextOptions<eCommerceFluentApiExercicioContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }

        public DbSet<Departamento>? Departamentos { get; set; }

        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Usuario

            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            /*
             * usando a configuração em arquivo separado
             * 
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIO");
            modelBuilder.Entity<Usuario>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);
            modelBuilder.Entity<Usuario>().Property(p => p.Nome).IsRequired().HasMaxLength(200).HasColumnName("user_name");
            modelBuilder.Entity<Usuario>().Property(p => p.Email).IsRequired().HasColumnName("user_email");
            modelBuilder.Entity<Usuario>().Property(p => p.Sexo).HasColumnName("user_sexo").HasMaxLength(15);
            modelBuilder.Entity<Usuario>().Property(p => p.RG).IsRequired().HasColumnName("user_RG").HasMaxLength(20);
            modelBuilder.Entity<Usuario>().Property(p => p.CPF).IsRequired().HasColumnName("user_CPF").HasMaxLength(15);
            modelBuilder.Entity<Usuario>().Property(p => p.NomeMae).HasMaxLength(100).HasColumnName("user_mother_name");
            
            modelBuilder.Entity<Usuario>().HasOne(user => user.Contato).WithOne(cont => cont.Usuario).HasForeignKey<Contato>(cont => cont.UsuarioId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Usuario>().HasMany(user => user.EnderecosEntrega).WithOne(end => end.Usuario).HasForeignKey(end => end.UsuarioId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Usuario>().HasMany(user => user.Departamentos).WithMany(dept => dept.Usuarios);
            */
            #endregion

            #region Contato
            modelBuilder.ApplyConfiguration(new ContatoConfiguration());
            /*
            modelBuilder.Entity<Contato>().ToTable("TB_CONTATO");
            modelBuilder.Entity<Contato>().HasKey(c => c.Id);
            modelBuilder.Entity<Contato>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Contato>().Property(p => p.Telefone).HasMaxLength(22);
            modelBuilder.Entity<Contato>().Property(p => p.Celular).HasMaxLength(22);
            */
            #endregion

            #region Departamento
            modelBuilder.ApplyConfiguration(new DepartamentoConfiguration());
            /*
            modelBuilder.Entity<Departamento>().ToTable("TB_DEPARTAMENTO");
            modelBuilder.Entity<Departamento>().HasKey(dept => dept.Id);
            modelBuilder.Entity<Departamento>().Property(dept => dept.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Departamento>().Property(dept => dept.Nome).HasColumnName("DEPTO_NAME").HasMaxLength(200).IsRequired();
            */
            #endregion

            #region Endereco
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            /*
            modelBuilder.Entity<EnderecoEntrega>().ToTable("TB_ENDERECO_ENTREGA");
            modelBuilder.Entity<EnderecoEntrega>().HasKey(end => end.Id);
            modelBuilder.Entity<EnderecoEntrega>().Property(end => end.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<EnderecoEntrega>().Property(end => end.NomeEndereco).IsRequired().HasMaxLength(200);
            modelBuilder.Entity<EnderecoEntrega>().Property(end => end.CEP).IsRequired().HasMaxLength(10);
            modelBuilder.Entity<EnderecoEntrega>().Property(end => end.Estado).HasMaxLength(2);
            */
            #endregion

        }


    }
}
