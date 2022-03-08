using System;
class Methods
{
    static void Main()
    {
        // variables used in this program
        string name_user;
        int number1, number2, sum;


        Console.Write("Tap your name please: ");
        name_user = Console.ReadLine();
        Hello(name_user);

        Console.Write("Lets count something? please tell me a number: ");
        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("All right, very good, now please tell me another number: ");
        number2 = int.Parse(Console.ReadLine());

        sum = Sum(number1, number2);

        Console.Clear();
        Console.WriteLine("The sum betwen {0} and {1} is {2}", number1, number2, sum);
    }

    static int Sum(int value1, int value2)   // método com retorno substitui o void pelo type
    {
        int sum = value1 + value2;
        return sum;
    }

    static void Hello(string name)
    {    // método statico ja que iremos usar em outro método statico. void inica que o não tem retorno
        Console.WriteLine("Hello {0}.", name);
    }
}