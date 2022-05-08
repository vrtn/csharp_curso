using System;

delegate int Op(int n1, int n2);

class Mat
{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }

    public static int mult(int n1, int n2)
    {
        return n1 * n2;
    }
}
class Aula50
{
    static void Main()
    {
        int res;

        Op deleg1 = new Op(Mat.soma);

        res = deleg1(10,50);

        Console.WriteLine("Soma: {0}",res);

        deleg1 = new Op(Mat.mult);

        res = deleg1(10,50);

        Console.WriteLine("Multiplicação: {0}",res);

    }
}