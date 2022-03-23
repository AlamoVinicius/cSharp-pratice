using System;

class Math
{
    public static double pi = 3.14;   // valor static 

    public static int valuedouble(int x)
    {
        return x * 2;
    }
}
class StaticMethodsAndVariable
{
    static void Main()
    {
        double valuePi = Math.pi;   // podemos acessar um memrbo static com essa sintaxe
        int num = 10;
        Console.WriteLine("Valor do pi {0}, dobro de {1} => {2}.", valuePi, num, Math.valuedouble(num));  // class math que eu criei na linha 3, e seu método, dessa forma não é necessário declarar um objeto Math.
    }
}

// usamos static