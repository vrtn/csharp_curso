using System;

class Aula24{
    static void Main(){
        Cfb();
    }

    static void Cfb(){

        int v1, v2;

        int res = 0;

        v1=int.Parse(Console.ReadLine());
        v2=int.Parse(Console.ReadLine());

        Console.WriteLine("CFB Cursos");
        Console.WriteLine("Curso de C#");
        Console.WriteLine("youtube.com/cfbcursos");

        soma(v1,v2);

        res = multiplicacao(v1,v2);

        Console.WriteLine("A multiplicação de {0} e {1} é {2}",v1,v2,res);
    }

    static void soma(int n1, int n2){
        int res = n1 + n2;
        Console.WriteLine("A Soma de {0} e {1} é: {2}",n1,n2,res);
    }

    static int multiplicacao(int n1, int n2){
        int res = n1 * n2;
        return res;
    }
}