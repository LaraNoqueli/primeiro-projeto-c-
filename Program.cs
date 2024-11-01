Console.WriteLine("Bem vindo ao seu sistema de corrida");

Console.WriteLine("Digite seu nome");
string nome = Console.ReadLine();

if (nome == null)
{
    Console.WriteLine("O nome informado não está correto");
}
else
{
    Console.WriteLine("agora nos informe a sua idade");
    if (int.TryParse(Console.ReadLine(), out int idade))
    {

        Console.WriteLine($"Certo {nome}. Qual a sua meta de corrida para esse ano?");
        decimal.TryParse(Console.ReadLine(), out decimal meta);

        Console.WriteLine($"{nome} nos informe quantos km voce correu nos meses anteriores");

        decimal distanciaTotalPercorrida = 0;

        for (int i = 1; i <= DateTime.Now.Month; i++)
        {
            Console.Write($"km corridos por mes {i}");
            decimal.TryParse(Console.ReadLine(), out decimal distanciaPercorridaNoMes);
            distanciaTotalPercorrida = distanciaTotalPercorrida + distanciaPercorridaNoMes;
        }

        Console.WriteLine($"{nome} voce percorreu um total de {distanciaTotalPercorrida} km!");
    }
    else
    {
        Console.WriteLine("idade não pode conter letra");
    }

}