using System;
class SwitchCase
{
    static void Main()
    {
        int time = 0;

        start:

        Console.Clear();    

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Opçoes: [a] Avião | [c] Carro | [o] Ônibus ");

        char choise = char.Parse(Console.ReadLine());
        switch (choise)
        {
            case 'a':
            case 'A':
                time = 50;
                break;

            case 'c':
            case 'C':
                time = 480;
                break;

            case 'o':
            case 'O':
                time = 660;
                break;

            default:
                time = -1;
                break;
        }

        if (time < 0)
        {
            Console.WriteLine("Transporte inexistente!");
        }
        else
        {
            Console.WriteLine("Tempo de viagem {0} minutos", time);
        }

        Console.Write("Calcular outro transporte? [s/n]");
         choise = char.Parse(Console.ReadLine());
         if(choise == 's' || choise == 'S') {
             goto start;    // usando o goto eu posso desviar meu programa para um label determinado, parece ser uma escolha interessante ao uso dos loop convêncionais estudados em outras linguagens de programação.
         } else {
             Console.Clear();
             Console.WriteLine("Final do programa");
         }
    }
}