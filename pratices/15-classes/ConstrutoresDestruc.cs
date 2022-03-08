using System;

public class Player
{
    public int energy;
    public bool live;
    public string nome;
    public Player(string name)    //construtor
    {
        energy = 100;
        live = true;
        nome = name;
    }
    ~Player(){  //para o método destructor usamos o sinal ~a ntes do método que é chamado automaticamente após a finalização do programa
        Console.WriteLine("O Jogador {0} foi excluido.", nome);
    }
}
class ConstrutoresDestruc
{
    static void Main()
    {
        Player player_one = new Player("Alamo");
        Player player_two = new Player("Sabrina");

        Console.WriteLine("Jogador: {0}", player_one.nome);
        Console.WriteLine("Energy: {0}", player_one.energy);
        Console.WriteLine("==============================");
        Console.WriteLine("Jogador: {0}", player_two.nome);
        Console.WriteLine("Energy: {0}", player_two.energy);
    }
}

// recomendação é atribuir um valor para os atributos da classe dentro do construtor Player()