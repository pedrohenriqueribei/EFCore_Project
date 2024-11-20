﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.API.Database;

#nullable disable

namespace eCommerce.API.Migrations
{
    [DbContext(typeof(eCommerceContext))]
    [Migration("20241120152951_BancoInicial")]
    partial class BancoInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepartamentoUsuario", b =>
                {
                    b.Property<int>("DepartamentosId")
                        .HasColumnType("int");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("DepartamentosId", "UsuariosId");

                    b.HasIndex("UsuariosId");

                    b.ToTable("DepartamentoUsuario");
                });

            modelBuilder.Entity("eCommerce.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("eCommerce.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Moda Infantil"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Moda Feminina"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Moda Masculina"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Moda Gestante"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Calçados"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Beleza"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Informática"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Celulares"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Eletrônicos"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Livros"
                        });
                });

            modelBuilder.Entity("eCommerce.Models.EnderecoEntrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEndereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("EnderecosEntrega");
                });

            modelBuilder.Entity("eCommerce.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DataCadastro")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeMae")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SituacaoCadastro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DepartamentoUsuario", b =>
                {
                    b.HasOne("eCommerce.Models.Departamento", null)
                        .WithMany()
                        .HasForeignKey("DepartamentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Models.Contato", b =>
                {
                    b.HasOne("eCommerce.Models.Usuario", "Usuario")
                        .WithOne("Contato")
                        .HasForeignKey("eCommerce.Models.Contato", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("eCommerce.Models.EnderecoEntrega", b =>
                {
                    b.HasOne("eCommerce.Models.Usuario", "Usuario")
                        .WithMany("EnderecosEntrega")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("eCommerce.Models.Usuario", b =>
                {
                    b.Navigation("Contato");

                    b.Navigation("EnderecosEntrega");
                });
#pragma warning restore 612, 618
        }
    }
}
