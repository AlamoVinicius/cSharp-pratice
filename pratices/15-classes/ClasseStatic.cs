using System;

static public class Player
{
    static int energy;
    static bool live;
    static string nome;   // automaticamente as props ja são public

    static public void start(string name)    //construtor necessario colocar public
    {
        energy = 100;
        live = true;
        nome = name;
    }

    static public void info()   //automaticamente ja  é public
    {
        Console.WriteLine("Nome jogador: {0}", nome);
        Console.WriteLine("Energia jogador: {0}", energy);
        Console.WriteLine("Jogador está vivo? {0}\n", live);
    }
}

class Enemy
{
    static public bool alert; // definimos a propriedade como static poderemos controlar todos os objetos instanciado nessa propriedade
    //ao definir a propriedade como static tambem podemos acessala de fora da classe
    public string nome;

    public Enemy(string name)
    {
        alert = false;
        nome = name;
    }

    public void info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(alert);
        Console.WriteLine("-------------------");
    }
}
class ClasseStatic
{
    static void Main()
    {
        Player.start("Álamo");
        Player.info();

        Enemy enemy1 = new Enemy("Soldado Russo");
        Enemy enemy2 = new Enemy("Soldado Chinês");
        Enemy enemy3 = new Enemy("Soldado Norte Coreano");

        Enemy.alert = true;

        enemy1.info();
        enemy2.info();
        enemy3.info();
    }
}

// class static não pode ter construtores e não podemos instanciar objetos