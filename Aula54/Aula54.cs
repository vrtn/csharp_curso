using System;

namespace Calc
{
    class Area
    {
        public static double quadrado(double largura, double altura)
        {
            if (largura == 0 || altura == 0)
            {
                throw new Exception("Valores precisam ser maiores que zero...");
            }
            return largura * altura;
        }
    }
}

class Aula54
{
    static void Main()
    {
        double area = 0;

        try
        {
            area = Calc.Area.quadrado(10.0, 0.0);
            Console.WriteLine("Área do Quadrado: {0}m²", area);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERRO........: {0}", e.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo.");
            // area = Area.quadrado(10.0, 5.0);
            // Console.WriteLine("Área do Quadrado: {0}m²", area);
        }

    }
}