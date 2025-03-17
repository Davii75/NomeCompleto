string nome;
string sobrenome;

Console.WriteLine("Digite o seu primeiro nome: ");
nome = Console.ReadLine()!;
Console.WriteLine("Digite o seu sobrenome");
sobrenome = Console.ReadLine()!;
Console.WriteLine($"Nome completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de catálogo: {sobrenome.ToUpper()}, {nome}");
