using System;

class Aula10
{

    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };

    static void Main()
    {

        int ds = (int)DiasSemana.Sábado;

        Console.WriteLine(ds);

    }
}
// --------------------------------------------------------
// using System;

// class Aula10{

//     enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

//     static void Main(){
//         DiasSemana ds = (DiasSemana)3;
//         Console.WriteLine(ds);
//     }
// }
// ---------------------------------------------------------
// using System;

// class Aula10{

//     enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado};

//     static void Main(){
//         DiasSemana ds = DiasSemana.Quarta;
//         Console.WriteLine(ds);
//     }
// }