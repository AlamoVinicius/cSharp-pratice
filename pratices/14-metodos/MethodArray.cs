using System;

class MethodArray
{
    static void Main()
    {
        int[] arry1 = new int[5];
        int[] arry2 = new int[5];
        int[] arry3 = new int[5];
        int[,] matriz = { { 11, 22, 00, 44, 55 }, { 66, 77, 88, 99, 00 } };
        // método Random  sorteamos 5 valores entre 1 e 60 e preenchemos o arry1
        Random random = new Random();
        for (int i = 0; i < arry1.Length; i++)
        {
            arry1[i] = random.Next(1, 60);     // metodo random eu posso escolher o valor minimo ou maximo
        }

        foreach (int elements in arry1)
        {
            Console.WriteLine(elements);
        }

        //pesquisar valor dentro de um array: public static int BinarySearch(array,valor);
        Console.WriteLine("BinarySearch");
        int SearchValue = 33;
        int indice = Array.BinarySearch(arry1, SearchValue);
        Console.WriteLine("O valor {0} está na posição {1}", SearchValue, indice);
        Console.WriteLine("----------------------------------------------");

        // copiando uma array com Copy
        Console.WriteLine("Copy");
        Array.Copy(arry1, arry2, arry1.Length);
        foreach (int items in arry2)
        {
            Console.WriteLine(items);
        }
        Console.WriteLine("----------------------------------------------");

        // Copiando um array a partir do vetor com Copyto
        Console.WriteLine("Copyto");
        arry1.CopyTo(arry3, 0);
        foreach (int items in arry3)
        {
            Console.WriteLine(items);
        }
        Console.WriteLine("----------------------------------------------");

        // GetLongLenght retorna a dimensão do array0
        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor = arry1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}", qtdeElementosVetor);
        Console.WriteLine("----------------------------------------------");

        // GetlowerBound retorna o menor indice de um array ou matriz no caso de array o parâmetro é zero e matriz é necessário indicar a dimensão.
        Console.WriteLine("GetLowerBound");
        int LowIndice = arry1.GetLowerBound(0);
        int lowIndiceMatriz_d1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do arry1 {0}", LowIndice);
        Console.WriteLine("Menor indice da matriz {0}", lowIndiceMatriz_d1);
        Console.WriteLine("----------------------------------------------");
        // GetUpperBound retorna o maior inice nas mesmas regras do método anterior

        // GetValue retorna um valor através de um indice, nesse caso se trata de um object é necessário converterlo com catch
        Console.WriteLine("GetValue");
        int v1 = (int)arry1.GetValue(3);
        Console.WriteLine("Valor na posição 3 do arry1 {0}", v1);
        Console.WriteLine("----------------------------------------------");

        // Indexof retorna o indice através de um valor indicador, no caso de elementos repetido ele retorna apenas o valor da primeira incidência
        Console.WriteLine("IndexOf");
        int indice1 = Array.IndexOf(arry1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);
        Console.WriteLine("----------------------------------------------");

        // LastIndexOp retora a oposição do indice do ultimo valor
        Console.WriteLine("LastIndexOf");
        int indice2 = Array.LastIndexOf(arry1, 3);
        Console.WriteLine("Indice do ultimo valor 3: {0}", indice2);
        Console.WriteLine("----------------------------------------------");

        // Reverse inverte a ordem dos elementos
        Console.WriteLine("Reverse");
        Array.Reverse(arry1);
        foreach (int items in arry1)
        {
            Console.WriteLine(items);
        }
        Console.WriteLine("----------------------------------------------");

        // SetValue Defini um valor em uma posição no array
        Console.WriteLine("SetValue");
        arry2.SetValue(99, 0);   //inserimos o valor 99 na posição zero do segundo array
        for (int i = 0; i < arry2.Length; i++)
        {
            arry2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2");
        foreach (int items in arry2)
        {
            Console.WriteLine(items);
        }
        Console.WriteLine("----------------------------------------------");

        // Sort ordena o valor em ordem crescente do array
        Console.WriteLine("Sort");
        Array.Sort(arry1);
        Array.Sort(arry2);
        Array.Sort(arry3);

        Console.WriteLine("Arry1");
        foreach (int items in arry1)
        {
            Console.WriteLine(items);
        }

        Console.WriteLine("Arry2");
        foreach (int items in arry2)
        {
            Console.WriteLine(items);
        }

        Console.WriteLine("Arry3");
        foreach (int items in arry3)
        {
            Console.WriteLine(items);
        }
    }
}