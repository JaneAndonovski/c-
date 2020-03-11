using System;
using System.Threading;

namespace SEDC.Class01.Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic light...");
            Thread.Sleep(4000);

            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red light - STOP",
                              Console.BackgroundColor);
            Thread.Sleep(4000);



            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ",
                                Console.BackgroundColor);



            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Yellow light - PREPARE.",
                              Console.BackgroundColor);
            Thread.Sleep(4000);


            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ",
                              Console.BackgroundColor);


            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green light - GO",
                                Console.BackgroundColor);
            Thread.Sleep(4000);

            Console.ReadLine();
        }
    }
}
