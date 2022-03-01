// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Hello Álamo");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));    //get take the value of the determined index
            }

// obs.: use o comando dotnet new console para iniciar um novo programa dot net

/*
modo antigo:
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Álamo");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));    //get take the value of the determined index
            }
        }
    }
}
*/