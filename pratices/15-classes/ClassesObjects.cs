using System;

public class Player// no caso de classes que não usa um modificador especificado ela automaticamente sera public
{
    public int energy = 100;
    public bool live = true;
}
class ClassesObjects   
{
    static void Main()
    {
        Player p1 = new Player();  //new instancia com a classe
        Player p2 = new Player();
        Player p3 = new Player();
        p1.energy = 50;
        Console.WriteLine("Player 1 energy: {0}", p1.energy);
        Console.WriteLine("Player 2 energy: {0}", p2.energy);
    }
}

/* sintaxe padrão:
[ModificadorClasses] class NOME_DA_CLASSE {
    // variables / properties
    
    //Methodos: Classe
    [EspecificadorAcesso] retorno NOME_MÉTODO([arg1], ...){
        // Method body
    }
}



// modificadorClasse: Define a visibilidade da classe
    //public: pública, sem restrição de visualização
    //abstract: Classe-base para outras classes, não podem ser intanciados objetos desta classe
    //sealed: Classe não pode ser herdada
    //static: Classe não permite a instanicação de objetos e seus membros devem ser static

//EsoecificadorAcesso: Onde um membro da classe pode ser acessada
    //public: Sem restrição de acesso
    //private: só podem ser acessados pela própria classe
    //protected: Podem ser acessados na própria classe e nas classes derivadas
    //abstract: Os métodos não tem implementaão somente os cabeçalhos
    //sealed:   O método não pode ser redefinido
    //virtual:  O método pode ser redefinido em uma classe derivada
    //static: O método pode ser chamado mesmo sem a instanciação de um objeto
    */