﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Office_ManyToMany.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;

        public ICollection<Veiculo>? Veiculos { get; set; }

        public ICollection<ColaboradorVeiculo> ColaboradoresVeiculos { get; set; }

        public ICollection<ColaboradorSetor>? ColaboradorSetores { get; set; }

        public ICollection<Turma>? Turmas { get; set; }
    }
}
