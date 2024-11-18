using eCommerce.Office_ManyToMany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Office_ManyToMany
{
    public class eCommerceOfficeContext : DbContext
    {
        public DbSet<Colaborador>? Colaboradores { get; set; }

        public DbSet<Veiculo>? Veiculos { get; set; }

        public DbSet<Setor>? Setores { get; set; }

        public DbSet<Turma>? Turmas { get; set; }

        public DbSet<ColaboradorSetor>? ColaboradoresSetores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=db_eCommerceOffice;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region Mapping: ColaboradorSetor
            // chave primaria composta
            modelBuilder.Entity<ColaboradorSetor>().HasKey(a => new { a.SetorId, a.ColaboradorId });

            //relacionamento de Colaborador para ColaboradorSetores
            //1:
            //modelBuilder.Entity<Colaborador>().HasMany(a => a.ColaboradorSetores).WithOne(a => a.Colaborador).HasForeignKey(a => a.ColaboradorId);
            //2:
            modelBuilder.Entity<ColaboradorSetor>().HasOne(a => a.Colaborador).WithMany(a => a.ColaboradorSetores).HasForeignKey(a => a.ColaboradorId);

            //relacionamento de Setor para ColaboradoresSetor
            //1:
            //modelBuilder.Entity<Setor>().HasMany(a => a.ColaboradoresSetor).WithOne(a => a.Setor).HasForeignKey(a => a.SetorId);
            //2:
            modelBuilder.Entity<ColaboradorSetor>().HasOne(a => a.Setor).WithMany(a => a.ColaboradoresSetor).HasForeignKey(a => a.SetorId);

            #endregion

            #region Colaborador
            //modelBuilder.Entity<Colaborador>().Property(c => c.Id).ValueGeneratedOnAdd();
            #endregion

            #region Setor
            //modelBuilder.Entity<Setor>().Property(s => s.Id).ValueGeneratedOnAdd();
            #endregion

            #region Turma
            //modelBuilder.Entity<Turma>().Property(t => t.Id).ValueGeneratedOnAdd();
            #endregion

            #region Veiculo
            //modelBuilder.Entity<Veiculo>().Property(v => v.Id).ValueGeneratedOnAdd();
            #endregion

            #region Seeds

            modelBuilder.Entity<Colaborador>().HasData(
                new Colaborador() { Id = 1, Nome = "Anna" },
                new Colaborador() { Id = 2, Nome = "Clara" },
                new Colaborador() { Id = 3, Nome = "Anny" },
                new Colaborador() { Id = 4, Nome = "ANNA BEATRIZ" },
                new Colaborador() { Id = 5, Nome = "Mateus" },
                new Colaborador() { Id = 6, Nome = "Gabriel" },
                new Colaborador() { Id = 7, Nome = "Pedro" },
                new Colaborador() { Id = 8, Nome = "Thais" },
                new Colaborador() { Id = 9, Nome = "Pedrina" },
                new Colaborador() { Id = 10, Nome = "Erica" },
                new Colaborador() { Id = 11, Nome = "Icaro" },
                new Colaborador() { Id = 12, Nome = "Hugo" },
                new Colaborador() { Id = 14, Nome = "Vitor" },
                new Colaborador() { Id = 15, Nome = "Mateus" }
            );

            modelBuilder.Entity<Setor>().HasData(
                new Setor() { Id = 1, Nome = "Administrativo"},
                new Setor() { Id = 2, Nome = "Financeiro" },
                new Setor() { Id = 3, Nome = "RH" },
                new Setor() { Id = 4, Nome = "Logistica" },
                new Setor() { Id = 5, Nome = "Gerencia" }
            );

            modelBuilder.Entity<ColaboradorSetor>().HasData(
                new ColaboradorSetor() { SetorId = 1, ColaboradorId = 1, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 1, ColaboradorId = 6, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 1, ColaboradorId = 7, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 2, ColaboradorId = 5, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 2, ColaboradorId = 3, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 2, ColaboradorId = 7, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 3, ColaboradorId = 7, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 3, ColaboradorId = 8, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 14, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 12, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 10, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 9, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 2, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 6, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 4, ColaboradorId = 11, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 5, ColaboradorId = 4, Criacao = DateTimeOffset.Now },
                new ColaboradorSetor() { SetorId = 5, ColaboradorId = 7, Criacao = DateTimeOffset.Now }

            );

            modelBuilder.Entity<Turma>().HasData(
                new Turma() { Id = 1, Nome = "Turma A101"},
                new Turma() { Id = 2, Nome = "Turma A102" },
                new Turma() { Id = 3, Nome = "Turma A103" },
                new Turma() { Id = 4, Nome = "Turma A104" },
                new Turma() { Id = 5, Nome = "Turma A105" }
            );
            #endregion


            #region Mapping: Colaborador <=> Turma
            modelBuilder.Entity<Colaborador>().HasMany(c => c.Turmas).WithMany(t => t.Colaboradores);

            #endregion

            #region Mapping: Colaborador <=> Veiculos
            modelBuilder.Entity<Colaborador>().HasMany(c => c.Veiculos).WithMany(v => v.Colaboradores);
            #endregion
        }
    }
}
