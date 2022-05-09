using System;

class Aula51
{
    static void Main(string[] args)
    {
        int res = 0;

        if(args.Length > 0)
        {
            Console.WriteLine("Qtde args: {0}",args.Length);
            foreach( var i in args)
            {
                res += Int32.Parse(i);
            }
            Console.WriteLine("Soma: {0}",res);
        }
        else
        {
            Console.WriteLine("Não foram passados Arqgumentos");
        }
        
    }
}