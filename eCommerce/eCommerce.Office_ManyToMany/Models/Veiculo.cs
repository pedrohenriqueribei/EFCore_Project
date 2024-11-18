using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Office_ManyToMany.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public string Placa { get; set; } = null!;

        public ICollection<Colaborador>? Colaboradores { get; set; }
    }
}
