using System;
class DoWhile
{
    static void Main()
    {
        int num = 5;
        do
        {
            Console.WriteLine("Hello Álamo");
        } while (num < 5);

        string senha = "123";
        string senhaUser;
        int tentativas = 1;

        do
        {
            Console.Write("Digite sua senha: ");
            senhaUser = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Senha errada! numero da tentativa => {0}", tentativas);

            tentativas++;
        } while (senhaUser != senha);
        Console.Clear();
        Console.WriteLine("Seja bem vindo usuário!");

    }
}