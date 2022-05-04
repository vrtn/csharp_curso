using System;

class Carro
{
    private int velMax;

    public int vm
    {
        get
        {
            return velMax;
        }
        set
        {
            if(value <0)
            {
                velMax = 0;
            }else if (value>300){

            }else{
                velMax = value;
            }
        }
    }

    public Carro()
    {
        this.velMax = 120;
    }

}
class Aula41
{
    static void Main()
    {
        Carro carro = new Carro();

        carro.vm = 200;
        Console.WriteLine("Velocidade: {0}",carro.vm);
    }
}