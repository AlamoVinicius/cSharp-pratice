using System;
class Pratice09
{  // usando o enum posso criar o meu tipo de váriavel
    enum WeekDays
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    static void Main()
    {
        WeekDays ds = WeekDays.Wednesday;
        Console.WriteLine(ds);

        // fazendo com cast em caso de valores não enumerados
        WeekDays ds2 = (WeekDays)3;
        Console.WriteLine(ds2);

        //também podemos usar dessa forma para obter um valor int do indice dos enum, assim podendo usar em operações lpogicas
        int ds3 = (int)WeekDays.Sunday;
        Console.WriteLine(ds3);  // resultado será zero de acordo com o enum que eu programei fora do void Main().
    }
}