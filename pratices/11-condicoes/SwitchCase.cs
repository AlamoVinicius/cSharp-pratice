using System;
class SwitchCase
{
    static void Main()
    {
        int time = 0;

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Opçoes: [a] Avião | [c] Carro | [o] Ônibus ");

        char choise = char.Parse(Console.ReadLine());
        switch (choise)
        {
            case 'a':
                time = 50;
                break;

            case 'c':
                time = 480;
                break;

            case 'o':
                time = 660;
                break;

            default:
                time = -1;
                break;
        }

        if (time < 0)
        {
            Console.WriteLine("Transporte inexistente!");
        }else {
            Console.WriteLine("Tempo de viagem {0} minutos", time);
        }
    }
}