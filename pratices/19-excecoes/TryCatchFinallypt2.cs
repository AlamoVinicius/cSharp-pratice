using System;

class Area
{
    public static float Quadrado(float bas, float height)   // exemplo de criação de uma class com um erro 
    {
        if(bas == 0 || height == 0){
            throw new Exception("Base ou altura não podem ser igual a zero");
        }
        return bas * height;
    }
}

class TryCatchFinallypt2
{
    static void Main()
    {   
        float area = 0;
        int n1, n2, res = 0;
        n1 = 10;
        n2 = 2;

        try
        {   
            area = Area.Quadrado(10f, 5f);
            Console.WriteLine("Area do quadrado: {0}", area);
            res = n1 / n2;
            Console.WriteLine("{0} / {1} = {2}", n1, n2, res);
        }
        catch (Exception err)
        {
            Console.WriteLine("erro: {0}", err.Message);
            Console.WriteLine("Tipo do erro: {0}", err.GetType());
        }
        finally   // executa o bloco independente do erro 
        {
            Console.WriteLine("Fim do processo");
        }
    }
}