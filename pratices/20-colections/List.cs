using System;
using System.Collections.Generic;

class List
{
    static void Main()
    {
        List<string> cars = new List<string>();  // sintaxe para instanciar uma lista
        string[] cars2 = new string[10];
        cars.Add("golf");   // sintaxe para adicionar um elemnto 
        cars.Add("focus");
        cars.Add("fiesta");
        cars.Add("Argo");
        cars.Add("golf");

        //cars2.AddRange(cars);   // adiciona a lsita cars no cars2

        //cars2.Clear();// limpa todos os elementos da lista

        if (cars.Contains("fiesta"))   // Containes verifica se um elemento está na liista
        {
            Console.WriteLine("Está na lista");
        }
        else
        {
            Console.WriteLine("Veiculo não encontrado ");
        }

        cars.CopyTo(cars2, 2);

        cars.Insert(2, "Ferrari");   // add na posição indicada um valor
        int position = cars.LastIndexOf("golf");   // retorna o indice do ultimo valor 
        // cars.Remove(item) remove um itêm especifico cars.RemoveAll remove todos os elementos da lista
        cars.Remove("fiesta");
        //REmoveat remove um elemento de acordo com o seu idaxe indicado 
        cars.Reverse();  //inverte a lista
        cars.Capacity = 15;  // sintaxe para configurar tamanho da lista
        int lenght = cars.Count;  // retorna o tamanho da lista
        
        int capacity = cars.Capacity;  // retorna ou configura o tamanho da lista
        Console.WriteLine("Lenght: {0}\nCapacity: {1}", lenght, capacity);

        foreach (var item in cars)
        {
            Console.WriteLine("Carro: {0}", item);
        }
        string c ="focus";
        int pos = cars.IndexOf(c);
        Console.WriteLine("Carro {0} está na posição {1}", c, pos);   // -1 em outupt indica que não encontrou 
        Console.WriteLine("Ultima incidência do golf encontrado na posição: {0}", position);
    }
}