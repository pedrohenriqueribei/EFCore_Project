

namespace eCommerce.Models
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome { get; set; } = null!;

        public ICollection<Usuario>? Usuarios { get; set; }
    }
}
