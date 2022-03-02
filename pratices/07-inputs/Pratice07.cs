using System;
class Pratice07
{
    static void Main()
    {
        int value1, value2, sum;
        string name;
        Console.Write("Write your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Hello master {0}, Welcome", name);

        Console.Write("Digite o primeiro valor: ");
        value1 = int.Parse(Console.ReadLine());    // there's two form to convert an input in integer number.
        Console.Write("Digite o segundo valor: ");
        value2 = Convert.ToInt32(Console.ReadLine());   //another way with Convert.ToInt32.
        sum = value1 + value2;
        Console.WriteLine("The sum betwen {0} and {1} is: {2}", value1, value2, sum);
    }
}