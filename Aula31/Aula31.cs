using System;

class Inimigo
{
    public string nome;
    static public bool alerta;

    public Inimigo(string n)
    {
        nome = n;
        alerta = false;
    }

    public void info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("-----------------");
    }
}

static class Jogador
{
    static public string nome;
    static public int energia;
    static public bool vivo;

    static public void iniciar(string n)
    {
        nome = n;
        energia = 100;
        vivo = true;
    }

    static public void info()
    {
        Console.WriteLine("Informações do jogador ..: {0}", nome);
        Console.WriteLine("Energia..................: {0}", energia);
        Console.WriteLine("Vida.....................: {0}", vivo);
    }
}

class Aula31
{

    static void Main()
    {
        Jogador.iniciar("Zanini");
        Jogador.info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Bobo");
        Inimigo i3 = new Inimigo("Bocó");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info(); 
    }
}