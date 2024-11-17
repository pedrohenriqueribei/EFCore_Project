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
    public class EnderecoConfiguration : IEntityTypeConfiguration<EnderecoEntrega>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntrega> builder)
        {
            builder.ToTable("TB_ENDERECO_ENTREGA");
            builder.HasKey(end => end.Id);
            builder.Property(end => end.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(end => end.NomeEndereco).IsRequired().HasMaxLength(200);
            builder.Property(end => end.CEP).IsRequired().HasMaxLength(10);
            builder.Property(end => end.Estado).HasMaxLength(2);
        }
    }
}
