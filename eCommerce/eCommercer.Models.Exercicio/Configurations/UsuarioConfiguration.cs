using eCommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace eCommercer.Models.Exercicio.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("TB_USUARIO");
            builder.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).IsRequired().HasMaxLength(200).HasColumnName("user_name");
            builder.Property(p => p.Email).IsRequired().HasColumnName("user_email");
            builder.Property(p => p.Sexo).HasColumnName("user_sexo").HasMaxLength(15);
            builder.Property(p => p.RG).IsRequired().HasColumnName("user_RG").HasMaxLength(20);
            builder.Property(p => p.CPF).IsRequired().HasColumnName("user_CPF").HasMaxLength(15);
            builder.Property(p => p.NomeMae).HasMaxLength(100).HasColumnName("user_mother_name");

            builder.HasOne(user => user.Contato).WithOne(cont => cont.Usuario).HasForeignKey<Contato>(cont => cont.UsuarioId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(user => user.EnderecosEntrega).WithOne(end => end.Usuario).HasForeignKey(end => end.UsuarioId).OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(user => user.Departamentos).WithMany(dept => dept.Usuarios);
        }
    }
}
