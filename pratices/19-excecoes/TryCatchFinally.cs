using System;

class TryCatchFinally
{
    static void Main()
    {
        int n1, n2, res = 0;
        n1 = 10;
        n2 = 0;

        try
        {
            res = n1 / n2;   // quando detectado o erro ele interrompe a execução do bloco try e continua o programa após o catch
            Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
        }
        catch (Exception err) // tratamento do erro é feito no bloco catch de acordo com  a necessidade do programa
        {
            Console.WriteLine("erro: {0}", err.Message); // apos armazenar a exception dentro do err temos acesso a algumas funcionalidades como .Message que irã exibir apenas a mensagem do erro tratado 
            Console.WriteLine("Tipo do erro: {0}", err.GetType());
            
        }
    }
}