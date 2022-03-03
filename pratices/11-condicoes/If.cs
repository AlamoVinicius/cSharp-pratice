using System;
class If
{
    static void Main()
    {
        
        string result = "Reprovado";

        Console.Write("Digite a nota 1: ");
        float n1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        float n2 =float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        float n3 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        float n4 = float.Parse(Console.ReadLine());

        float media = (n1 + n2 + n3 + n4) / 4;


        if (media >= 60)
        {   
            Console.WriteLine("A media foi de: {0}", media);
            result = "Aprovado!";
        }

        Console.WriteLine("Resultado: {0}", result);
    }
}