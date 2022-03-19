using System;
class Vehicle
{
    private int velMax = 0;

    public int vm   // implementação do atributo com os métodos get e set, ela pode ser so set ou so get
    {
        get
        {
            return velMax;   // get apenas retorna o valor de velMax
        }
        set
        {
            if (value < 0)    // value é uma palavra reservda da linguagem, automáticamente ela acessa aos valores atribuidos no atributo 
            {
                velMax = 0;
            }
            else if (value > 300)
            {
                velMax = 300;
            }
            else
            {
                velMax = value;
            }
        }
    }

    public Vehicle()
    {   
        this.vm = 120;
    }

}


class AcessorsGetAndSet
{
    static void Main()
    {
        Vehicle carr_one = new Vehicle();
        carr_one.vm = 200;  // automaticamente a atribuição acessa o método set da propriedade
        Console.WriteLine("Velocidade: {0}", carr_one.vm);  //automaticamente esse atributo acesse o metodo get da propriedade
    }
}