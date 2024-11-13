

using eCommerce.ConsoleEngReverso.Database;

var db = new DbEfcoreContext();

foreach(var usuario in db.Usuarios)
{
    Console.WriteLine(usuario.Nome);
}