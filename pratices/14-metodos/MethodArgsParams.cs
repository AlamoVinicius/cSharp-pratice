using System;
class MethodArgsParams
{
    static void Main()
    {
        sum(10, -5, 2, -3, -4);
    }

    static void sum(params int[] numbers)
    {
        int sum = 0;

        if (numbers.Length == 0)
        {
            Console.WriteLine("[Err] There are no values to make the sum.");
        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("[Err] Insufficient values to make the sum: {0} ", numbers[0]);
        }
        else
        {
            foreach (int values in numbers)
            {
                sum += values;
            }
            Console.WriteLine("The total sum of the values is: {0}", sum);
        }
    }
}

//Nesse programa poderemos passar quantos valors necessário para realizar a soma, salvo um ou zero valores, pois não é possivel.