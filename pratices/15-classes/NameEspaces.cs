using System;

namespace Calc1   // organiza um escopo para um bloco especifico 
{
    class Area
    {
        public static float Quadrado(float bas, float height)   // exemplo de criação de uma class com um erro 
        {
            if (bas == 0 || height == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return bas * height;
        }

        public static float power(float value, float exponent)
        {
            if (value == 0 || exponent == 0)
            {
               throw new Exception("Não é possivel realizar operações com valores = 0");
            }
            return (float)Math.Pow(value, exponent);
            
        }
    }
}

namespace Calc2   // criando um novo name space é possivel criar uma nova classe com o mesmo nome.
{
    class Area
    {
        public static float Quadrado(float bas, float height)   // exemplo de criação de uma class com um erro 
        {
            if (bas == 0 || height == 0)
            {
                throw new Exception("Base ou altura não podem ser igual a zero");
            }
            return bas * height;
        }
    }
}

class NameEspaces
{
    static void Main()
    {
        float area, power_value = 0;
        int n1, n2, res = 0;
        n1 = 10;
        n2 = 2;

        try
        {
            area = Calc1.Area.Quadrado(10f, 5f);   // é necessário indicar o name espaçe na instançiação do objeto 
            Console.WriteLine("Area do quadrado: {0}", area);
            res = n1 / n2;
            Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
            power_value = Calc1.Area.power(10.25f, 2f);
            Console.WriteLine(power_value);
        }
        catch (Exception err)
        {
            Console.WriteLine("erro: {0}", err.Message);
            Console.WriteLine("Tipo do erro: {0}", err.GetType());
        }
        finally
        {
            Console.WriteLine("Fim do processo");
        }
    }
}