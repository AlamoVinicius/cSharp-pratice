using System;

struct Car
{
    public string car_brand;
    public string car_model;
    public string color;
    
    public Car(string car_brand, string car_model, string color)  //sintaxe para struct
    {
        this.car_brand = car_brand;
        this.car_model = car_model;
        this.color = color;
    }

    public void info() {   // posso criar métodos dentro de um struct
        Console.WriteLine();
        Console.WriteLine("Marca: {0}\nModelo: {1}\nCor: {2}", this.car_brand, this.car_model, this.color);
    }
}
class Struct
{
    static void Main()
    {    // eu posso atribuir um valor para os atributos dessas 2 formas a seguir, na primeira usando atribuição 
        //individual, e no car_two, atribuimos passando os parâmetros no construtor que é ativado através da instanciação com o uso do operador new. que por sua vez ativa o construtor que é necessário os parâmetros obrigatório, se não gera um erro.
        Car car_one;
        car_one.car_brand = "FIAT";    // sintaxe para acessar propriedades, se alguma propriedade não for definida e ser acionado irá retornar um erro no programa principal 
        car_one.car_model = "Chronos";
        car_one.color = "Prata";
        car_one.info();
        
        Car car_two = new Car("bmw", "x1", "black");   // chamando o construtor para não precisar fazer igual ao carro 1
        car_two.info();
        Car car_3 = new Car("honda", "cb1000", "Golden");
        car_3.info();
        
    }
}

//struct pode armenizar tipo de dados diferentes, são acessados diretamente e não por referência, não pode ser herdada, mas podem ser inserido construtores, desde que o operador new seja acionado, o construtor iniciará