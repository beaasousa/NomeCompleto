string nome, sobrenome, sobrenomeEmMaiusculas;

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!; 

Console.Write("Digite seu sobrenome:");
sobrenome = Console.ReadLine()!;

sobrenomeEmMaiusculas = sobrenome.ToUpper();

Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
Console.WriteLine($"Nome de Catálogo: {sobrenomeEmMaiusculas}, {nome}");