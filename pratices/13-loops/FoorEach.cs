using System;
class ForEach
{
    static void Main()
    {

        int[] arry = { 11, 22, 33, 44, 55, 66, 77, 88, 99, 101 };
        /* for / foreach
                for (int cont = 0; cont < arry.Length; cont++)
                {
                    Console.WriteLine(arry[cont]);
                }*/

        foreach (int item in arry)
        {
            Console.WriteLine(item);
        }
    }
}