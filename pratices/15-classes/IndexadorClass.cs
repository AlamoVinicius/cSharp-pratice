using System;
class Vehicle
{
    private int[] velMax = {80, 120, 160, 250, 300, 34};

    public int this[int indice]   //use this para acessar ao indice do array e criar o indexador
    {
        get
        {
            return velMax[indice];
        }
        set
        {
            if (value < 0)
            {
                velMax[indice] = 0;
            }
            else if (value > 300)
            {
                velMax[indice] = 300;
            }
            else
            {
                velMax[indice] = value;
            }
        }
    }

    public Vehicle()
    {
        
    }

}


class IndexadorClass
{
    static void Main()
    {
        Vehicle carr_one = new Vehicle();  // instanciamento de objeto continua igual
        carr_one[5] = 200;    // atribuimos o método set a posiçaõ 5 do array 
        Console.WriteLine("Velocidade da posição 5: {0}", carr_one[5]);   // lemos o atributo da posição 5 do array
    }
}


// indexadores é um membro de uma classe que permite os objetos serem indexados como se fosse arrays.