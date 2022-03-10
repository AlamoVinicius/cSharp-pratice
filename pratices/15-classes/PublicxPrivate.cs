using System;

class Player
{
    private int energy;
    private string nome;
    public Player(string nome)
    {
        this.nome = nome;  // this.nome referenica a propriedade publica fora do método 
        energy = 100;
    }

    public int getEnergy()  // método que ira retonar o membro energy da classe Player
    {
        return energy;
    }

    public string getNome()  // método public que irá retornar o membro nome que foi definido como private
    {
        return nome;
    }

    public void setEnergy(int power) // método public que irá retornar o novo valor configurado de enrgia, com esse método temos acesso ao valor de energy que é privado fora da classe Player{}
    {
        if (power < 0)
        {
            if ((energy + power) < 0)
            {
                energy = 0;
            }
            else
            {
                energy += power;  // energy = energy - (- power) => energy = energy + power logo se faz necessário colocar energy += para somar ou subtrair.
            }
        }
        else if (power > 0)
        {
            if ((energy + power) > 100)
            {
                energy = 100;
            }
            else
            {
                energy += power;
            }
        }
    }
}
class PublicxPrivate
{
    static void Main()
    {
        Player player_one = new Player("Álamo");

        player_one.setEnergy(-150);  // chamada do método para configuração de novo valor de energy 

        Console.WriteLine("Nome: {0}", player_one.getNome());  // 
        Console.WriteLine("Energia: {0}", player_one.getEnergy());   // chamada dos métodos para obter os valores de energy e nome  que foram definidos como public
    }
}

// membros private só podem ser acessados dentro da mesma classe 
// para acessar membros private é necessário criar um método quer irá retornar esse membro 