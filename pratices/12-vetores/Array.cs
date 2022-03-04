using System;
class Array
{
    static void Main()
    {
        int[] array0 = new int[5];     //uma das formas array com 5 elementos
        array0[0] = 111;     // armazenar elemento na posição 0 do array
        array0[1] = 222;
        array0[2] = 333;
        array0[3] = 444;
        array0[4] = 555;
        Console.WriteLine(array0[4]);

        int[] array1 = new int[3] { 1, 2, 3 };   // o valor [3] indica tamanho do array
        Console.WriteLine(array1[0]);

        int[] array2 = { 55, 77, 99 };    // forma com o tamanho automático
        Console.WriteLine(array2[1]);

        string[] vehicles = {"Car", "Airplane", "Motocycle"};
        Console.WriteLine(vehicles[0]);
        

    }
}