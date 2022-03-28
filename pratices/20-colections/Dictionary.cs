using System;
using System.Collections.Generic;   // para usar o dicionário em c# é necessario usar a lib Collections

class Dictionary
{
    static void Main()
    {
        Dictionary<int, string> vehicles = new Dictionary<int, string>();  // sintaxe

        vehicles.Add(10, "Car");    //chave 10 value carro  sintaxe de atribuição 
        vehicles.Add(5, "Airplane");
        vehicles.Add(0, "Naveship");
        vehicles.Add(20, "Motocycle");
        vehicles.Add(3, "Byke");
        // vehicles.Clear(); limpa a colection  

        vehicles.Remove(20);   // remove a chave definida


        Console.WriteLine("Dictionary Length: {0}", vehicles.Count);  // retorna o tamanho da colection
        int key = 20;
        if (vehicles.ContainsKey(key))   // retonra true no caso de a chave está na coleção.
        {
            Console.WriteLine("The key {0} is in the collection", key);
        }
        else
        {
            Console.WriteLine("The key {0} isn't the collection", key);
        }

        vehicles[3] = "bicicleta";   // altera o valor da chave

        var value = "bicicleta";
        if (vehicles.ContainsValue(value))   // retonra true no caso do valor está na coleção.
        {
            Console.WriteLine("The key {0} is in the collection", value);
        }
        else
        {
            Console.WriteLine("The key {0} isn't the collection", value);
        }

        foreach (var item in vehicles)     // código para imprimir toda a coleção
        {
            Console.WriteLine(item);
        }

        foreach (KeyValuePair<int, string> item in vehicles)  // posso usar dessa outra forma também 
        {
            Console.WriteLine(item.Key);
        }
        Console.WriteLine("------------another way--------------");

        Dictionary<int, String>.ValueCollection values = vehicles.Values;

        foreach (string item in values)
        {
            Console.WriteLine(item);
        }
    }
}