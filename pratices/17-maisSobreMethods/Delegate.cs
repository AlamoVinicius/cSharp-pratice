using System;

delegate int Operation(params int[] number);
//delegate int OperationDouble(int x);  // aqui eu criei um novo delegate para pois meu método valueDouble só aceita um parãmetro , ou eu poderia ajustar o metodo value double para aceitar um array e limitar o Lengh com mais de 1.
class Math
{
    public static int sum(params int[] numbers)
    {
        var result = 0;
        foreach (var item in numbers)
        {
            result += item;
        }
        return result;
    }

    /*public static int valueDouble(int x)
    {
        return x * 2;
    }*/

    public static int valueDouble(params int[] numbers)
    {
        if (numbers.Length > 1)
        {
            Console.WriteLine("[erro] O método valueDouble não aceita mais de 1 valor");
            return -1;
        }
        else
        {
            return numbers[0] * 2;
        }
    }

    public static int mult(params int[] numbers)
    {
        var result = 1;
        foreach (var item in numbers)
        {
            result *= item;
        }
        return result;
    }
}

class Delegate
{
    static void Main()
    {
        int result = 0;
        Operation delegate1 = new Operation(Math.sum);  // sintaxe para acessar
        //OperationDouble delegate2 = new OperationDouble(Math.valueDouble);
        result = delegate1(10, 30);  // resultdado esperado 40
        Console.WriteLine(result);

        delegate1 = new Operation(Math.mult);
        result = delegate1(10, 2); // resultado esperado 20
        Console.WriteLine(result);

        delegate1 = new Operation(Math.valueDouble);  // por mais que a chamada do método aceite um array, eu coloquei um erro que impede mais que um valor, para retornar o dobro de um valor, não é o método recomendado porêm quis usar exemplo para usar apenas um delegated na qual todos aceitem arrays como entrada.
        result = delegate1(8);  // resultado esperado 10
        Console.WriteLine(result);
    }
}

// delegate criamos uma referencia para um método da classe e podemos usar no programa principal 