using System;

public interface IVeiculo
{
    void ligar();
    void desligar();
    void info();
}

public interface ICombate
{
    void disparar();
}

class Carro:IVeiculo,ICombate
{
    private int municao{get; set;}
    public Carro()
    { 
        this.municao = 100;
    }

    public bool ligado;

    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.ligado = false;
    }
    public void info()
    { }
    public void disparar()
    { }
}
class Aula43
{
    static void Main()
    {
        Carro c1 = new Carro();
    }
}