class Campeonato
{
    public string nomeCampeonato;
    public Equipe? equipe1;
    public Equipe? equipe2;

    public Campeonato(string nomeCampeonato)
    {
        this.nomeCampeonato = nomeCampeonato;
    }

//utilizado método IniciarPartida entre e1 e e2. Primeiro irá verificar se todos os jogadores estão criados e dentro das equipes. 
//Após a verificação irá inciar a partida, com cada jogador jogando uma partida
    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        if (e1 != null && e2 != null && e1.jogador1 != null && e2.jogador2!= null && e1.jogador3 != null && e1.jogador4 != null && e1.jogador5 != null
        && e2.jogador6 != null && e2.jogador7 != null && e2.jogador8 != null && e2.jogador9 != null && e2.jogador10 != null)
        {
            Console.WriteLine($"Iniciando partida entre {e1.nome} e {e2.nome}...");
            e1.jogador1.Jogar();
            e2.jogador2.Jogar();
            e1.jogador3.Jogar();
            e1.jogador4.Jogar();
            e1.jogador5.Jogar();

            e2.jogador6.Jogar();
            e2.jogador7.Jogar();
            e2.jogador8.Jogar();
            e2.jogador9.Jogar();
            e2.jogador10.Jogar();
        }
        else
        {
            Console.WriteLine("Cada equipe deve ter exatamente 5 jogadores para iniciar a partida.");
        }
    }

    public void Classificacao()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Classificação das equipes no campeonato:");
        Console.WriteLine();
        int pontosEquipe1 = equipe1.PontosTotal();
        int pontosEquipe2 = equipe2.PontosTotal();

        if (pontosEquipe1 > pontosEquipe2)
        {
            Console.WriteLine($"{equipe1.nome} está em primeiro lugar com {pontosEquipe1} pontos.");
            Console.WriteLine();
            Console.WriteLine($"{equipe2.nome} está em segundo lugar com {pontosEquipe2} pontos.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"{equipe2.nome} está em primeiro lugar com {pontosEquipe2} pontos.");
            Console.WriteLine();
            Console.WriteLine($"{equipe1.nome} está em segundo lugar com {pontosEquipe1} pontos.");
            Console.WriteLine();
        }
    }
}
