using System;
using System.Collections.Generic;
class LinkedList
{
    static void Main()
    {
        LinkedList<string> transp = new LinkedList<string>();   //sintaxe
        transp.AddFirst("Car");   // adiciona um dado na lista
        transp.AddFirst("Airplane");
        transp.AddFirst("Motocycle");
        transp.AddFirst("ship");

        transp.AddLast("Bike");   // adiciona na ultima posição 

        LinkedListNode<string> element;
        element = transp.FindLast("ship").Next;  // adicionamos um elemento para a variavel do tipo linkedlistnode no, e usamos no método add depois "Next irá referenciar o próximo elemnto da lista
        //element = transp.FindLast("ship").Value; // retorna o valor da lista
        transp.AddAfter(element, "aviao");
        transp.AddBefore(element, "skate");   // add antes do elemento da váriavel 

        //transp.clear();  limpa toda a lista
        if (transp.Find("Car") == null)
        {
            Console.WriteLine("Elemento não encontrado");
        }
        else
        {
            Console.WriteLine("Elemento encontrado na lista");
        };

        transp.Remove("ship");   // remove um elemento especificado através do valor
        // transp.RemoveFirst(); and transp.RemoveLast();  remove primeiro e ultimo elemento respectivamentes da lista
        foreach (string item in transp)
        {
            Console.WriteLine("Transporte: {0}", item);
        }
    }
}