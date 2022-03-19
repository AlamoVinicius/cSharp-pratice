using System;

public interface IVehicle
{   // sintaxe
    void turnon(bool turn_on = false);   // definimos os métodos a serem implementado 
    void info();
}

public interface ICombat
{
    void fire();
}

class Car : IVehicle, ICombat   // sintaxe para herdar mais de uma classe e torna se necessário implementar todos os métodos definidos na interface
{
    public bool turn_on;
    private int weapons;
    public Car()
    {
        this.weapons = 100;
    }

    public void turnon(bool turn_on = false)
    {
        this.turn_on = turn_on;
    }

    public void fire()
    {
        this.weapons -= 1;
    }

    public void info()
    {

    }

    public int municao
    {
        get
        {
            return weapons;
        }
    }
}

class Interface
{
    static void Main()
    {
        Car car_one = new Car();
        car_one.turnon();
        Console.WriteLine("Carro está ligado? {0}\nMunição: {1}", car_one.turn_on, car_one.municao);
        Console.WriteLine("Tiro disparado!");
        car_one.fire();
        Console.WriteLine("Munição restante: {0}", car_one.municao);
    }
}

// nas classes interface não usamos campos, são necessário implementar métodos, e classe interface pode
// herdar, 