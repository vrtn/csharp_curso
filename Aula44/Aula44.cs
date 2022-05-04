using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
}
class Aula44
{
    static void Main()
    {
        Carro c1;

        c1.marca = "Ford";
        c1.modelo="Mondeo";
        c1.cor = "Vermelho";

        Console.WriteLine("Marca.: {0}",c1.marca);
        Console.WriteLine("Modelo: {0}",c1.modelo);
        Console.WriteLine("Cor...: {0}",c1.cor);

        Carro c2 = new Carro("VW","Fusca","Bege");

        Console.WriteLine("Marca.: {0}",c2.marca);
        Console.WriteLine("Modelo: {0}",c2.modelo);
        Console.WriteLine("Cor...: {0}",c2.cor);
    }
}