using System;
class Pratice
{
    static void Main()
    {

        int num = 10, num2 = 20;
        num = num << 1;     // dobra o valor através do deslocamento de bit estudado 
        num2 = num2 >> 1;   // diminuindo o valor metade com o operador >>
        // obs : se ao invés de usar o 1 após o <<. iremos exponeciar o valor da váriavel pelo valor indicado seguindo as regras da programação e não da formula x elevado ao 2 na matematica
        int numTeste = 10, numTeste2 = 10;
        numTeste = numTeste << 2;   // resulta in 40
        numTeste2 = numTeste2 << 3;  // resulta in 80

        Console.WriteLine("Dobrando o valor de 10 com o operador << {0}", num);
        Console.WriteLine("Diminuindo o valor pela metade de 20 com o operador >> {0}", num2);
        Console.WriteLine("{0}, {1}",numTeste, numTeste2);
    }
}

// << Dobrar 
// >> metade