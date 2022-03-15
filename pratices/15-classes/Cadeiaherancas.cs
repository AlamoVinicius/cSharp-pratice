using System;

class Vehicles      //Base class
{
    private int wheels;
    public int velMax;
    private bool engine_on;

    public Vehicles(int wheels)
    {
        this.wheels = wheels;
    }

    public void connect_on(bool engine_on)
    {
        this.engine_on = engine_on;
    }

    /*public void connect_off()
    {
        engine_on = false;
    }*/

    public string getStateConnectCarr()
    {
        return (engine_on ? "Motor Ligado" : "Motor desligado");   // operador ternario mais enxuto a sintaxe
    }

    public int getWheels()
    {
        return wheels;
    }

    public void setWheels(int wheels)
    {
        if (wheels < 0)
        {
            this.wheels = 0;
        }
        else if (wheels > 16)
        {
            this.wheels = 16;
        }
        else
        {
            this.wheels = wheels;
        }
    }
}

class Carr : Vehicles  //class derivada
{
    public string nome;
    public string cor;
    public bool turn_on;
    public Carr(string nome, string cor) : base(4)   //sintaxe para ativar o construtor da classe base use base4
    {
        turn_on = turnOn(nome);
        connect_on(turn_on);
        velMax = 250;
        this.nome = nome;
        this.cor = cor;
    }

    public bool turnOn(string name)
    {
        Console.Write("Deseja ligar o carro {0}? [S/N]", name);
        string condition = Console.ReadLine().ToUpper()[0].ToString();
        return (condition == "S" ? true : false);
    }
}
// cadeia de heranças:
class FightCar : Carr
{
    public int wepons;
    public FightCar() : base("Tanque de guerra", "Verde camuflado")  //use base para chamar um método da classe derivaa que é necessário passar algum tipo de parâmetro 
    {
        wepons = 100;
        setWheels(8);
    }
}

class Cadeiaherancas
{
    static void Main()
    {
        Carr carr_one = new Carr("Ferrari", "Vermelho");
        FightCar carr_two = new FightCar();

        Console.WriteLine("nome...............:{0}", carr_one.nome);
        Console.WriteLine("Cor................:{0}", carr_one.cor);
        Console.WriteLine("Numero de Rodas....:{0}", carr_one.getWheels());
        Console.WriteLine("Vel.máxima.........:{0}", carr_one.velMax);
        Console.WriteLine("Ligado.............:{0}", carr_one.getStateConnectCarr());

        Console.WriteLine("------------------------------");

        Console.WriteLine("nome...............:{0}", carr_two.nome);
        Console.WriteLine("Cor................:{0}", carr_two.cor);
        Console.WriteLine("Numero de Rodas....:{0}", carr_two.getWheels());
        Console.WriteLine("Vel.máxima.........:{0}", carr_two.velMax);
        Console.WriteLine("Ligado.............:{0}", carr_two.getStateConnectCarr());
        Console.WriteLine("Misseis............:{0}", carr_two.wepons);
    }
}

// heranças podem receber da classe pai acesso aos seus membros