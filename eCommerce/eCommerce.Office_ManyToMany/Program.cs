using eCommerce.Office_ManyToMany;
using Microsoft.EntityFrameworkCore;


var db = new eCommerceOfficeContext();



Console.WriteLine("Programa rodou");

#region Colaboradores
var colaboradores = db.Colaboradores;

foreach (var func in colaboradores)
{
    Console.WriteLine(func.Id + " - " + func.Nome);
}



Console.WriteLine();
Console.WriteLine("----------Colaboradores por Setor------------");

#endregion

#region MANY-TO-MANY > 2X ONE-TO-MANY = EF CORE < 5
var setores = db.Setores!.Include(s => s.ColaboradoresSetor).ThenInclude(c => c.Colaborador);

foreach (var setor in setores)
{
    Console.WriteLine(setor.Nome.ToUpper());

    foreach(var colabSetor in setor.ColaboradoresSetor)
    {
        //Console.WriteLine(colabSetor.SetorId+" - "+colabSetor.ColaboradorId);
        Console.WriteLine(" - "+colabSetor.Colaborador.Nome);
    }
    Console.WriteLine();
}
#endregion

#region Mapping: Many-to-many => EF CORE >= 5

Console.WriteLine();
Console.WriteLine("----------------------------------");
var colabTurma = db.Colaboradores!.Include(c => c.Turmas);

foreach (var colab in colabTurma)
{
    Console.WriteLine($"{colab.Nome}");
    
    foreach(var turma in colab.Turmas)
    {
        Console.WriteLine(" - "+turma.Nome);
    }
}
#endregion