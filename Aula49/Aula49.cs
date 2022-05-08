using System;

class Mat
{
    public static double pi = 3.14;

    public static int dobro(int n)
    {
        return n*2;
    }
}

class Aula49
{
    static void Main()
    {
        double vpi = Mat.pi;

        Console.WriteLine(Mat.dobro(10));
        Console.WriteLine(vpi);

    }
}