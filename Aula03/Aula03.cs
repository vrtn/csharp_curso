using System;

class Aula03
{
    static void Main()
    {
        byte n1 = 10; // 0 e 255
        int num = 0;
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Zanini";

        var aux = nome;

        int num1, num2, res;
        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        Console.WriteLine("Valor da variável: " + aux);
        Console.WriteLine("A multiplicação de " + num1 + " e " + num2 + " é igual a: " + res);
    }
}