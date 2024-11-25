

using eCommerce;
using eCommerce.Models;

var db = new eCommerceContext();



/*
var usuario01 = db.Usuarios.Find(1);

//usuario01.SituacaoCadastro = "Ativo";
//usuario01.DataCadastro = DateTimeOffset.Parse("2024-11-21T15:37:04-03:00");
usuario01.DataCadastro = DateTimeOffset.Now;

db.SaveChanges();

Console.WriteLine(usuario01!.DataCadastro);

//List<Usuario> usuarios = db.Usuarios.ToList();



 * Alterando dados da tabela
foreach(var usuario in usuarios)
{
    if(usuario.SituacaoCadastro == null && usuario.Id > 13)
    {
        Console.WriteLine(usuario);
        usuario.SituacaoCadastro = "Ativo";
        db.SaveChanges();
    }
}
*/