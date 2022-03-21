using System;

class Calculator
{
    public int sum(params int[] numbers)  // método com valores indefinidos no parãmetro
    {   
        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }
        return sum;
    }

    public double sum(params double[] numbers) //sobrecarga com o tipo double 
    {
        double sum = 0;
        foreach (double item in numbers)
        {
            sum += item;
        }
        return sum;
    }

    public int sum(int x, int y, int z)   // overload do método sum com 3 parâmetros
    {
        return x + y + z;
    }

    public int sum(int value1, int value2, int value3, int value4)  // de acordo com o número de parãmetros a sobrecarga de métodos automaticamente seleciona o método correto.
    {
        return value1 + value2 + value3 + value4;
    }

}
class OverloadMethods
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        var result = calculator.sum(10, 4.5, 12, 4, 5, 6.2);   // usando var para não se preucupar com o tipo.
        Console.WriteLine(result);
    }
}