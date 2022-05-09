using System;
using System.Collections.Generic;

class Aula58
{
    static void Main()
    {
        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>();

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        carros2.AddRange(carros);
        //carros2.Clear();

        // if(carros2.Contains("Golf")){
        //     Console.WriteLine("Encontrado");
        // }

        carros2.Insert(1,"Cruize");

        //carros2.Remove("Argo");
        //carros2.RemoveAt(0);

        carros2.Sort();
        carros2.Reverse();

        foreach(var carro in carros2)
        {
            Console.WriteLine("Carro: {0}",carro);
        }

        Console.WriteLine(carros2.Count);
        Console.WriteLine(carros2.Capacity);
    }
}