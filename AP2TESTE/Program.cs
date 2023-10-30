class Program
{
    static Jogador jogador1, jogador2, jogador3, jogador4, jogador5, jogador6, jogador7, jogador8, jogador9, jogador10;
    static Equipe equipe1, equipe2;
    static Campeonato campeonato;

    static void Main(string[] args)
    {
        campeonato = new Campeonato("Campeonato de CS:GO");

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - Criar Jogadores");
            Console.WriteLine("2 - Criar Equipes");
            Console.WriteLine("3 - Adicionar Jogadores às Equipes");
            Console.WriteLine("4 - Iniciar Partida");
            Console.WriteLine("5 - Iniciar novo campeonato");
            Console.WriteLine("6 - Sair");

            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CriarJogadores();
                    break;
                case 2:
                    CriarEquipes();
                    break;
                case 3:
                    AdicionarJogadoresAsEquipes();
                    break;
                case 4:
                    if (equipe1 != null && equipe2 != null)
                    {
                        campeonato.equipe1 = equipe1;
                        campeonato.equipe2 = equipe2;
                        campeonato.IniciarPartida(equipe1, equipe2);
                        campeonato.Classificacao();
                    }
                    else
                    {
                        Console.WriteLine("Cada equipe deve ter exatamente 5 jogadores para iniciar a partida.");
                    }
                    break;
                case 5:
                    // Iniciar um novo campeonato
                    campeonato = new Campeonato("Campeonato de CS:GO");
                    equipe1 = null;
                    equipe2 = null;
                    break;
                case 6:
                //fechar o código sem precisar fechar o programa todo.
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void CriarJogadores()
    {
        jogador1 = CriarJogador(1);
        jogador2 = CriarJogador(2);
        jogador3 = CriarJogador(3);
        jogador4 = CriarJogador(4);
        jogador5 = CriarJogador(5);
        jogador6 = CriarJogador(6);
        jogador7 = CriarJogador(7);
        jogador8 = CriarJogador(8);
        jogador9 = CriarJogador(9);
        jogador10 = CriarJogador(10);
    }

    static Jogador CriarJogador(int numero)
    {
        Console.WriteLine($"Crie o jogador {numero}");
        Console.Write($"Nome do jogador {numero}: ");
        string nome = Console.ReadLine();
        Console.Write($"NickName do jogador {numero}: ");
        string nickName = Console.ReadLine();

        return new Jogador { nome = nome, nickName = nickName, pontos = 0 };
    }

    static void CriarEquipes()
    {
        Console.WriteLine("Crie a primeira equipe");
        Console.Write("Defina um nome: ");
        string nomeEquipe1 = Console.ReadLine();
        equipe1 = new Equipe(nomeEquipe1);

        Console.WriteLine("Crie a segunda equipe");
        Console.Write("Defina um nome: ");
        string nomeEquipe2 = Console.ReadLine();
        equipe2 = new Equipe(nomeEquipe2);
    }

    static void AdicionarJogadoresAsEquipes()
    {
        AdicionarJogadorAEquipe(jogador1, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador2, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador3, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador4, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador5, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador6, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador7, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador8, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador9, equipe1, equipe2);
        AdicionarJogadorAEquipe(jogador10, equipe1, equipe2);
    }

    static void AdicionarJogadorAEquipe(Jogador jogador, Equipe equipe1, Equipe equipe2)
    {
        Console.WriteLine($"Defina a equipe do jogador {jogador.nickName}");
        Console.WriteLine("1 - PRIMEIRA EQUIPE");
        Console.WriteLine("2 - SEGUNDA EQUIPE");
        Console.Write("Selecione uma opção: ");
        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            switch (opcao)
            {
                case 1:
                    equipe1.AdicionarJogadorNaEquipe(jogador);
                    break;
                case 2:
                    equipe2.AdicionarJogadorNaEquipe(jogador);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha 1 ou 2.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida. Você deve inserir um número inteiro.");
        }
    }
}
