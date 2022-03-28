using System;
using System.Collections.Generic;

class Queue
{
    static void Main()
    {
        string[] vehicleArry = { "Carro", "Moto", "Navio", "Avião" };
        Queue<string> vehicles = new Queue<string>(vehicleArry);  // queue ja tem um construtor que aceita um array

        vehicles.Enqueue("bicileta"); // sintaxe para add elementos em uma queue, neste caso foi add na ultima posição
        // alguns outros métodos como container e count tmb podem ser aplicado nas Queue como Contains(), count(), Clear(), remove(), etc.

        String element = "Moto";
        string resp = vehicles.Contains(element) ? "Veículo '" + element + "' encontrado" : "Veículo '" + element + "' não encontrado";
        Console.WriteLine(resp);

        Console.WriteLine("Primeiro elemento da lista {0}", vehicles.Dequeue()); // retorna o primeiro elemnto da lista e remove ele 
        Console.WriteLine("Primeiro elemento da lista {0}", vehicles.Peek());  // retorna o valor do primeiro elemento da pilha porêm não o retorna
        Console.WriteLine("----------------------");
        // vehicles.Clear(); posso remover os items da queue desse modo ou de um jeito mais legal :

        while (vehicles.Count > 0)  // exibi a informação de que tal elemento foi eliminado e exluic ele logo em seguida
        {
            Console.WriteLine("Elemento {0} eliminado com sucesso!", vehicles.Dequeue());
        }

        if (vehicles.Count > 0)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item);
            }
        } else {
            Console.WriteLine("Não existem elementos nessa colection");
        }

    }
}

// queue funciona como as pilhas em outras linguagens e manipulamos sempre primeiro que entra primeiro que sai , não é possivel usar o indexador em uma queue