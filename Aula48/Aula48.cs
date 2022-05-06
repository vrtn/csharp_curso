using System;

class Calc
{
    public int soma(params int[] n)
    {
        int res = 0;

        if (n.Length < 1)
        {
            return 0;
        }
        else if (n.Length < 2)
        {
            return n[0];
        }
        else
        {
            foreach (var i in n)
            {
                res += i;
            }
            return res;
        }
    }

    public double soma(params double[] n)
    {
        double res = 0;

        if (n.Length < 1)
        {
            return 0;
        }
        else if (n.Length < 2)
        {
            return n[0];
        }
        else
        {
            foreach (var i in n)
            {
                res += i;
            }
            return res;
        }
    }

    public int fatorial(int n)
    {
        int res = 0;
        if(n<1)
        {
            res = 1;
        }
        else
        {
            res = n * fatorial(n-1);
        }
        return res;
    }
}

class Aula48
{
    static void Main()
    {
        Calc calc = new Calc();

        //Console.WriteLine(calc.soma());
        Console.WriteLine(calc.soma(1));
        Console.WriteLine(calc.soma(1, 2, 3));
        Console.WriteLine(calc.soma(1.1, 2.2, 3.3));

        Console.WriteLine(calc.fatorial(5));
    }
}