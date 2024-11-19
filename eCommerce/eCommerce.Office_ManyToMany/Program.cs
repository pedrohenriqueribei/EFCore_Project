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

#region MANY-TO-MANY + Payload for EF Core 5+
Console.WriteLine();
Console.WriteLine("----------------------------------");
Console.WriteLine("region MANY-TO-MANY + Payload for EF Core 5+");
Console.WriteLine();

var colaboradors = db.Colaboradores!.Include(a => a.Veiculos);

foreach (var func in colaboradors)
{
    Console.WriteLine($"{func.Nome}");

    foreach (var veiculo in func.Veiculos)
    {
        Console.WriteLine(" - " + veiculo.Nome);
    }
    Console.WriteLine();
}
#endregion

#region MANY-TO-MANY + Payload for EF Core 5+ Com tabela intermediaria
Console.WriteLine();
Console.WriteLine("----------------------------------   region MANY-TO-MANY + Payload for EF Core 5+ Com Tabela Intermediária");
Console.WriteLine("");
Console.WriteLine();

var colabs = db.Colaboradores!.Include(a => a.ColaboradoresVeiculos)!.ThenInclude(a => a.Veiculo);

foreach (var func in colabs)
{
    Console.WriteLine($"{func.Nome}");

    foreach (var vinculo in func.ColaboradoresVeiculos!)
    {
        Console.WriteLine($" - ({vinculo.Veiculo.Id}) -> {vinculo.Veiculo.Nome} ({vinculo.Veiculo.Placa}) - Data de: {vinculo.DataInicio}");
    }
    Console.WriteLine();
}
#endregion


#region Criando vinculos novos entre colaborador e carros
var func07 = db.Colaboradores!.Find(8);

Console.WriteLine($"{func07!.Nome} - {func07.Id}");

var carro06 = db.Veiculos!.Find(7);

Console.WriteLine($"{carro06!.Placa} - {carro06.Nome}");
func07.Veiculos!.Add(carro06);
db.SaveChanges();
#endregion
