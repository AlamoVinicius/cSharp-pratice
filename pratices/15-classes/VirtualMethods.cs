using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Constructor base class");
    }

    virtual public void info()   // virtual indica ser um método virtual que irá ser sobreescrito não é necessário inserir um conteudo pois ele será sobrescrevido 
    {
    }
}

class Derivative1 : Base
{
    public Derivative1()
    {
        Console.WriteLine("Constructor base Derivative1");
    }

    override public void info()    // override sobrescreve na classe derivada
    {
        Console.WriteLine("Derivative 1");
    }
}

class Derivative2 : Derivative1
{
    public Derivative2()
    {
        Console.WriteLine("Constructor base Derivative2");
    }

    override public void info()
    {
        Console.WriteLine("Derivative 2");
    }
}

class VirualMethods
{
    static void Main()
    {
        Base reference;
        Derivative1 derivate1 = new Derivative1();
        Derivative2 derivate2 = new Derivative2();
        reference = derivate2;   // atribuindo o objeto ao elemento reference assim tornando possível o acesso ao método virtual de cada classe

        reference.info();
    }
}

// metodo q tenha o mesmo nome da classe base e executa uma função diferente é necessario usar o VirtualMethods com a palavras virtual e override