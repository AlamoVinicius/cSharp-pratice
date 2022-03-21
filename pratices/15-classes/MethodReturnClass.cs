using System;

class Chicken
{
    private string nameChicken;
    private int numEgg;

    private static int totalEggs;
    public Chicken(string nameChicken)
    {
        this.nameChicken = nameChicken;
        numEgg = 0;
    }

    public Egg putOn(int qtd_eggs)   // quantidade de eggs
    {   // sintaxe para retornar a class egg
        numEgg += qtd_eggs;   // controle da quantidadde de egg
        totalEggs+= qtd_eggs;
        return new Egg(numEgg, nameChicken, totalEggs);   // retora a criação de um objeto.
    }

   
}

class Egg
{
    private int numEgg;
    private string name_chicken;
    public Egg(int numEgg, string name_chicken, int totalEggs)
    {
        this.numEgg = numEgg;
        this.name_chicken = name_chicken;
        Console.WriteLine("A galinha botou {0} ovo, nome da galinha: {1}", this.numEgg, this.name_chicken);
        Console.WriteLine("Numero total de ovos; {0}", totalEggs);
    }
}

class MethodReturnClass
{
    static void Main()
    {
        Chicken chicken1 = new Chicken("Berenice");
        Chicken chicken2 = new Chicken("Geralda");
        Chicken chicken3 = new Chicken("Joana");

        chicken1.putOn(3);

        chicken2.putOn(2);

        chicken3.putOn(8);
        


    }
}