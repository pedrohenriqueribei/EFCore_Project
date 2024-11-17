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
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("TB_DEPARTAMENTO");
            builder.HasKey(dept => dept.Id);
            builder.Property(dept => dept.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(dept => dept.Nome).HasColumnName("DEPTO_NAME").HasMaxLength(200).IsRequired();
        }
    }
}
