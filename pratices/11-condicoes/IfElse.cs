using System;
class Pratice11
{
    static void Main()
    {
        string result;
        Console.Write("Digite a nota 1: ");
        float n1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        float n2 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        float n3 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        float n4 = float.Parse(Console.ReadLine());

        float media = (n1 + n2 + n3 + n4) / 4;

        Console.WriteLine("A media foi de: {0}", media);
        if (media < 40)
        {
            result = "Reprovado";
        }
        else if (media < 60)
        {
            result = "Recuperação";
        }
        else
        {
            result = "Aprovado";
        }

        Console.WriteLine("Resultado: {0}!", result);
    }
}