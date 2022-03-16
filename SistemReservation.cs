using System;

class Estacao
{
    public int date;
    int hour_start;
    int hour_end;
    public Estacao()
    {
        date = 17;
        hour_start = 12;
        hour_end = 18;
    }

    public void makeReservation(int data, int ini_hour, int final_hour, string name)
    {
        // mapeia banco de dados
        if (data == this.date && ini_hour == this.hour_start)
        {
            Console.WriteLine("erro horário ja reservado!");
        }
        else if (data == this.date && final_hour > hour_start && final_hour < hour_end)
        {
            Console.WriteLine("Não é possivel reservar um horário final ja reservado.");
        }
        else if (final_hour - ini_hour > 6)
        {
            Console.WriteLine("Não é possivel reservar mais que 6 horas para a estação selecionada");
        }
        else
        {
            Console.WriteLine("Horário dia {0},  {1}:00 às {2}:00 reservado com sucesso por: {3}", data, ini_hour, final_hour, name);
        }
    }
}
class SistemReservation
{
    static void Main()
    {
        // dados vindo do database
        int dia = 16;
        int start_hour = 12;
        int final_hour = 18;
        string name = "Álamo";

        Estacao reserva1 = new Estacao();
        Estacao reserva2 = new Estacao();
        reserva1.makeReservation(dia, start_hour, final_hour, name);
        reserva2.makeReservation(17, 12, 18, "Pessoa aleatória");

    }
}