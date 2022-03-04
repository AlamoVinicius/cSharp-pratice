using System;
class While
{
    static void Main()
    {
        int[] arry = new int[10];

        int count = arry.Length - 1;
        while (count > 0)
        {
            arry[count] = count;
            Console.WriteLine(arry[count]);
            count--;
        }

        Console.WriteLine("programing end...");
    }
}