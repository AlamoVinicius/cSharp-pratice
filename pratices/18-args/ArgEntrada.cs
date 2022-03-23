using System;

class ArgEntrada
{
    static void Main(string[] args)   // criar lista de args que passamos na chamada do programa (console)
    {
        if (args.Length > 0)
        {
            Console.WriteLine("Qtde de argumentos {0}", args.Length);  // a partir dai posso fazer o que quiser com os args, operação matematica, mensagem personzalizada encaminhamento do programa etc...
            Console.Write("Argumentos passados: ");
            foreach (var item in args)
            {
                Console.Write(" - {0}", item);
            }
        }
        else
        {
            Console.WriteLine("Não existem argumentos");
        }
    }
}