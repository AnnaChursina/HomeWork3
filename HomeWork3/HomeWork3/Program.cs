using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
           int i=0;
           bool exp=true;
           Numbertron numbertron1 = new Numbertron();
            Gambler jay = new Jay();
            Gambler silentBob = new SilentBob();
            //var Jay  = new Jay("Jay");
            // Console.WriteLine(Jay.Name);
            // Jay.FetchNewNumber(); //реализация метода
            numbertron1.NewNumber += jay.FetchNewNumber;
            numbertron1.NewNumber += silentBob.FetchNewNumber;
            do
            {
            Console.WriteLine("Введите количество генерируемых чисел (целое число больше нуля):");
                try
                {
                    i= int.Parse(Console.ReadLine());
                    if (i < 1)
                    {
                        exp = false;
                        Console.WriteLine("A figure can't be <0 or =0!");
                    }
                    else exp = true;
                }
                catch
                {
                    Console.WriteLine("Wrong number format! Try again...");
                    exp = false;
                }
            } while (exp == false);
            for (var n = 0; n <= i; n++)
            {
                numbertron1.Generate();
            }
            if (silentBob.Score > jay.Score)
            {
                Console.WriteLine("Silent bob win");
            }
            if (silentBob.Score < jay.Score)
            {
                Console.WriteLine("Jay win");
            }
            if (silentBob.Score == jay.Score)
            {
                Console.WriteLine("Draw!");
            }
            Console.ReadKey();
        }
    }
}
