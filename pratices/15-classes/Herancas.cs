using System;

class Vehicles      //Base class
{
    public int wheels;
    public int velMax;
    private bool engine_on;

    public void connect_on()
    {
        engine_on = true;
    }

    public void connect_off()
    {
        engine_on = false;
    }

    public string getStateConnectCarr()
    {
        if (engine_on)
        {
            return  "Motor ligado";
        } else {
            return  "Motor desligado";
        }
    }
}

class Carr : Vehicles  //class derivada
{  //sintaxe para classe Carr herdar a classe Vehicles, obs..: mesmo sem ser herdada ja podemos ter acesso aos membros da classe Vehicles pois elas estão definidas como "public".
    public string nome;
    public string cor;
    public Carr(string nome, string cor)
    {
        connect_off();
        wheels = 4;
        velMax = 250;
        this.nome = nome;
        this.cor = cor;
    }
}


class Herancas
{
    static void Main()
    {
        Carr carr_one = new Carr("Ferrari", "Vermelho");

        Console.WriteLine("Cor................:{0}", carr_one.cor);
        Console.WriteLine("Marca..............:{0}", carr_one.nome);
        Console.WriteLine("Numero de Rodas....:{0}", carr_one.wheels);
        Console.WriteLine("Vel.máxima.........:{0}", carr_one.velMax);
        Console.WriteLine("Ligado.............:{0}", carr_one.getStateConnectCarr());
    }
}

// heranças podem receber da classe pai acesso aos seus membros