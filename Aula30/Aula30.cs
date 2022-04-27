using System;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }

    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    public Jogador(string n, int e){
        nome = n;
        energia = e;
        vivo = true;
    }

    public Jogador(string n, int e, bool v){
        nome = n;
        energia = e;
        vivo = v;
    }

    public void info(){
        Console.WriteLine("Jogador {0} infos: ",nome);
        Console.WriteLine("Energia..........: {0} %", energia);
        Console.WriteLine("Condição.........: {0}\n",vivo);
    }

    // ~Jogador(){
    //     Console.WriteLine("O jogador \"{0}\", foi destruído...",nome);
    // }
}
class Aula30{
    static void Main()
    {
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Bruno");
        Jogador j3 = new Jogador("Théo",100);
        Jogador j4 = new Jogador("Beneditis",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
}