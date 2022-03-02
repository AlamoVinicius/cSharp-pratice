// formatação de strings


using System;

class Pratice05
{
    static void Main()
    {
        int n1, n2, n3;
        n1 = 10; n2 = 20;
        n3 = 30;
        Console.WriteLine(n1 + ", " + n2 + ", " + n3);
        // método formatado strings
        Console.WriteLine("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}", n1, n2, n3);  //\n quebra de linha \t inseri uma tabulação

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "pastel";
        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto..........:{0,15}", produto);  // 0 => indíce ,15 => distanica de espaçamento
        Console.WriteLine("Val compra.......:{0,15:c}", valorCompra);   // :c = valor monetário
        Console.WriteLine("Lucro............:{0,15:p}", lucro);      // :p valor em porcentagem
        Console.WriteLine("Val da venda.....:{0,15:c}", valorVenda); 
    }
}