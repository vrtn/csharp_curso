using System;

class Calc
{
    public int soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public int soma(int n1, int n2, int n3)
    {
        return n1+n2+n3;
    }
}
class Aula47
{
    static void Main(){
        Calc calc = new Calc();

        Console.WriteLine(calc.soma(10,5));
        Console.WriteLine(calc.soma(10,5,8));
    }
}