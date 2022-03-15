using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Constructor base class");
    }
}

class Derivative1 : Base
{
    public Derivative1()
    {
        Console.WriteLine("Constructor base Derivative1");
    }
}

class Derivative2 : Derivative1
{
    public Derivative2()
    {
        Console.WriteLine("Constructor base Derative2");
    }
}

class OrdemExecucao
{
    static void Main()
    {
        Derivative2 Derivate2 = new Derivative2();
    }
}

// Ordem de execução dos contrutores sempre se iniciará da base para a Derivada. 