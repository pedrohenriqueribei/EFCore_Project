using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models.FluentAPI
{
    public class eCommerceFluentAPIContext : DbContext
    {

        public eCommerceFluentAPIContext(DbContextOptions<eCommerceFluentAPIContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }

        public DbSet<Departamento>? Departamentos { get; set; }

        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }

        /*
         * FLUENT API - utiliza os recursos da programação DDD
         * Possui mais recursos disponiveis (metodos)
         * Não faz o mapeamento nas classes de modelo, ficando mais enxuto (DDD)
         */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //definir nome da tabela
            modelBuilder.Entity<Usuario>().ToTable("TB_USUARIOS");

            //definir nome de uma coluna, tamanho, valor default e que é obrigatório
            modelBuilder.Entity<Usuario>().Property(a => a.RG).HasColumnName("REGISTRO_GERAL").HasMaxLength(10).HasDefaultValue("RG-AUSENTE").IsRequired();

            //ignorar um campo na tabela (só será usado na programação o campo)
            modelBuilder.Entity<Usuario>().Ignore(a => a.Ativo);

            //definir que a coluna Id é Identity (chave primária gerenciada pelo EF Core)
            modelBuilder.Entity<Usuario>().Property(a => a.Id).ValueGeneratedOnAdd();

            //Index
            //1. modelBuilder.Entity<Usuario>().HasIndex("CPF");
            modelBuilder.Entity<Usuario>().HasIndex(a => a.CPF).IsUnique().HasFilter("[CPF] is not null").HasDatabaseName("IX_CPF_UNIQUE");
            modelBuilder.Entity<Usuario>().HasIndex(a => new { a.CPF, a.Email });

            //Key - definir chave primaria
            modelBuilder.Entity<Usuario>().HasKey("Id");
            modelBuilder.Entity<Usuario>().HasKey(a => a.Id);

            modelBuilder.Entity<Usuario>().HasKey("Id", "CPF");
            modelBuilder.Entity<Usuario>().HasKey(a => new {a.Id, a.CPF});

            //chave alternativa
            modelBuilder.Entity<Usuario>().HasAlternateKey("CPF");

            //não ter chave primaria
            //modelBuilder.Entity<Usuario>().HasNoKey();

            /*
             * FOREIGN KEY
             * Relacionamentos entre entidades
             * 
             * Has/With + One/Many = hasOne(), hasMany(), withOne(), withMany()
             * 
             * ONE  - 1 Propriedade de Navegação Simples(Composição) 
             * MANY - 1 Propriedade de Navegação do tipo lista/coleção
             * 
             * ONDELETE
             * Para definir a exclusão dos filhos caso o pai seja excluido
            */
            modelBuilder.Entity<Usuario>().HasOne(user => user.Contato).WithOne(cont => cont.Usuario).HasForeignKey<Contato>(cont => cont.UsuarioId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Usuario>().HasMany(user => user.EnderecosEntrega).WithOne(end => end.Usuario).HasForeignKey(end => end.UsuarioId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Usuario>().HasMany(user => user.Departamentos).WithMany(dept => dept.Usuarios);


        }


    }
}
