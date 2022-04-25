using System;

class Aula18{
    static void Main(){
        int[,] num = new int[3,5];
        int[,] num2 = new int[2,2]{{10,20},{30,40}};
        /*
        10 20 30 40 50
        60 70 80 90 15
        25 35 45 55 65
        */

        num[0,0] = 10;
        num[0,1] = 20;
        num[0,2] = 30;
        num[0,3] = 40;
        num[0,4] = 50;

        num[1,0] = 60;
        num[1,1] = 70;
        num[1,2] = 80;
        num[1,3] = 90;
        num[1,4] = 15;

        num[2,0] = 25;
        num[2,1] = 35;
        num[2,2] = 45;
        num[2,3] = 55;
        num[2,4] = 65;

        Console.WriteLine(num[1,3]);
    }
}