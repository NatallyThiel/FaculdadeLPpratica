class Equipe
{
    public string nome;
    public Jogador? jogador1;
    public Jogador? jogador2;
    public Jogador? jogador3;
    public Jogador? jogador4;
    public Jogador? jogador5;
    public Jogador? jogador6;
    public Jogador? jogador7;
    public Jogador? jogador8;
    public Jogador? jogador9;
    public Jogador? jogador10;

    public Equipe(string nomeEquipe)
    {
        nome = nomeEquipe;
    }

//utilizado o método PontosTotal para a somatória dos pontos de cada jogador em cada partida e irá retornar os valores dos pontos totais.
    public int PontosTotal()
    {

    int totalPontos = 0;

    if (jogador1 != null) totalPontos += jogador1.pontos;
    if (jogador2 != null) totalPontos += jogador2.pontos;
    if (jogador3 != null) totalPontos += jogador3.pontos;
    if (jogador4 != null) totalPontos += jogador4.pontos;
    if (jogador5 != null) totalPontos += jogador5.pontos;
    if (jogador6 != null) totalPontos += jogador6.pontos;
    if (jogador7 != null) totalPontos += jogador7.pontos;
    if (jogador8 != null) totalPontos += jogador8.pontos;
    if (jogador9 != null) totalPontos += jogador9.pontos;
    if (jogador10 != null) totalPontos += jogador10.pontos;

    return totalPontos;

    }

//método AdicionarJogadorNaEquipe irá adicionar jogador até o número 10 caso todos os campos ainda estejam nulos. Caso o contrário aparecerá
//"Equipe cheia".
// AdicionarJogadorNaEquipe(jogador1)
    public void AdicionarJogadorNaEquipe(Jogador jogador)
    {
        if (jogador1 == null)
        {
            jogador1 = jogador;
        }
        else if (jogador2 == null)
        {
            jogador2 = jogador;
        }
        else if (jogador3 == null)
        {
            jogador3 = jogador;
        }
        else if (jogador4 == null)
        {
            jogador4 = jogador;
        }
        else if (jogador5 == null)
        {
            jogador5 = jogador;
        }
         if (jogador6 == null)
        {
            jogador6 = jogador;
        }
        else if (jogador7 == null)
        {
            jogador7 = jogador;
        }
        else if (jogador8 == null)
        {
            jogador8 = jogador;
        }
        else if (jogador9 == null)
        {
            jogador9 = jogador;
        }
        else if (jogador10 == null)
        {
            jogador10 = jogador;
        }
        else
        {
            Console.WriteLine("Equipe cheia!");
        }
    
       
    }
}