using System;

struct Car
{
    public string car_brand;
    public string car_model;
    public string color;

    public void info()
    {
        Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}", this.car_brand, this.car_model, this.color);
        Console.WriteLine("--------------------------");
    }
}
class ArrayStruct
{
    static void Main()
    {

        Console.Write("Digite a quantidade de veículos que irão ser adicionado: ");
        int controler = int.Parse(Console.ReadLine());
        Car[] cars = new Car[controler];   // sintaxe para add os objetos de struct como array
        for (int i = 0; i < controler; i++)     // método q eu encontrei para personalizar o array com o tamanho que eu quero 
        {  
            Console.WriteLine("Digite a marca do {0}º carro: ", i + 1);
            cars[i].car_brand = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro da marca {0}: ", cars[i].car_brand);
            cars[i].car_model = Console.ReadLine();
            Console.WriteLine("Digite a cor do carro: ");
            cars[i].color = Console.ReadLine();
        }
        Console.Clear();
        foreach (var item in cars)
        {
            item.info();
        }
    }
}

