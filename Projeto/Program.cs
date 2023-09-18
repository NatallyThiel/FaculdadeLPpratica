string continuar;

do
{
    Console.Write("Digite seu Nome: ");
    string? nome = Console.ReadLine();

    Console.Write("Digite sua Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.Write("Digite sua Altura: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Digite seu Peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());

    double imc = peso / (altura * altura);
    string resultado;

    if (imc <= 18.5)
    {
        resultado = "Baixo peso!";
    }
    else if (imc <= 24.9)
    {
        resultado = "Normal!";
    }
    else if (imc <= 29.9)
    {
        resultado = "Sobrepeso!";
    }
    else
    {
        resultado = "OBESO!";
    }

    string rid;
    if (idade <= 12)
    {
        rid = "Criança!";
    }
    else if (idade <= 18)
    {
        rid = "Adolescente!";
    }
    else if (idade <= 59)
    {
        rid = "Adulto!";
    }
    else
    {
        rid = "Idoso!";
    }

    Console.WriteLine("\n---------------Relatório de IMC---------------");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine($"Idade: {idade}");
    Console.WriteLine("IMC: " + resultado);
    Console.WriteLine($"Faixa Etária: {rid}");
    Console.WriteLine("\n----------------------------------------------");

    Console.Write("Deseja continuar (s/n)? ");
    continuar = Console.ReadLine();
} while (continuar.ToLower() == "s");

Console.WriteLine("Obrigado por usar nosso sistema");