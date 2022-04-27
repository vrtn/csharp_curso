using System;

public class Jogador{
    public int energia;
    public bool vivo;

    public string nome;

    public Jogador(string n){
        energia = 100;
        vivo=true;
        nome = n;
    }

    ~Jogador(){
        Console.WriteLine("Jogador \"{0}\", destruído...",nome);
    }
}
class Aula29{
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o nome do Jogador 1: ");
        nome1 = Console.ReadLine();
        Jogador j1 = new Jogador(nome1);
        Jogador j2 = new Jogador("Teo");

        Console.Clear();

        j1.energia = 70;

        Console.WriteLine("Energia do {0}: {1}",j1.nome,j1.energia);
        Console.WriteLine("Energia do {0}: {1}",j2.nome,j2.energia);
    }
}