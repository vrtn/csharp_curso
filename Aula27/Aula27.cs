using System;

class Aula27{
    static void Main(){
        soma(10,11,15,47,21,21,84);
    }

    static void soma(params int[] numeros){
        int res = 0;

        if(numeros.Length < 1){
            Console.WriteLine("Não existem valores para a soma...");
        }else if(numeros.Length < 2){
            Console.WriteLine("Valores insuficientes para soma: {0}", numeros[0]);
        } else {
            foreach(int n in numeros){
                res += n;
            }
        }

        Console.WriteLine("Soma: {0} ",res);

    }
}