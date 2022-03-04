using System;
class Foor
{
    static void Main()
    {   
        int[] arry = new int[10];

        for (int i = 0; i < arry.Length; i++)
        {   
            arry[i] = i;
            Console.Write("{0}, ", arry[i]);
        }
    }
}