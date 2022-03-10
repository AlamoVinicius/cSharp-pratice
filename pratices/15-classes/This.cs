using System;

class Calculator{
    public int value1;
    public int value2;

    public Calculator(int value1, int value2){
        this.value1 = value1;
        this.value2 = value2;
    }
    public int Somar(){
        return value1 + value2;
    }
}
class This
{
    static void Main(){
        
        Calculator calculos = new Calculator(10, 4);

        Console.WriteLine("A soma é: {0}", calculos.Somar());

    }
}