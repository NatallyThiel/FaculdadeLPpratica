class Jogador
{
    public string nome;
    public string nickName;
    public int pontos;

//utilizado random.Next para selecionar um número aleatório de pontos nas partidas.
    public void Jogar()
    {
        Random random = new Random();
        int pontosDaPartida = random.Next(1, 101);
        pontos += pontosDaPartida;

        Console.WriteLine();
        Console.WriteLine($"{nickName} marcou {pontosDaPartida} pontos nesta partida.");
        Console.WriteLine();
    }

}