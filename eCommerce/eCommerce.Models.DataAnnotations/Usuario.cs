
using eCommerce.Models.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{

    [Index(nameof(Email), IsUnique = true, Name = "IX_EMAIL_UNICO")]
    [Index(nameof(Nome), nameof(CPF))]
    [Table("TB_USUARIOS")]
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string? Sexo { get; set; }

        [Column("REGISTRO_GERAL")]
        public string? RG { get; set; }

        [MaxLength(15)]
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        //public string? NomePai { get; set; }
        public string? SituacaoCadastro { get; set; }
        public DateTimeOffset DataCadastro { get; set; }

        [NotMapped]
        public bool Ativo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Matricula { get; set; }
        public Contato? Contato { get; set; }

        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }

        public ICollection<Departamento>? Departamentos { get; set; }


        [InverseProperty("Cliente")]
        public ICollection<Pedido>? PedidosCliente { get; set; }
        [InverseProperty("Colaborador")]
        public ICollection<Pedido>? PedidosColaborador { get; set; }
        [InverseProperty("Supervisor")]
        public ICollection<Pedido>? PedidosSupervisor { get; set; }

        public Usuario(int id)
        {
            Id = id;
        }
    }
}
