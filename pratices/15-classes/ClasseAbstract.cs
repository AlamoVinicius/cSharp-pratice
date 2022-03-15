using System;

abstract class Vehicle  // classe base abstract
{
    protected int velMax;   // pode ser acessado apenas pelas classe derivadas
    protected int VelAtual;
    protected bool engine_on;
    public Vehicle()
    {
        engine_on = false;
        VelAtual = 0;
    }

    public void setEnguine(bool enguine_on)  // método que não é abstrado é necessário ser implementado a sua funcionalidade
    {
        this.engine_on = enguine_on;
    }

    public int getVelAtual(){
        return VelAtual;
    }
    abstract public void acceleration(int accMulti);   // ao definir abstract é necessário implementar esse método nas classes filho
}

class Car : Vehicle
{
    public Car()
    {
        velMax = 120;
    }

    override public void acceleration(int accMulti)  // override sobrescreve o método
    {   
        VelAtual += 10 * accMulti;
    }
}

class ClasseAbstract
{
    static void Main()
    {
        Car car_one = new Car();
        car_one.acceleration(10);
        car_one.acceleration(-3);
        Console.WriteLine(car_one.getVelAtual());
    }
}

// classe base serve como refêrencia para classes que irão herda-la, se a classe base estiver abstrata todas as herdadas são obrigadas a ter a classe abstract, classe abstract não pode ter objetos instanicados