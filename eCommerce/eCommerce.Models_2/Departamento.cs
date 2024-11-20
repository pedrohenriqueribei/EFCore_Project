using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models_2
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
