using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly eCommerceContext _db;

        public UsuarioRepository(eCommerceContext db)
        {
            _db = db;
        }

        //public static List<Usuario> _db = new List<Usuario>();


        public void Add(Usuario usuario)
        {
            CriarVinculoDoUsuarioComDepartamento(usuario);

            _db.Usuarios!.Add(usuario);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Usuarios!.Remove(Get(id));
            _db.SaveChanges();
        }

        public Usuario Get(int id)
        {
            return _db.Usuarios!.Include(a => a.Contato).Include(a => a.EnderecosEntrega).Include(a => a.Departamentos).FirstOrDefault(a=>a.Id == id)!;
        }

        public List<Usuario> GetAll()
        {
            return _db.Usuarios!.Include(a=>a.Contato).OrderBy(a => a.Id).ToList();
        }

        public void Update(Usuario usuario)
        {
            ExcluirVinculosUsuarioComDepartamento(usuario);

            //incluir vinculos do usuário com departamento
            CriarVinculoDoUsuarioComDepartamento(usuario);

            _db.Usuarios!.Update(usuario);
            _db.SaveChanges();
        }

        private void ExcluirVinculosUsuarioComDepartamento(Usuario usuario)
        {
            var db_usuario = _db.Usuarios!.Include(a => a.Departamentos).FirstOrDefault(a => a.Id == usuario.Id);

            //deletar todos os vinculos do usuário com departamento
            foreach (var dept in db_usuario!.Departamentos!)
            {
                db_usuario.Departamentos.Remove(dept);
            }

            _db.SaveChanges();
            _db.ChangeTracker.Clear();
        }

        private void CriarVinculoDoUsuarioComDepartamento(Usuario usuario)
        {
            if (usuario.Departamentos != null)
            {
                var departamentos = usuario.Departamentos;
                usuario.Departamentos = new List<Departamento>();

                foreach (var dept in departamentos)
                {
                    if (dept.Id > 0)
                    {
                        usuario.Departamentos.Add(_db.Departamentos!.Find(dept.Id)!);
                    }
                    else
                    {
                        usuario.Departamentos.Add(dept);
                    }
                }
            }
        }
    }
}
