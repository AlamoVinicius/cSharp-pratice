using System;

public class Player
{
    public int energy;
    public bool live;
    public string nome;

    public Player()    //construtor
    {
        energy = 100;
        live = true;
        nome = "jogador";
    }

    public Player(string name)    //construtor com parâmetro
    {
        energy = 100;
        live = true;
        nome = name;
    }

    public Player(string name, int energia)    //construtor com parâmetro
    {
        energy = energia;
        live = true;
        nome = name;
    }

    public Player(string name, int energia, bool vivo)    //construtor com parâmetro
    {
        energy = energia;
        live = vivo;
        nome = name;
    }

    public void info()
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energy);
        Console.WriteLine("Jogador está vivo? {0}\n", live);
    }
   
}
class Sobrecarga
{
    static void Main()
    {
        Player player_one = new Player();
        Player player_two = new Player("Sabrina");
        Player player_three = new Player("Álamo", 100);
        Player player_four = new Player("Larissa", 0, false);

        player_one.info();
        player_two.info();
        player_three.info();
        player_four.info();
    }
}

// podemos passar varios metodos como sobrecarga  escrevendo os mesmo método com diferentes parâmetros 