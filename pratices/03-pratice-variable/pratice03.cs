using System;
class Pratice03
{
    static void Main()
    {
        byte n1 = 10;    // 0 e 255 
        int num = 0;     // integer number
        char letra = 'a';   //only a character
        float valor = 7.4f;  //float em c# é necessário usar o f para correlacionar ao tipo float
        string nome = "Álamo";  // not only a character

        var aux = nome;    // var auto não especifica o tipo da váriavel

        int num1, num2, res;  // podemos declarar a váriavel

        num1 = 10;
        num2 = 20;
        res = num1 * num2;

        Console.Write("The result is: "+ res);
    }

}


// Em c# definimos o tipo da váriavel ates do seu indicador , o valor não é obrigatório pois se não definir zero automaticamente a linguagem irá determinzar 0 como valor padrão.