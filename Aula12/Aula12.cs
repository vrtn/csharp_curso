using System;

class Aula12
{
    static void Main()
    {
        int n1, n2, n3, n4;
        n1 = n2 = n3 = n4 = 0;

        float res = 0;

        string resultado = "Reprovado";

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2:");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3:");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4:");
        n4 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;

        if (res >= 60){
            resultado = "Aprovado";
        }

        Console.WriteLine("Resultado: {0}, média: {1}",resultado,res);

    }
}

//////////////////////////////////
// using System;

// class Aula12{
//     static void Main(){
//         int nota=0;
//         string resultado = "Reprovado";

//         Console.Write("Digite a nota: ");
//         nota = int.Parse(Console.ReadLine());

//         if (nota >=60){
//             resultado = "Aprovado";
//         }

//         Console.WriteLine("Resultado: {0}",resultado);
//     }
// }


////////////////////////////////
// using System;

// class Aula12{
//     static void Main(){

//         int nota = 50;
//         string resultado = "Reprovado";

//         if(nota >= 60){
//             resultado = "Aprovado";
//         }

//         Console.WriteLine("Resultado: {0}",resultado);
//     }
// }