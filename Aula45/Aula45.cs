using System;

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public void info()
    {
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
        Console.WriteLine("--------------------------");
    }
}

class Aula45
{
    static void Main()
    {
        Carro[] carro = new Carro[4];

        carro[0].marca = "Ford";
        carro[0].modelo = "Escort";
        carro[0].cor = "Preto";
               
        carro[1].marca = "Ford";
        carro[1].modelo = "Belina";
        carro[1].cor = "Vermelho";

        carro[2].marca = "VW";
        carro[2].modelo = "Polo";
        carro[2].cor = "Cinza";

        carro[3].marca = "Fiat";
        carro[3].modelo = "Uno";
        carro[3].cor = "Branco";

        foreach(var c in carro)
        {
            c.info();
        }
    }
}