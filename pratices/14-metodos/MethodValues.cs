using System;
class MethodValues
{
    static void Main() // ao usar o arg ref eu crio uma referencia para a váriavel poder ser manipulada fora do escopo principal, e não sendo necessário colocar um retono no meu método.
    {
        int num = 50;
        DoubleValue(ref num);
        Console.WriteLine(num);
    }

    static void DoubleValue(ref int value)
    {
        value *= 2;
    }
}