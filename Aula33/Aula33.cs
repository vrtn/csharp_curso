using System;

class Jogador
{
    private string nome;
    private int energia;

    public Jogador(string nome)
    {
        this.nome = nome;
        this.energia = 100;
    }

    public string getNome()
    {
        return nome;
    }

    public int getEnergia()
    {
        return energia;
    }

    public void setEnergia(int e)
    {
        if (e < 0)
        {
            if (energia - e < 0)
            {
                energia = 0;
            }
            else
            {
                energia += e;
            }
        }
        else if (e > 0)
        {
            if(energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }
    }

}

class Aula33
{
    static void Main()
    {
        Jogador j1 = new Jogador("Zanini");

        j1.setEnergia(-30);
        j1.setEnergia(15);

        Console.WriteLine("Jogador 1: {0}", j1.getNome());
        Console.WriteLine("Energia: {0}", j1.getEnergia());
    }
}