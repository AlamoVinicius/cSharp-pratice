using System;
class MethodValues
{
    static void Main()
    {
        int dividendo, divisor, quociente, rest;
        dividendo = 10;
        divisor = 5;
        quociente = divide(dividendo, divisor, out rest); // repare que o rest tmb é passado nesse parâmetro.
        Console.WriteLine("{0}/{1} : quociente = {2} and rest = {3}", dividendo, divisor, quociente, rest);
    }

    static int divide(int dividendo, int divisor, out int rest)
    {
        int quociente = dividendo / divisor;
        rest = dividendo % divisor;    //% = divisor real
        return quociente;
    }
}

// usando o parâmetro out na passagem de args, podemos fazer com que o método retorne 2 valores