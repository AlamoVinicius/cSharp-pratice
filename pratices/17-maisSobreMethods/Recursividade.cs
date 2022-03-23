using System;

class Calculator
{
    public int sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        return sum;
    }

    public double sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double item in numbers)
        {
            sum += item;
        }
        return sum;
    }

    public int factorial(int n)
    {
        int result;
        if (n <= 1)
        {
            result = 1;   // controle 
        }
        else
        {   
            
            result = n * factorial(n - 1);
            Console.WriteLine(result);
        }

        return result;
    }  
    // 
}
class Recursividade
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        var result = calculator.sum(10, 4.5, 12, 4, 5, 6.2);
        Console.WriteLine(result);
        int factorial = calculator.factorial(5);
        Console.WriteLine(factorial);
    }
}

// recursvidade são funões que precisam chamar ela mesmo