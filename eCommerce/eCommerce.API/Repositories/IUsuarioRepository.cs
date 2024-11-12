using eCommerce.Models;

namespace eCommerce.API.Repositories
{
    public interface IUsuarioRepository
    {
        /*
         * CRUD
         */

        List<Usuario> GetAll();

        Usuario Get(int id);

        void Add(Usuario usuario);

        void Update(Usuario usuario);

        void Delete(int id);
    }
}
