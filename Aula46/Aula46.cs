using System;

class Galinha
{
    private string nomeGalinha;
    private int numOvos;

    public Galinha(string nomeGalinha)
    {
        this.nomeGalinha = nomeGalinha;
        this.numOvos = 0;
    }

    public Ovo botar()
    {
        this.numOvos += 1;
        return new Ovo(numOvos,nomeGalinha);
    }

    public void info()
    {
        Console.WriteLine("\nGalinha: {0}",this.nomeGalinha);
        Console.WriteLine("Ovos...: {0}",this.numOvos);
        Console.WriteLine("----------------------");
    }
}

class Ovo
{
    private int ovo;
    private string nomeGalinha;
    public Ovo(int ovo, string nomeGalinha)
    {
        this.ovo = ovo;
        this.nomeGalinha = nomeGalinha;
        Console.WriteLine("{0} botou o ovo nº {1}.",this.nomeGalinha,this.ovo);
    }
}
class Aula46
{
    static void Main()
    {
        Galinha g1 = new Galinha("Gilda");
        Galinha g2 = new Galinha("Bica");
        Galinha g3 = new Galinha("Zezé");

        g1.botar();
        g2.botar();
        g2.botar();
        g2.botar();
        g3.botar();
        g3.botar();

        g1.info();
        g2.info();
        g3.info();
    }
}