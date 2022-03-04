using System;
class Array
{
    static void Main()
    {
        /*int[,] array0 = new int[3, 5];    // para matriz acresenta uma virgula para controlar os índices

        /* matriz 3, 5 declarada exemplo: 
        10 20 30 40 50
        60 70 80 90 99
        12 23 23 43 32
        
        // sintaxe de matriz (tabela)
        
        array0[0, 0] = 10; array0[0, 1] = 20; array0[0, 2] = 30; array0[0, 3] = 40; array0[0, 4] = 50;

        array0[1, 0] = 60; array0[1, 1] = 70; array0[1, 2] = 80; array0[1, 3] = 90; array0[1, 4] = 99;

        array0[2, 0] = 12; array0[2, 1] = 23; array0[2, 2] = 23; array0[2, 3] = 43; array0[2, 4] = 32;
        */

        int[,] array0 = { { 10, 20, 30, 40, 50 }, { 60, 70, 80, 90, 99 }, { 12, 23, 23, 43, 32 } };  //fpr,a mais eficaz de declarar a mesma matriz do que as anteriores, neste caso todo o índice é gerado automaticamente. não é necessário pre-determinar o valores de tamanho da matriz

        Console.WriteLine(array0[1, 0]);

    }
}